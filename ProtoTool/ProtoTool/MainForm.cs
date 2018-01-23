using System;
using System.Windows.Forms;
using CCWin;
using CCWin.SkinControl;
using ProtoTool.View;

namespace ProtoTool
{
    public partial class MainForm : CCSkinMain
    {
        private ProtoView protoView;

        private ParamView paramView;

        public MainForm()
        {
            InitializeComponent();

            protoView = new ProtoView(this);
            paramView = new ParamView(this);
        }

        #region -----Public Properties------

        public SkinTreeView ProtoTree
        {
            get { return protoTree; }
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

        }
    }
}
