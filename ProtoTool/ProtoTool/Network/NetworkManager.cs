using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using ProtoTool.View;
using Riverlake.Network;

namespace LuaFramework {
    public sealed class NetworkManager {

        private SocketClient socket;
        private static NetworkManager netMgr;
        static readonly object m_lockObject = new object();
        static Queue<KeyValuePair<int, ByteBuffer>> mEvents = new Queue<KeyValuePair<int, ByteBuffer>>();

        static Queue<KeyValuePair<int, ByteBuffer>> mWeakEvents = new Queue<KeyValuePair<int, ByteBuffer>>();

        private float lastPauseTime;
        public bool inBackground { get; private set; }
        public bool inCharge { get; set; }
        private bool inAppRuning { get; set; }
        public static bool isKickOut { get; set; }

        public bool lostConnect { get { return observer.lostConnect; } }

        public ConnectObserver.AddEvent DispathEvent;

        private ConnectObserver observer;
        
        private float heartBeatDuration = 0;

        private string socketAddress;
        private int socketPort;
        private Dictionary<int, string> protoConfigDic = new Dictionary<int, string>();

        SocketClient SocketClient {
            get {
                if (socket == null)
                    socket = new SocketClient(OnReconnected, LostConnect);
                return socket;                    
            }
        }

        public static NetworkManager Instance
        {
            get
            {
                if(netMgr == null)
                    netMgr = new NetworkManager();
                return netMgr;
            }
        }


        public Dictionary<int, string> ProtoConfigDic
        {
            get { return protoConfigDic; }
        }

        void OnReconnected()
        {
            if (observer.lostConnect)
                ResetConnect();
        }

        private NetworkManager()
        {
            ConnectObserver.eventListener = AddEvent;
            observer = new ConnectObserver(OnLostConnect, KickOut);
            inAppRuning = true;

            this.loadProtoConfig();

            Thread thread = new Thread(new ThreadStart(onUpdateThread));
            thread.Start();
        }

        /// <summary>
        /// 加载ProtoBuff ID映射
        /// </summary>
        private void loadProtoConfig()
        {
            var fullPath = Path.Combine(Directory.GetCurrentDirectory(), ProtoView.genInputDir + "\\proto.conf");
            fullPath = Path.GetFullPath(fullPath);

            string[] lineArr = File.ReadAllLines(fullPath);
            for (int i = 0; i < lineArr.Length; i++)
            {
                string[] protos = lineArr[i].Split(',');
                int protoId = Convert.ToInt32(protos[0]);
                string protoName = protos[1].Substring(protos[1].IndexOf(".") + 1);
                protoConfigDic[protoId] = protoName.Replace("_" , "").ToLower();
            }
        }



        public void Close()
        {
            mEvents.Clear();
            mWeakEvents.Clear();
            ResetConnect();
            SocketClient.StopHeartBeat();
            SocketClient.OnRemove();
        }
        
        ///------------------------------------------------------------------------------------
        public void AddEvent(int _event, ByteBuffer data) {
            try
            {
                if (_event == 0) throw new KeyNotFoundException("0 key is not exist");
                if (_event == Protocal.WeakMessage)
                {
                    lock (m_lockObject)
                    {
                        mWeakEvents.Enqueue(new KeyValuePair<int, ByteBuffer>(_event, data));
                    }
                }
                else
                {
                    lock (m_lockObject)
                    {
                        mEvents.Enqueue(new KeyValuePair<int, ByteBuffer>(_event, data));
                    }
                }
            }
            catch (Exception e)
            {
                ConsoleView.LogError(string.Format("Network AddEvent error: {0}\nStackTrace:{1}", e.Message, e.StackTrace));
            }
        }

