using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using CCWin.SkinControl;
using LitJson;
using LuaFramework;
using ProtoTool.Properties;
using Riverlake.Network;
using XUPorterJSON;

namespace ProtoTool.View
{

    public class LoginView
    {
        private MainForm mainForm;

        private string account;
        private int serverId;
        private int hostId;
        private string serverName;

        public LoginView(MainForm form)
        {
            this.mainForm = form;

            NetworkManager.Instance.DispathEvent += dispathConnectedEvent;

            this.InitView();
        }

        private void dispathConnectedEvent(int eventId, ByteBuffer buffer)
        {
            if (eventId != Protocal.Connect) return;
            
            this.OnLogin(this.account , this.serverId , this.hostId , this.serverName);

        }


        public void InitView()
        {
            ServerInfo[] serverInfos = parseServerInfo();
            SkinListView serverListView = mainForm.serverListView;
            //serverListView.Container.Add(mainForm.serverVBar);
            serverListView.Items.Clear();

            foreach (ServerInfo serverInfo in serverInfos)
            {
                ListViewItem viewItem = new ListViewItem(serverInfo.serverName);
                viewItem.Tag = serverInfo;
                serverListView.Items.Add(viewItem);
            }
            
            serverListView.ItemSelectionChanged += onItemSelectChanged;
//            serverListView.ItemChecked += onCheckServerItem;
        }
        /// <summary>
        /// 服务器列表单项选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void onItemSelectChanged(object sender, ListViewItemSelectionChangedEventArgs args)
        {
            ServerInfo serverInfo = args.Item.Tag as ServerInfo;

            mainForm.serverNameTxt.Text = serverInfo.serverName;
            mainForm.serverIdTxt.Text = Convert.ToString(serverInfo.serverNo);
            mainForm.ipTxt.Text = serverInfo.serverIp;
            mainForm.portTxt.Text = serverInfo.serverPort;
            mainForm.hostIdTxt.Text = serverInfo.hostId;
        }


        /// <summary>
        /// 解析服务器列表
        /// </summary>
        /// <returns></returns>
        private  ServerInfo[] parseServerInfo()
        {
            string _serverInfo = Resources.ServerInfo;
            Hashtable tbl = MiniJSON.jsonDecode(_serverInfo) as Hashtable;

            
            ArrayList list = tbl["serverlist"] as ArrayList;
            Hashtable serverTbl;
            int len = list.Count;
            ServerInfo[]  serverInfoArr = new ServerInfo[len];
            for (int i = 0; i < len; i++)
            {
                serverTbl = list[i] as Hashtable;

                ServerInfo info = new ServerInfo();
                info.openTime = i;
                info.serverNo = Convert.ToInt32(serverTbl["server_no"].ToString());
                info.serverName = serverTbl["server_name"].ToString();
                info.serverIp = serverTbl["ip"].ToString();
                info.serverPort = serverTbl["port"].ToString();
                info.isOpen = Convert.ToInt32(serverTbl["is_open"].ToString());
                info.other = serverTbl["other"].ToString();
                info.hostId = serverTbl["host_id"].ToString();
                if (serverTbl.ContainsKey("corp_id"))
                    info.corpId = serverTbl["corp_id"].ToString();
                else
                    info.corpId = "1000";

                serverInfoArr[i] = info;
            }

            Array.Sort(serverInfoArr , (x, y) => x.serverNo.CompareTo(y.serverNo));

            return serverInfoArr;
        }


        public void StartLogin(string account, int serverId, int hostId, string serverName , string ipAddress , int port)
        {
            this.account = account;
            this.serverId = serverId;
            this.hostId = hostId;
            this.serverName = serverName;

            NetworkManager.Instance.SendConnect(ipAddress, port);
        }

        public void OnLogin(string account, int serverId, int hostId , string serverName)
        {
            Type loginReq = this.mainForm.ProtoView.GetProtoType("C2sLoginCorpAccount");
            if (loginReq == null)
            {
                ConsoleView.LogError("没有找到登录协议!");
                return;
            }

            object insObj = Activator.CreateInstance(loginReq , true);
            
            loginReq.GetProperty("CorpId").SetValue(insObj , 0 , null);
            loginReq.GetProperty("LoginTime").SetValue(insObj , (int)Utils.CurrentTotalSeconds(), null);
            loginReq.GetProperty("Adult").SetValue(insObj , 0 , null);
            loginReq.GetProperty("Acct").SetValue(insObj , account , null);
            loginReq.GetProperty("Sign").SetValue(insObj , "", null);

            string extdata = string.Format("jihuo=1|serverid={0}|acct_id={1}|servername={2}", hostId,account, serverName);
            loginReq.GetProperty("Extdata").SetValue(insObj , extdata , null);

            MethodInfo serializeMethod = loginReq.GetMethod("SerializeToBytes", BindingFlags.Public | BindingFlags.Static);
            byte[] msgBytes = (byte[])serializeMethod.Invoke(null, new[] { insObj });

            ConsoleView.Log("Login :" + JsonMapper.ToJson(insObj));
            NetworkManager.Instance.SendMessage(msgBytes);
        }
    }

    /// <summary>
    /// 服务器信息
    /// </summary>
    public class ServerInfo
    {
        public int serverNo;
        public string serverName;
        public string serverIp;
        public string serverPort;
        public int status;
        public int isNew;
        public int openTime;
        /// <summary>
        /// 玩家等级（用于最近服务器列表）
        /// </summary>
        public int playerLevel;

        //保留字段（兼容性）
        public int isOpen;
        public string other;

        //对应serverid10
        public string hostId;
        public string corpId;
        public string tips;
    }
}