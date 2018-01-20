namespace ProtoTool
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("技能");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Buff");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("战斗", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("主界面");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("商城");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("聊天");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("UI", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ProtosTabCtrl = new CCWin.SkinControl.SkinTabControl();
            this.allProtosTab = new CCWin.SkinControl.SkinTabPage();
            this.protoTree = new CCWin.SkinControl.SkinTreeView();
            this.skinToolStrip2 = new CCWin.SkinControl.SkinToolStrip();
            this.btnReflush = new System.Windows.Forms.ToolStripButton();
            this.myProtosTab = new CCWin.SkinControl.SkinTabPage();
            this.skinTabControl2 = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPage3 = new CCWin.SkinControl.SkinTabPage();
            this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
            this.chatListBox1 = new CCWin.SkinControl.ChatListBox();
            this.skinToolStrip1 = new CCWin.SkinControl.SkinToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.skinTabControl3 = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPage4 = new CCWin.SkinControl.SkinTabPage();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinTabControl4 = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPage5 = new CCWin.SkinControl.SkinTabPage();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox3 = new CCWin.SkinControl.SkinTextBox();
            this.skinTextBox2 = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.ProtosTabCtrl.SuspendLayout();
            this.allProtosTab.SuspendLayout();
            this.skinToolStrip2.SuspendLayout();
            this.skinTabControl2.SuspendLayout();
            this.skinTabPage3.SuspendLayout();
            this.skinToolStrip1.SuspendLayout();
            this.skinTabControl3.SuspendLayout();
            this.skinTabPage4.SuspendLayout();
            this.skinTabControl4.SuspendLayout();
            this.skinTabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProtosTabCtrl
            // 
            this.ProtosTabCtrl.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.ProtosTabCtrl.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ProtosTabCtrl.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.ProtosTabCtrl.Controls.Add(this.allProtosTab);
            this.ProtosTabCtrl.Controls.Add(this.myProtosTab);
            this.ProtosTabCtrl.HeadBack = null;
            this.ProtosTabCtrl.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.ProtosTabCtrl.ItemSize = new System.Drawing.Size(70, 36);
            this.ProtosTabCtrl.Location = new System.Drawing.Point(7, 31);
            this.ProtosTabCtrl.Name = "ProtosTabCtrl";
            this.ProtosTabCtrl.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("ProtosTabCtrl.PageArrowDown")));
            this.ProtosTabCtrl.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("ProtosTabCtrl.PageArrowHover")));
            this.ProtosTabCtrl.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("ProtosTabCtrl.PageCloseHover")));
            this.ProtosTabCtrl.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("ProtosTabCtrl.PageCloseNormal")));
            this.ProtosTabCtrl.PageDown = ((System.Drawing.Image)(resources.GetObject("ProtosTabCtrl.PageDown")));
            this.ProtosTabCtrl.PageDownTxtColor = System.Drawing.SystemColors.ActiveBorder;
            this.ProtosTabCtrl.PageHover = ((System.Drawing.Image)(resources.GetObject("ProtosTabCtrl.PageHover")));
            this.ProtosTabCtrl.PageHoverTxtColor = System.Drawing.SystemColors.ActiveBorder;
            this.ProtosTabCtrl.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.ProtosTabCtrl.PageNorml = null;
            this.ProtosTabCtrl.PageNormlTxtColor = System.Drawing.SystemColors.ActiveBorder;
            this.ProtosTabCtrl.SelectedIndex = 0;
            this.ProtosTabCtrl.Size = new System.Drawing.Size(178, 543);
            this.ProtosTabCtrl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.ProtosTabCtrl.TabIndex = 0;
            // 
            // allProtosTab
            // 
            this.allProtosTab.BackColor = System.Drawing.Color.White;
            this.allProtosTab.Controls.Add(this.protoTree);
            this.allProtosTab.Controls.Add(this.skinToolStrip2);
            this.allProtosTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allProtosTab.Location = new System.Drawing.Point(0, 36);
            this.allProtosTab.Name = "allProtosTab";
            this.allProtosTab.Size = new System.Drawing.Size(178, 507);
            this.allProtosTab.TabIndex = 0;
            this.allProtosTab.TabItemImage = null;
            this.allProtosTab.Text = "协议列表";
            // 
            // protoTree
            // 
            this.protoTree.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.protoTree.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.protoTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.protoTree.CheckBoxes = true;
            this.protoTree.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.protoTree.ItemHeight = 16;
            this.protoTree.Location = new System.Drawing.Point(0, 23);
            this.protoTree.Name = "protoTree";
            treeNode1.Name = "节点3";
            treeNode1.Text = "技能";
            treeNode2.Name = "节点4";
            treeNode2.Text = "Buff";
            treeNode3.Name = "节点0";
            treeNode3.Text = "战斗";
            treeNode4.Name = "节点2";
            treeNode4.Text = "主界面";
            treeNode5.Name = "节点0";
            treeNode5.Text = "商城";
            treeNode6.Name = "节点1";
            treeNode6.Text = "聊天";
            treeNode7.Name = "节点1";
            treeNode7.Text = "UI";
            this.protoTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode7});
            this.protoTree.Size = new System.Drawing.Size(166, 484);
            this.protoTree.TabIndex = 3;
            // 
            // skinToolStrip2
            // 
            this.skinToolStrip2.Arrow = System.Drawing.Color.Black;
            this.skinToolStrip2.Back = System.Drawing.Color.Transparent;
            this.skinToolStrip2.BackRadius = 4;
            this.skinToolStrip2.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinToolStrip2.Base = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skinToolStrip2.BaseFore = System.Drawing.SystemColors.ActiveBorder;
            this.skinToolStrip2.BaseForeAnamorphosis = false;
            this.skinToolStrip2.BaseForeAnamorphosisBorder = 4;
            this.skinToolStrip2.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinToolStrip2.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.skinToolStrip2.BaseHoverFore = System.Drawing.Color.White;
            this.skinToolStrip2.BaseItemAnamorphosis = true;
            this.skinToolStrip2.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.BaseItemBorderShow = true;
            this.skinToolStrip2.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinToolStrip2.BaseItemDown")));
            this.skinToolStrip2.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinToolStrip2.BaseItemMouse")));
            this.skinToolStrip2.BaseItemNorml = null;
            this.skinToolStrip2.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.BaseItemRadius = 4;
            this.skinToolStrip2.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip2.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.BindTabControl = null;
            this.skinToolStrip2.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinToolStrip2.Fore = System.Drawing.Color.Black;
            this.skinToolStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.skinToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.skinToolStrip2.HoverFore = System.Drawing.Color.White;
            this.skinToolStrip2.ItemAnamorphosis = true;
            this.skinToolStrip2.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.ItemBorderShow = true;
            this.skinToolStrip2.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.ItemRadius = 4;
            this.skinToolStrip2.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReflush});
            this.skinToolStrip2.Location = new System.Drawing.Point(0, 0);
            this.skinToolStrip2.Name = "skinToolStrip2";
            this.skinToolStrip2.RadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.skinToolStrip2.Size = new System.Drawing.Size(178, 25);
            this.skinToolStrip2.SkinAllColor = true;
            this.skinToolStrip2.TabIndex = 2;
            this.skinToolStrip2.Text = "skinToolStrip2";
            this.skinToolStrip2.TitleAnamorphosis = true;
            this.skinToolStrip2.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinToolStrip2.TitleRadius = 4;
            this.skinToolStrip2.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // btnReflush
            // 
            this.btnReflush.BackColor = System.Drawing.Color.Transparent;
            this.btnReflush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnReflush.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnReflush.Image = ((System.Drawing.Image)(resources.GetObject("btnReflush.Image")));
            this.btnReflush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReflush.Name = "btnReflush";
            this.btnReflush.Size = new System.Drawing.Size(54, 22);
            this.btnReflush.Text = "Reflush";
            this.btnReflush.Click += new System.EventHandler(this.onReflushProtoCode);
            // 
            // myProtosTab
            // 
            this.myProtosTab.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.myProtosTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myProtosTab.Location = new System.Drawing.Point(0, 36);
            this.myProtosTab.Name = "myProtosTab";
            this.myProtosTab.Size = new System.Drawing.Size(178, 507);
            this.myProtosTab.TabIndex = 1;
            this.myProtosTab.TabItemImage = null;
            this.myProtosTab.Text = "我的协议";
            // 
            // skinTabControl2
            // 
            this.skinTabControl2.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.skinTabControl2.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl2.Controls.Add(this.skinTabPage3);
            this.skinTabControl2.HeadBack = null;
            this.skinTabControl2.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl2.ItemSize = new System.Drawing.Size(70, 36);
            this.skinTabControl2.Location = new System.Drawing.Point(188, 32);
            this.skinTabControl2.Name = "skinTabControl2";
            this.skinTabControl2.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl2.PageArrowDown")));
            this.skinTabControl2.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl2.PageArrowHover")));
            this.skinTabControl2.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl2.PageCloseHover")));
            this.skinTabControl2.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl2.PageCloseNormal")));
            this.skinTabControl2.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl2.PageDown")));
            this.skinTabControl2.PageDownTxtColor = System.Drawing.SystemColors.ActiveBorder;
            this.skinTabControl2.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl2.PageHover")));
            this.skinTabControl2.PageHoverTxtColor = System.Drawing.SystemColors.ActiveBorder;
            this.skinTabControl2.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl2.PageNorml = null;
            this.skinTabControl2.PageNormlTxtColor = System.Drawing.SystemColors.ActiveBorder;
            this.skinTabControl2.SelectedIndex = 0;
            this.skinTabControl2.Size = new System.Drawing.Size(510, 552);
            this.skinTabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl2.TabIndex = 1;
            // 
            // skinTabPage3
            // 
            this.skinTabPage3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.skinTabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinTabPage3.BackgroundImage")));
            this.skinTabPage3.Controls.Add(this.skinTextBox1);
            this.skinTabPage3.Controls.Add(this.chatListBox1);
            this.skinTabPage3.Controls.Add(this.skinToolStrip1);
            this.skinTabPage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage3.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage3.Name = "skinTabPage3";
            this.skinTabPage3.Size = new System.Drawing.Size(510, 516);
            this.skinTabPage3.TabIndex = 0;
            this.skinTabPage3.TabItemImage = null;
            this.skinTabPage3.Text = "Console";
            // 
            // skinTextBox1
            // 
            this.skinTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox1.CausesValidation = false;
            this.skinTextBox1.DownBack = ((System.Drawing.Bitmap)(resources.GetObject("skinTextBox1.DownBack")));
            this.skinTextBox1.Icon = null;
            this.skinTextBox1.IconIsButton = false;
            this.skinTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.IsPasswordChat = '\0';
            this.skinTextBox1.IsSystemPasswordChar = false;
            this.skinTextBox1.Lines = new string[] {
        "skinTextBox1"};
            this.skinTextBox1.Location = new System.Drawing.Point(-5, 213);
            this.skinTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox1.MaxLength = 32767;
            this.skinTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox1.MouseBack = ((System.Drawing.Bitmap)(resources.GetObject("skinTextBox1.MouseBack")));
            this.skinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.Multiline = true;
            this.skinTextBox1.Name = "skinTextBox1";
            this.skinTextBox1.NormlBack = ((System.Drawing.Bitmap)(resources.GetObject("skinTextBox1.NormlBack")));
            this.skinTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox1.ReadOnly = false;
            this.skinTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.skinTextBox1.Size = new System.Drawing.Size(520, 299);
            // 
            // 
            // 
            this.skinTextBox1.SkinTxt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox1.SkinTxt.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.skinTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox1.SkinTxt.Multiline = true;
            this.skinTextBox1.SkinTxt.Name = "BaseText";
            this.skinTextBox1.SkinTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.skinTextBox1.SkinTxt.Size = new System.Drawing.Size(510, 289);
            this.skinTextBox1.SkinTxt.TabIndex = 0;
            this.skinTextBox1.SkinTxt.Text = "skinTextBox1";
            this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.SkinTxt.WaterText = "";
            this.skinTextBox1.TabIndex = 4;
            this.skinTextBox1.Text = "skinTextBox1";
            this.skinTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.WaterText = "";
            this.skinTextBox1.WordWrap = true;
            // 
            // chatListBox1
            // 
            this.chatListBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.chatListBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatListBox1.ForeColor = System.Drawing.Color.Black;
            this.chatListBox1.FriendsMobile = true;
            this.chatListBox1.ListSubItemMenu = null;
            this.chatListBox1.Location = new System.Drawing.Point(-1, 23);
            this.chatListBox1.Name = "chatListBox1";
            this.chatListBox1.SelectSubItem = null;
            this.chatListBox1.Size = new System.Drawing.Size(512, 194);
            this.chatListBox1.SubItemMenu = null;
            this.chatListBox1.TabIndex = 3;
            this.chatListBox1.Text = "chatListBox1";
            // 
            // skinToolStrip1
            // 
            this.skinToolStrip1.Arrow = System.Drawing.Color.Black;
            this.skinToolStrip1.AutoSize = false;
            this.skinToolStrip1.Back = System.Drawing.Color.White;
            this.skinToolStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.skinToolStrip1.BackRadius = 4;
            this.skinToolStrip1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinToolStrip1.Base = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skinToolStrip1.BaseFore = System.Drawing.SystemColors.ActiveBorder;
            this.skinToolStrip1.BaseForeAnamorphosis = false;
            this.skinToolStrip1.BaseForeAnamorphosisBorder = 4;
            this.skinToolStrip1.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinToolStrip1.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.skinToolStrip1.BaseHoverFore = System.Drawing.Color.White;
            this.skinToolStrip1.BaseItemAnamorphosis = true;
            this.skinToolStrip1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.BaseItemBorderShow = true;
            this.skinToolStrip1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinToolStrip1.BaseItemDown")));
            this.skinToolStrip1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinToolStrip1.BaseItemMouse")));
            this.skinToolStrip1.BaseItemNorml = null;
            this.skinToolStrip1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.BaseItemRadius = 2;
            this.skinToolStrip1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip1.BaseItemSplitter = System.Drawing.Color.Transparent;
            this.skinToolStrip1.BindTabControl = null;
            this.skinToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.skinToolStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinToolStrip1.Fore = System.Drawing.Color.Black;
            this.skinToolStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.skinToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.skinToolStrip1.HoverFore = System.Drawing.Color.White;
            this.skinToolStrip1.ItemAnamorphosis = false;
            this.skinToolStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.ItemBorderShow = false;
            this.skinToolStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.ItemRadius = 3;
            this.skinToolStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.skinToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripButton4});
            this.skinToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.skinToolStrip1.Name = "skinToolStrip1";
            this.skinToolStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.skinToolStrip1.Size = new System.Drawing.Size(511, 25);
            this.skinToolStrip1.SkinAllColor = true;
            this.skinToolStrip1.TabIndex = 2;
            this.skinToolStrip1.Text = "skinToolStrip1";
            this.skinToolStrip1.TitleAnamorphosis = true;
            this.skinToolStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinToolStrip1.TitleRadius = 1;
            this.skinToolStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(42, 22);
            this.toolStripButton1.Text = "Clear";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.CheckOnClick = true;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(41, 22);
            this.toolStripButton3.Text = "Send";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.CheckOnClick = true;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(54, 22);
            this.toolStripButton4.Text = "Revicer";
            // 
            // skinTabControl3
            // 
            this.skinTabControl3.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl3.BackColor = System.Drawing.Color.Gray;
            this.skinTabControl3.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl3.Controls.Add(this.skinTabPage4);
            this.skinTabControl3.HeadBack = null;
            this.skinTabControl3.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl3.ItemSize = new System.Drawing.Size(70, 36);
            this.skinTabControl3.Location = new System.Drawing.Point(702, 33);
            this.skinTabControl3.Name = "skinTabControl3";
            this.skinTabControl3.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl3.PageArrowDown")));
            this.skinTabControl3.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl3.PageArrowHover")));
            this.skinTabControl3.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl3.PageCloseHover")));
            this.skinTabControl3.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl3.PageCloseNormal")));
            this.skinTabControl3.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl3.PageDown")));
            this.skinTabControl3.PageDownTxtColor = System.Drawing.SystemColors.ActiveBorder;
            this.skinTabControl3.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl3.PageHover")));
            this.skinTabControl3.PageHoverTxtColor = System.Drawing.SystemColors.ActiveBorder;
            this.skinTabControl3.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl3.PageNorml = null;
            this.skinTabControl3.PageNormlTxtColor = System.Drawing.SystemColors.ActiveBorder;
            this.skinTabControl3.SelectedIndex = 0;
            this.skinTabControl3.Size = new System.Drawing.Size(191, 172);
            this.skinTabControl3.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl3.TabIndex = 2;
            // 
            // skinTabPage4
            // 
            this.skinTabPage4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.skinTabPage4.Controls.Add(this.skinLabel5);
            this.skinTabPage4.Controls.Add(this.skinLabel4);
            this.skinTabPage4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.skinTabPage4.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage4.Name = "skinTabPage4";
            this.skinTabPage4.Size = new System.Drawing.Size(191, 136);
            this.skinTabPage4.TabIndex = 0;
            this.skinTabPage4.TabItemImage = null;
            this.skinTabPage4.Text = "账号";
            // 
            // skinLabel5
            // 
            this.skinLabel5.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.Transparent;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.skinLabel5.Location = new System.Drawing.Point(33, 34);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(100, 17);
            this.skinLabel5.TabIndex = 1;
            this.skinLabel5.Text = "在线时长:2:10:30";
            // 
            // skinLabel4
            // 
            this.skinLabel4.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.Transparent;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.skinLabel4.Location = new System.Drawing.Point(13, 8);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(56, 17);
            this.skinLabel4.TabIndex = 0;
            this.skinLabel4.Text = "登录信息";
            // 
            // skinTabControl4
            // 
            this.skinTabControl4.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.skinTabControl4.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl4.Controls.Add(this.skinTabPage5);
            this.skinTabControl4.HeadBack = null;
            this.skinTabControl4.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl4.ItemSize = new System.Drawing.Size(70, 36);
            this.skinTabControl4.Location = new System.Drawing.Point(702, 209);
            this.skinTabControl4.Name = "skinTabControl4";
            this.skinTabControl4.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl4.PageArrowDown")));
            this.skinTabControl4.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl4.PageArrowHover")));
            this.skinTabControl4.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl4.PageCloseHover")));
            this.skinTabControl4.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl4.PageCloseNormal")));
            this.skinTabControl4.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl4.PageDown")));
            this.skinTabControl4.PageDownTxtColor = System.Drawing.SystemColors.ActiveBorder;
            this.skinTabControl4.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl4.PageHover")));
            this.skinTabControl4.PageHoverTxtColor = System.Drawing.SystemColors.ActiveBorder;
            this.skinTabControl4.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl4.PageNorml = null;
            this.skinTabControl4.PageNormlTxtColor = System.Drawing.SystemColors.ActiveBorder;
            this.skinTabControl4.SelectedIndex = 0;
            this.skinTabControl4.Size = new System.Drawing.Size(191, 365);
            this.skinTabControl4.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl4.TabIndex = 3;
            // 
            // skinTabPage5
            // 
            this.skinTabPage5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.skinTabPage5.Controls.Add(this.skinButton1);
            this.skinTabPage5.Controls.Add(this.skinLabel7);
            this.skinTabPage5.Controls.Add(this.skinLabel6);
            this.skinTabPage5.Controls.Add(this.skinLabel3);
            this.skinTabPage5.Controls.Add(this.skinTextBox3);
            this.skinTabPage5.Controls.Add(this.skinTextBox2);
            this.skinTabPage5.Controls.Add(this.skinLabel2);
            this.skinTabPage5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage5.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage5.Name = "skinTabPage5";
            this.skinTabPage5.Size = new System.Drawing.Size(191, 329);
            this.skinTabPage5.TabIndex = 0;
            this.skinTabPage5.TabItemImage = null;
            this.skinTabPage5.Text = "参数";
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skinButton1.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.skinButton1.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton1.Location = new System.Drawing.Point(46, 290);
            this.skinButton1.MouseBack = null;
            this.skinButton1.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(87, 26);
            this.skinButton1.TabIndex = 7;
            this.skinButton1.Text = "发 送";
            this.skinButton1.UseVisualStyleBackColor = false;
            // 
            // skinLabel7
            // 
            this.skinLabel7.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.skinLabel7.Location = new System.Drawing.Point(135, 71);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(32, 17);
            this.skinLabel7.TabIndex = 6;
            this.skinLabel7.Text = "类型";
            // 
            // skinLabel6
            // 
            this.skinLabel6.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.skinLabel6.Location = new System.Drawing.Point(135, 13);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(32, 17);
            this.skinLabel6.TabIndex = 5;
            this.skinLabel6.Text = "类型";
            // 
            // skinLabel3
            // 
            this.skinLabel3.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.Transparent;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.skinLabel3.Location = new System.Drawing.Point(13, 13);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(39, 17);
            this.skinLabel3.TabIndex = 2;
            this.skinLabel3.Text = "参数1";
            // 
            // skinTextBox3
            // 
            this.skinTextBox3.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox3.DownBack = null;
            this.skinTextBox3.Icon = null;
            this.skinTextBox3.IconIsButton = false;
            this.skinTextBox3.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox3.IsPasswordChat = '\0';
            this.skinTextBox3.IsSystemPasswordChar = false;
            this.skinTextBox3.Lines = new string[0];
            this.skinTextBox3.Location = new System.Drawing.Point(27, 91);
            this.skinTextBox3.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox3.MaxLength = 32767;
            this.skinTextBox3.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox3.MouseBack = null;
            this.skinTextBox3.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox3.Multiline = false;
            this.skinTextBox3.Name = "skinTextBox3";
            this.skinTextBox3.NormlBack = null;
            this.skinTextBox3.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox3.ReadOnly = false;
            this.skinTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox3.Size = new System.Drawing.Size(144, 28);
            // 
            // 
            // 
            this.skinTextBox3.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox3.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox3.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox3.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox3.SkinTxt.Name = "BaseText";
            this.skinTextBox3.SkinTxt.Size = new System.Drawing.Size(134, 18);
            this.skinTextBox3.SkinTxt.TabIndex = 0;
            this.skinTextBox3.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox3.SkinTxt.WaterText = "";
            this.skinTextBox3.TabIndex = 3;
            this.skinTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox3.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox3.WaterText = "";
            this.skinTextBox3.WordWrap = true;
            // 
            // skinTextBox2
            // 
            this.skinTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox2.DownBack = null;
            this.skinTextBox2.Icon = null;
            this.skinTextBox2.IconIsButton = false;
            this.skinTextBox2.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox2.IsPasswordChat = '\0';
            this.skinTextBox2.IsSystemPasswordChar = false;
            this.skinTextBox2.Lines = new string[0];
            this.skinTextBox2.Location = new System.Drawing.Point(27, 35);
            this.skinTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox2.MaxLength = 32767;
            this.skinTextBox2.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox2.MouseBack = null;
            this.skinTextBox2.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox2.Multiline = false;
            this.skinTextBox2.Name = "skinTextBox2";
            this.skinTextBox2.NormlBack = null;
            this.skinTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox2.ReadOnly = false;
            this.skinTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox2.Size = new System.Drawing.Size(144, 28);
            // 
            // 
            // 
            this.skinTextBox2.SkinTxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.skinTextBox2.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox2.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox2.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox2.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox2.SkinTxt.Name = "BaseText";
            this.skinTextBox2.SkinTxt.Size = new System.Drawing.Size(134, 18);
            this.skinTextBox2.SkinTxt.TabIndex = 0;
            this.skinTextBox2.SkinTxt.WaterColor = System.Drawing.SystemColors.ActiveBorder;
            this.skinTextBox2.SkinTxt.WaterText = "";
            this.skinTextBox2.TabIndex = 1;
            this.skinTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox2.WaterColor = System.Drawing.SystemColors.ActiveBorder;
            this.skinTextBox2.WaterText = "";
            this.skinTextBox2.WordWrap = true;
            this.skinTextBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.skinTextBox2_Paint);
            // 
            // skinLabel2
            // 
            this.skinLabel2.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.Transparent;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.skinLabel2.Location = new System.Drawing.Point(13, 71);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(39, 17);
            this.skinLabel2.TabIndex = 0;
            this.skinLabel2.Text = "参数1";
            this.skinLabel2.Click += new System.EventHandler(this.skinLabel2_Click_1);
            // 
            // skinLabel1
            // 
            this.skinLabel1.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.skinLabel1.Location = new System.Drawing.Point(848, 577);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(45, 17);
            this.skinLabel1.TabIndex = 4;
            this.skinLabel1.Text = "v 1.0.0";
            this.skinLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skinLabel8
            // 
            this.skinLabel8.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.skinLabel8.Location = new System.Drawing.Point(7, 577);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(55, 17);
            this.skinLabel8.TabIndex = 5;
            this.skinLabel8.Text = "LiangZG";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = ((System.Drawing.Image)(resources.GetObject("$this.Back")));
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.CloseBoxSize = new System.Drawing.Size(27, 22);
            this.CloseDownBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseDownBack")));
            this.CloseMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseMouseBack")));
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.Controls.Add(this.skinLabel8);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinTabControl4);
            this.Controls.Add(this.skinTabControl3);
            this.Controls.Add(this.skinTabControl2);
            this.Controls.Add(this.ProtosTabCtrl);
            this.EffectBack = System.Drawing.SystemColors.ActiveBorder;
            this.EffectCaption = CCWin.TitleType.Title;
            this.EffectWidth = 1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaxDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxDownBack")));
            this.MaximizeBox = false;
            this.MaxMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxMouseBack")));
            this.MaxNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxNormlBack")));
            this.MaxSize = new System.Drawing.Size(27, 22);
            this.MiniDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniDownBack")));
            this.MiniMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniMouseBack")));
            this.MiniNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniNormlBack")));
            this.MiniSize = new System.Drawing.Size(26, 22);
            this.Name = "MainForm";
            this.RestoreDownBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreDownBack")));
            this.RestoreMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreMouseBack")));
            this.RestoreNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreNormlBack")));
            this.ShadowWidth = 1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "协议联调工具";
            this.TitleColor = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ProtosTabCtrl.ResumeLayout(false);
            this.allProtosTab.ResumeLayout(false);
            this.allProtosTab.PerformLayout();
            this.skinToolStrip2.ResumeLayout(false);
            this.skinToolStrip2.PerformLayout();
            this.skinTabControl2.ResumeLayout(false);
            this.skinTabPage3.ResumeLayout(false);
            this.skinToolStrip1.ResumeLayout(false);
            this.skinToolStrip1.PerformLayout();
            this.skinTabControl3.ResumeLayout(false);
            this.skinTabPage4.ResumeLayout(false);
            this.skinTabPage4.PerformLayout();
            this.skinTabControl4.ResumeLayout(false);
            this.skinTabPage5.ResumeLayout(false);
            this.skinTabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinTabControl ProtosTabCtrl;
        private CCWin.SkinControl.SkinTabPage allProtosTab;
        private CCWin.SkinControl.SkinTabPage myProtosTab;
        private CCWin.SkinControl.SkinTabControl skinTabControl2;
        private CCWin.SkinControl.SkinTabPage skinTabPage3;
        private CCWin.SkinControl.SkinTabControl skinTabControl3;
        private CCWin.SkinControl.SkinTabPage skinTabPage4;
        private CCWin.SkinControl.SkinTabControl skinTabControl4;
        private CCWin.SkinControl.SkinTabPage skinTabPage5;
        private CCWin.SkinControl.SkinToolStrip skinToolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTreeView protoTree;
        private CCWin.SkinControl.SkinToolStrip skinToolStrip2;
        private System.Windows.Forms.ToolStripButton btnReflush;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinTextBox skinTextBox3;
        private CCWin.SkinControl.SkinTextBox skinTextBox2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinTextBox skinTextBox1;
        private CCWin.SkinControl.ChatListBox chatListBox1;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinLabel skinLabel8;
    }
}