        private void UpdateMessage(Queue<KeyValuePair<int, ByteBuffer>> events)
        {
            if (events.Count > 0)
            {
                while (events.Count > 0)
                {
                    lock (m_lockObject)
                    {
                        KeyValuePair<int, ByteBuffer> _event = events.Dequeue();
                        if (_event.Key == 0)
                        {
                            ConsoleView.LogWarning("receive msg that event key = 0");
                            if (!lostConnect && !inBackground) LostConnect();
                            events.Clear();
                        }
                        else if (inAppRuning)
                        {
                            if (_event.Key == Protocal.Exception || _event.Key == Protocal.Disconnect)
                            {
                                if (!lostConnect && !inBackground) LostConnect();
                                events.Clear();
                            }
                        }

                        if (DispathEvent != null)
                        {
                            DispathEvent.Invoke(_event.Key, _event.Value);
                        }
                    }
                }
            }
        }


        private void onUpdateThread()
        {
            float deltaTime = 0;
            long lastTickTime = DateTime.Now.Ticks;
            float frameTime = (1 / 30.0f ) * 10;  //转化为100毫秒为单位的ticks值
            while (inAppRuning)
            {
                long ticks = DateTime.Now.Ticks;
                deltaTime = ticks - lastTickTime;
                lastTickTime = ticks;

                this.FixedUpdate(deltaTime / 100); //转为秒
                
                if (deltaTime < frameTime)
                {   
                    Thread.Sleep((int)(frameTime - deltaTime) * 10);  //转为毫秒
                }
            }
        }

        /// <summary>
        /// 交给Command，这里不想关心发给谁。
        /// </summary>
        public void FixedUpdate(float fixedDeltaTime)
        {
            if (isKickOut) return;

            SocketClient.UpdateHeartBeat2Server(fixedDeltaTime);

            UpdateMessage(mEvents);
            UpdateMessage(mWeakEvents);

            if (inBackground) return;

            if(observer != null)
                observer.UpdateConnectStatus(fixedDeltaTime);
        }

        void OnLostConnect()
        {
            if (SocketClient != null)
                SocketClient.Close();

            AddEvent(Protocal.BeginReconnect, new ByteBuffer());
            SendConnect(this.socketAddress , this.socketPort);
            Console.WriteLine("reconnecting to the server...");
        }

        /// <summary>
        /// 发送链接请求
        /// </summary>
        public void SendConnect(string address, int port) {
            socketAddress = address;
            socketPort = port;
            SocketClient.SendConnect(socketAddress, socketPort);
        }

        public void StartHeartBeat()
        {
            ConnectObserver.reconnectCount = 0;
            SocketClient.StartHeartBeat();
        }

        void LostConnect()
        {
            observer.LostConnect(() =>
            {
                ConsoleView.LogWarning("lost connect from server");
                SocketClient.StopHeartBeat();
            });
        }

        void ResetConnect()
        {
            observer.ResetConnect();
        }

        public void KickOut(int protocal)
        {
            ResetConnect();
            SocketClient.DisconnectFromServer(protocal);
        }

        public void SetPowerSaveMode(bool bSet)
        {
            if (ConnectObserver.powerSaveMode && !bSet)
                SocketClient.ResetTimeout();

            ConnectObserver.powerSaveMode = bSet;
        }

        /// <summary>
        /// 发送SOCKET消息
        /// </summary>
        public void SendMessage(ByteBuffer buffer) {
            SocketClient.SendMessage(buffer);
        }

        public void SendMessage(byte[] msgBytes)
        {
            SocketClient.SessionSend(msgBytes);
        }

        /// <summary>
        /// 析构函数
        /// </summary>
        public void OnDestroy() {
            Close();
            inAppRuning = false;
            observer = null;
            ConnectObserver.eventListener = null;
            Console.WriteLine("~NetworkManager was destroy");
        }

//        public void OnApplicationPause(bool paused)
//        {
//            if (paused)
//            {
//                inBackground = true;
//                lastPauseTime = VisualStyleElement.TaskbarClock.Time.realtimeSinceStartup;
//            }
//            else
//            {
//                //SocketClient.ResetTimeout();
//                if (!inCharge)
//                {
//                    inBackground = false;
//                    SocketClient.CheckHeartBeat();
//                    //if (!SocketClient.IsConnected())
//                    //{
//                    //    KickOut();
//                    //}
//                }
//                inCharge = false;
//            }
//        }
    }
}