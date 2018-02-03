namespace ProtoTool
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.btnLogin = new CCWin.SkinControl.SkinButton();
            this.accentBgText = new CCWin.SkinControl.SkinTextBox();
            this.baseAccentText = new CCWin.SkinControl.SkinAlphaWaterTextBox();
            this.passwordTxt = new CCWin.SkinControl.SkinTextBox();
            this.skinAlphaWaterTextBox1 = new CCWin.SkinControl.SkinAlphaWaterTextBox();
            this.ipTxt = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.portTxt = new CCWin.SkinControl.SkinTextBox();
            this.accentBgText.SuspendLayout();
            this.passwordTxt.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(51, 88);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(52, 21);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "账  号";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(52, 134);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(52, 21);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = "密  码";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(52, 181);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(58, 21);
            this.skinLabel3.TabIndex = 2;
            this.skinLabel3.Text = "服务器";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnLogin.DownBack = null;
            this.btnLogin.Location = new System.Drawing.Point(119, 236);
            this.btnLogin.MouseBack = null;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormlBack = null;
            this.btnLogin.Size = new System.Drawing.Size(228, 34);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登      录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.onLoginClick);
            // 
            // accentBgText
            // 
            this.accentBgText.BackColor = System.Drawing.Color.Transparent;
            this.accentBgText.Controls.Add(this.baseAccentText);
            this.accentBgText.DownBack = null;
            this.accentBgText.Icon = null;
            this.accentBgText.IconIsButton = false;
            this.accentBgText.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.accentBgText.IsPasswordChat = '\0';
            this.accentBgText.IsSystemPasswordChar = false;
            this.accentBgText.Lines = new string[] {
        "skinTextBox1"};
            this.accentBgText.Location = new System.Drawing.Point(119, 88);
            this.accentBgText.Margin = new System.Windows.Forms.Padding(0);
            this.accentBgText.MaxLength = 32767;
            this.accentBgText.MinimumSize = new System.Drawing.Size(28, 28);
            this.accentBgText.MouseBack = null;
            this.accentBgText.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.accentBgText.Multiline = false;
            this.accentBgText.Name = "accentBgText";
            this.accentBgText.NormlBack = null;
            this.accentBgText.Padding = new System.Windows.Forms.Padding(5);
            this.accentBgText.ReadOnly = false;
            this.accentBgText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.accentBgText.Size = new System.Drawing.Size(228, 28);
            // 
            // 
            // 
            this.accentBgText.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accentBgText.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accentBgText.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.accentBgText.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.accentBgText.SkinTxt.Name = "BaseText";
            this.accentBgText.SkinTxt.Size = new System.Drawing.Size(218, 18);
            this.accentBgText.SkinTxt.TabIndex = 0;
            this.accentBgText.SkinTxt.Text = "skinTextBox1";
            this.accentBgText.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.accentBgText.SkinTxt.WaterText = "baseAccentText";
            this.accentBgText.TabIndex = 4;
            this.accentBgText.Text = "skinTextBox1";
            this.accentBgText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.accentBgText.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.accentBgText.WaterText = "baseAccentText";
            this.accentBgText.WordWrap = true;
            // 
            // baseAccentText
            // 
            this.baseAccentText.BackAlpha = 10;
            this.baseAccentText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.baseAccentText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.baseAccentText.Location = new System.Drawing.Point(4, 7);
            this.baseAccentText.Name = "baseAccentText";
            this.baseAccentText.Size = new System.Drawing.Size(185, 14);
            this.baseAccentText.TabIndex = 1;
            this.baseAccentText.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.baseAccentText.WaterFont = new System.Drawing.Font("微软雅黑", 8.5F);
            this.baseAccentText.WaterText = "请输入账号";
            this.baseAccentText.TextChanged += new System.EventHandler(this.baseAccentText_TextChanged);
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.Color.Transparent;
            this.passwordTxt.Controls.Add(this.skinAlphaWaterTextBox1);
            this.passwordTxt.DownBack = null;
            this.passwordTxt.Icon = null;
            this.passwordTxt.IconIsButton = false;
            this.passwordTxt.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.passwordTxt.IsPasswordChat = '\0';
            this.passwordTxt.IsSystemPasswordChar = false;
            this.passwordTxt.Lines = new string[] {
        "请输入密码"};
            this.passwordTxt.Location = new System.Drawing.Point(119, 131);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(0);
            this.passwordTxt.MaxLength = 32767;
            this.passwordTxt.MinimumSize = new System.Drawing.Size(28, 28);
            this.passwordTxt.MouseBack = null;
            this.passwordTxt.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.passwordTxt.Multiline = false;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.NormlBack = null;
            this.passwordTxt.Padding = new System.Windows.Forms.Padding(5);
            this.passwordTxt.ReadOnly = false;
            this.passwordTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTxt.Size = new System.Drawing.Size(228, 28);
            // 
            // 
            // 
            this.passwordTxt.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxt.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordTxt.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.passwordTxt.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.passwordTxt.SkinTxt.Name = "BaseText";
            this.passwordTxt.SkinTxt.Size = new System.Drawing.Size(218, 18);
            this.passwordTxt.SkinTxt.TabIndex = 0;
            this.passwordTxt.SkinTxt.Text = "请输入密码";
            this.passwordTxt.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.passwordTxt.SkinTxt.WaterText = "";
            this.passwordTxt.TabIndex = 5;
            this.passwordTxt.Text = "请输入密码";
            this.passwordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.passwordTxt.WaterText = "";
            this.passwordTxt.WordWrap = true;
            // 
            // skinAlphaWaterTextBox1
            // 
            this.skinAlphaWaterTextBox1.BackAlpha = 10;
            this.skinAlphaWaterTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skinAlphaWaterTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinAlphaWaterTextBox1.Location = new System.Drawing.Point(6, 8);
            this.skinAlphaWaterTextBox1.Name = "skinAlphaWaterTextBox1";
            this.skinAlphaWaterTextBox1.Size = new System.Drawing.Size(212, 14);
            this.skinAlphaWaterTextBox1.TabIndex = 1;
            this.skinAlphaWaterTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinAlphaWaterTextBox1.WaterFont = new System.Drawing.Font("微软雅黑", 8.5F);
            this.skinAlphaWaterTextBox1.WaterText = "请输入密码";
            // 
            // ipTxt
            // 
            this.ipTxt.BackColor = System.Drawing.Color.Transparent;
            this.ipTxt.DownBack = null;
            this.ipTxt.Icon = null;
            this.ipTxt.IconIsButton = false;
            this.ipTxt.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.ipTxt.IsPasswordChat = '\0';
            this.ipTxt.IsSystemPasswordChar = false;
            this.ipTxt.Lines = new string[] {
        "192.168.1.168"};
            this.ipTxt.Location = new System.Drawing.Point(119, 178);
            this.ipTxt.Margin = new System.Windows.Forms.Padding(0);
            this.ipTxt.MaxLength = 32767;
            this.ipTxt.MinimumSize = new System.Drawing.Size(28, 28);
            this.ipTxt.MouseBack = null;
            this.ipTxt.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.ipTxt.Multiline = false;
            this.ipTxt.Name = "ipTxt";
            this.ipTxt.NormlBack = null;
            this.ipTxt.Padding = new System.Windows.Forms.Padding(5);
            this.ipTxt.ReadOnly = false;
            this.ipTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ipTxt.Size = new System.Drawing.Size(119, 28);
            // 
            // 
            // 
            this.ipTxt.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipTxt.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipTxt.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.ipTxt.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.ipTxt.SkinTxt.Name = "BaseText";
            this.ipTxt.SkinTxt.Size = new System.Drawing.Size(109, 18);
            this.ipTxt.SkinTxt.TabIndex = 0;
            this.ipTxt.SkinTxt.Text = "192.168.1.168";
            this.ipTxt.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ipTxt.SkinTxt.WaterText = "";
            this.ipTxt.TabIndex = 6;
            this.ipTxt.Text = "192.168.1.168";
            this.ipTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ipTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ipTxt.WaterText = "";
            this.ipTxt.WordWrap = true;
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(243, 181);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(42, 21);
            this.skinLabel4.TabIndex = 7;
            this.skinLabel4.Text = "端口";
            // 
            // portTxt
            // 
            this.portTxt.BackColor = System.Drawing.Color.Transparent;
            this.portTxt.DownBack = null;
            this.portTxt.Icon = null;
            this.portTxt.IconIsButton = false;
            this.portTxt.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.portTxt.IsPasswordChat = '\0';
            this.portTxt.IsSystemPasswordChar = false;
            this.portTxt.Lines = new string[] {
        "8080"};
            this.portTxt.Location = new System.Drawing.Point(283, 178);
            this.portTxt.Margin = new System.Windows.Forms.Padding(0);
            this.portTxt.MaxLength = 32767;
            this.portTxt.MinimumSize = new System.Drawing.Size(28, 28);
            this.portTxt.MouseBack = null;
            this.portTxt.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.portTxt.Multiline = false;
            this.portTxt.Name = "portTxt";
            this.portTxt.NormlBack = null;
            this.portTxt.Padding = new System.Windows.Forms.Padding(5);
            this.portTxt.ReadOnly = false;
            this.portTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.portTxt.Size = new System.Drawing.Size(64, 28);
            // 
            // 
            // 
            this.portTxt.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.portTxt.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.portTxt.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.portTxt.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.portTxt.SkinTxt.Name = "BaseText";
            this.portTxt.SkinTxt.Size = new System.Drawing.Size(54, 18);
            this.portTxt.SkinTxt.TabIndex = 0;
            this.portTxt.SkinTxt.Text = "8080";
            this.portTxt.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.portTxt.SkinTxt.WaterText = "";
            this.portTxt.TabIndex = 8;
            this.portTxt.Text = "8080";
            this.portTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.portTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.portTxt.WaterText = "";
            this.portTxt.WordWrap = true;
            this.portTxt.Paint += new System.Windows.Forms.PaintEventHandler(this.skinTextBox3_Paint);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(415, 299);
            this.CloseBoxSize = new System.Drawing.Size(27, 22);
            this.CloseDownBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseDownBack")));
            this.CloseMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseMouseBack")));
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.Controls.Add(this.portTxt);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.ipTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.accentBgText);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.MaximizeBox = false;
            this.MiniDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniDownBack")));
            this.MiniMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniMouseBack")));
            this.MiniNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniNormlBack")));
            this.MiniSize = new System.Drawing.Size(27, 22);
            this.Name = "LoginForm";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.accentBgText.ResumeLayout(false);
            this.accentBgText.PerformLayout();
            this.passwordTxt.ResumeLayout(false);
            this.passwordTxt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinButton btnLogin;
        private CCWin.SkinControl.SkinTextBox accentBgText;
        private CCWin.SkinControl.SkinAlphaWaterTextBox baseAccentText;
        private CCWin.SkinControl.SkinTextBox passwordTxt;
        private CCWin.SkinControl.SkinTextBox ipTxt;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinTextBox portTxt;
        private CCWin.SkinControl.SkinAlphaWaterTextBox skinAlphaWaterTextBox1;
    }
}