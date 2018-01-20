using System;
using System.Collections.Generic;
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
        private const string genInputDir = @"..\..\..\ProtoSpec\ImportAll.proto";

        private const string genOutputDir = @"..\..\..\Generated\Generated.cs";

        private MainForm mainForm;

        public ProtoView(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        /// <summary>
        /// 刷新ProtoBuf的生成文件
        /// </summary>
        public void ReflushProtobufs()
        {
            this.genProtobufCodeFiles();
        }

        /// <summary>
        /// 生成ProtoBuf 代码文件
        /// </summary>
        private void genProtobufCodeFiles()
        {
            List<string> inputs = new List<string>();
            inputs.Add(genInputDir);

            Options options = Options.Parse(inputs , genOutputDir);

            if (options == null)    return;

            try
            {
                Build(options);
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
    }
}