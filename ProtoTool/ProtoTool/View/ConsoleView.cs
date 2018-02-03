using System;
using System.Reflection;
using LuaFramework;
using Riverlake.Network;

namespace ProtoTool.View
{
    public class ConsoleView
    {
        private MainForm mainForm;

        public ConsoleView(MainForm form)
        {
            this.mainForm = form;

            NetworkManager.Instance.DispathEvent += DispathProtoMessageEvent;
        }

        private void DispathProtoMessageEvent(int protoEvent, ByteBuffer buffer)
        {
            if (protoEvent != Protocal.Message) return;

            int protoId = buffer.ReadShort();
            string protoName = "";
            if (!NetworkManager.Instance.ProtoConfigDic.TryGetValue(protoId, out protoName))
            {
                ConsoleView.LogError("<<ConsoleView,DispathProtoEvent>> 没有找到协议!protoId:" + protoId);
                return;
            }

            Type loginReq = this.mainForm.ProtoView.GetProtoType(protoName);
            if (loginReq == null)
            {
                ConsoleView.LogError("<<ConsoleView,DispathProtoEvent>> 没有找到协议!" + protoName);
                return;
            }
            
            MethodInfo deserializeMethod = loginReq.GetMethod("Deserialize", BindingFlags.Public | BindingFlags.Static);
            object obj = deserializeMethod.Invoke(null, new[] { buffer.ToBytes() });
            string json = LitJson.JsonMapper.ToJson(obj);
            Console.WriteLine(json);
        }


        public static void Log(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void LogWarning(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void LogError(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}