using System;
using CCWin;
using ProtoTool.View;

namespace ProtoTool
{
    public partial class MainForm : CCSkinMain
    {
        private ProtoView protoView;

        public MainForm()
        {
            InitializeComponent();

            protoView = new ProtoView(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
