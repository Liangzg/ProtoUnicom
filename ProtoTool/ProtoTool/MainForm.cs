using System;
using System.Windows.Forms;
using CCWin;
using CCWin.SkinControl;
using LuaFramework;
using ProtoTool.View;

namespace ProtoTool
{
    public partial class MainForm : CCSkinMain
    {
        private ProtoView protoView;

        private ParamView paramView;

        private LoginView loginView;

        private ConsoleView consoleView;
        public MainForm()
        {
            InitializeComponent();

            protoView = new ProtoView(this);
            paramView = new ParamView(this);
            loginView = new LoginView(this);
            consoleView = new ConsoleView(this);
        }

        #region -----Public Properties------

        public SkinTreeView ProtoTree
        {
            get { return protoTree; }
        }

        public ProtoView ProtoView
        {
            get { return protoView; }
        }

        public SkinFlowLayoutPanel ParamFlowPanel
        {
            get { return paramFlowPanel; }
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            protoView.InitProtoView(protoTree);
        }

        private void skinLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void skinTextBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void skinListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void skinLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void skinTextBox2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 刷新ProtoBuf Code Files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onReflushProtoCode(object sender, EventArgs e)
        {
            protoView.ReflushProtobufs();
        }

        /// <summary>
        /// 协议结点点击操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onProtoNodeClick(object sender, System.Windows.Forms.TreeNodeMouseClickEventArgs e)
        {
            Type protoType = protoView.GetProtoType(e.Node.Text);

            paramView.ReflushParamsView(protoType);
        }
        /// <summary>
        /// 发送请求协议
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onRequireClick(object sender, EventArgs e)
        {
            ByteBuffer byteBuf = paramView.InstanceProtoClass();
            NetworkManager.Instance.SendMessage(byteBuf);
        }

        private void onLoginClick(object sender, EventArgs e)
        {
            try
            {
                string ipAddress = this.ipTxt.Text;
                int port = Convert.ToInt32(this.portTxt.Text);
                int serverNo = Convert.ToInt32(this.serverIdTxt.Text);
                int hostId = Convert.ToInt32(this.hostIdTxt.Text);
                string serverName = this.serverNameTxt.Text;
                
                loginView.StartLogin(this.accountTxt.Text, serverNo, hostId, serverName , ipAddress , port);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void onFormClosed(object sender, FormClosedEventArgs e)
        {
            NetworkManager.Instance.OnDestroy();
        }
    }
}
