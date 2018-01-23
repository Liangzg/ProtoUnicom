using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using CCWin.SkinControl;
using Microsoft.CSharp;
using SilentOrbit.ProtocolBuffers;

namespace ProtoTool.View
{
    /// <summary>
    /// 协议视图逻辑
    /// </summary>
    public class ProtoView
    {
        /// <summary>
        /// ProtoBuf 描述文件的根目录
        /// --fix-nameclash --ctor --utc --skip-default ..\..\..\TestProgram\ProtoSpec\ImportAll.proto --output ..\..\..\TestProgram\Generated\Generated.cs
        /// </summary>
        private const string genInputDir = @"..\..\..\ProtoTool\GenProto\ProtoSpec\";

        private const string genOutputDir = @"..\..\..\ProtoTool\GenProto\Generated\Generated.cs";

        private MainForm mainForm;


        /// <summary>
        /// 请求协议
        /// </summary>
        private Dictionary<string ,Type> requireTypes = new Dictionary<string, Type>();
         
        public ProtoView(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        /// <summary>
        /// 初始化协议列表
        /// </summary>
        public void InitProtoView(SkinTreeView treeView)
        {
            var fullPath = Path.Combine(Directory.GetCurrentDirectory(), genOutputDir);
            fullPath = Path.Combine(Path.GetDirectoryName(Path.GetFullPath(fullPath)), "proto.dll");

            treeView.Nodes.Clear();

            if (!File.Exists(fullPath)) return;

            Assembly assembly = Assembly.LoadFrom(fullPath);
            Type[] types = assembly.GetTypes();

            
            Dictionary<string , TreeNode> nodes = new Dictionary<string, TreeNode>();
            foreach (Type type in types)
            {
                string fileName = type.Name;
                string[] spaceNames = type.Namespace.Split('.');
                string namespaceName = spaceNames[spaceNames.Length - 1];
                
                if (fileName.ToLower().StartsWith("c2s"))
                {
                    requireTypes[fileName] = type;

                    TreeNode rootNode = null;
                    if (!nodes.TryGetValue(namespaceName, out rootNode))
                    {
                        rootNode = new TreeNode(namespaceName);
                        nodes[namespaceName] = rootNode;
                        treeView.Nodes.Add(rootNode);
                    }
                    rootNode.Nodes.Add(fileName);
                }
            }
        }

        /// <summary>
        /// 获得指定Proto名的实体类型
        /// </summary>
        /// <param name="protoName"></param>
        /// <returns></returns>
        public Type GetProtoType(string protoName)
        {
            if (!requireTypes.ContainsKey(protoName)) return null;

            return requireTypes[protoName];
        }

        /// <summary>
        /// 刷新ProtoBuf的生成文件
        /// </summary>
        public void ReflushProtobufs()
        {
            this.genProtobufCodeFiles();
            
            this.InitProtoView(this.mainForm.ProtoTree);
        }

        /// <summary>
        /// 生成ProtoBuf 代码文件
        /// </summary>
        private void genProtobufCodeFiles()
        {
            var fullPath = Path.Combine(Directory.GetCurrentDirectory(), genInputDir);
            fullPath = Path.GetFullPath(fullPath);
            string[] protoFiles = Directory.GetFiles(fullPath , "*.proto" , SearchOption.AllDirectories);

            List<string> inputs = new List<string>();
            inputs.AddRange(protoFiles);

            Options options = Options.Parse(inputs , genOutputDir);

            if (options == null)    return;

            try
            {
                Build(options);

                Console.WriteLine("gen protobuf Cshap code file success!");

                fullPath = Path.Combine(Directory.GetCurrentDirectory(), genOutputDir);
                fullPath = Path.GetDirectoryName(Path.GetFullPath(fullPath));
                string[] csFiles = Directory.GetFiles(fullPath, "*.cs", SearchOption.AllDirectories);
                CompilerResults results = dynamicCompilerDll(csFiles, Path.Combine(fullPath, "proto.dll"));
                if (results.Errors.HasErrors)
                {
                    foreach (CompilerError ce in results.Errors)
                    {
                        Console.WriteLine(ce.ToString());
                    }
                }
                else
                {
                    //this.clearCodeFiles(csFiles);

                    Console.WriteLine("gen dll success!");
                }
                    
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }

        public static void Build(Options options)
        {
            var parser = new FileParser();
            var collection = parser.Import(options.InputProto);

            Console.WriteLine(collection);

            //Interpret and reformat
            try
            {
                var pp = new ProtoPrepare(options);
                pp.Prepare(collection);
            }
            catch (ProtoFormatException pfe)
            {
                Console.WriteLine();
                Console.WriteLine(pfe.SourcePath.Path + "(" + pfe.SourcePath.Line + "," + pfe.SourcePath.Column + "): error CS001: " + pfe.Message);
                throw;
            }

            //Generate code
            ProtoCode.Save(collection, options);
            Console.WriteLine("Saved: " + options.OutputPath);
        }

        /// <summary>
        /// 动态编译代码文件，生成DLL
        /// </summary>
        /// <param name="codePaths"></param>
        /// <param name="dllPath"></param>
        /// <returns></returns>
        private CompilerResults dynamicCompilerDll(string[] codePaths, string dllPath)
        {
            string[] codes = new string[codePaths.Length];
            for (int i = 0; i < codePaths.Length; i++)
            {
                codes[i] = File.ReadAllText(codePaths[i]);
            }
            CSharpCodeProvider complier = new CSharpCodeProvider();
            //设置编译参数
            CompilerParameters paras = new CompilerParameters();
            //引入第三方dll
            paras.ReferencedAssemblies.Add(@"System.dll");
            //            paras.ReferencedAssemblies.Add(@"System.IO.dll");
            //            paras.ReferencedAssemblies.Add(@"System.Text.dll");
            //            paras.ReferencedAssemblies.Add(@"System.Collections.dll");
            //            paras.ReferencedAssemblies.Add(@"System.Collections.Generic.dll");
            //            paras.ReferencedAssemblies.Add(@"System.configuration.dll");
            //            paras.ReferencedAssemblies.Add(@"System.Data.dll");
            //            paras.ReferencedAssemblies.Add(@"System.Management.dll");
            //            paras.ReferencedAssemblies.Add(@"System.Web.dll");
            //            paras.ReferencedAssemblies.Add(@"System.Xml.dll");
            string protoBufLibPath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\Libs\ProtobufLib.dll");
            protoBufLibPath = Path.GetFullPath(protoBufLibPath);
            paras.ReferencedAssemblies.Add(protoBufLibPath);
            //引入自定义dll
            //paras.ReferencedAssemblies.Add(@"D:\自定义方法\自定义方法\bin\LogHelper.dll");
            //是否内存中生成输出
            paras.GenerateInMemory = false;
            //是否生成可执行文件
            paras.GenerateExecutable = false;
            paras.OutputAssembly = dllPath;

            //编译代码
            CompilerResults result = complier.CompileAssemblyFromSource(paras, codes);

            return result;
        }
        /// <summary>
        /// 清理删除打包DLL完成后的代码文件
        /// </summary>
        private void clearCodeFiles(string[] codePaths)
        {
            for (int i = 0; i < codePaths.Length; i++)
            {
                File.Delete(codePaths[i]);
            }
        }
    }
}