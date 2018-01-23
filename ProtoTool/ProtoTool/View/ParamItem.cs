using System.Drawing;
using System.Windows.Forms;
using CCWin.SkinControl;

namespace ProtoTool.View
{
    /// <summary>
    /// 请求参数选项
    /// </summary>
    public class ParamItem
    {
        private CCWin.SkinControl.SkinLabel paramName;
        private CCWin.SkinControl.SkinLabel paramsType;
        private CCWin.SkinControl.SkinTextBox paramInputText;
        private CCWin.SkinControl.SkinPanel paramsItem;

        public ParamItem(SkinFlowLayoutPanel parentPanel)
        {
            this.initComponent(parentPanel);
        }


        public SkinLabel ParamName
        {
            get { return paramName; }
        }

        public SkinLabel ParamsType
        {
            get { return paramsType; }
        }

        public SkinTextBox ParamInputText
        {
            get { return paramInputText; }
        }

        private void initComponent(SkinFlowLayoutPanel parentPanel)
        {
            this.paramsItem = new SkinPanel();
            this.paramsItem.SuspendLayout();

            // 
            // paramsType
            // 
            this.paramsType = new SkinLabel();
            this.paramsType.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.paramsType.AutoSize = false;
            this.paramsType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.paramsType.BackColor = System.Drawing.Color.Transparent;
            this.paramsType.BorderColor = System.Drawing.Color.White;
            this.paramsType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.paramsType.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.paramsType.Location = new System.Drawing.Point(105, 2);
            this.paramsType.Name = "paramsType";
            this.paramsType.Size = new System.Drawing.Size(56, 17);
            this.paramsType.TabIndex = 5;
            this.paramsType.Anchor = AnchorStyles.Right;
            this.paramsType.TextAlign = ContentAlignment.MiddleRight;
            this.paramsType.Text = "类型";
            // 
            // skinLabel3
            // 
            this.paramName = new SkinLabel();
            this.paramName.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.paramName.AutoSize = true;
            this.paramName.BackColor = System.Drawing.Color.Transparent;
            this.paramName.BorderColor = System.Drawing.Color.Transparent;
            this.paramName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.paramName.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.paramName.Location = new System.Drawing.Point(3, 2);
            this.paramName.Name = "skinLabel3";
            this.paramName.Size = new System.Drawing.Size(39, 17);
            this.paramName.TabIndex = 2;
            this.paramName.Text = "参数1";

            this.paramInputText = new SkinTextBox();
            this.paramInputText.BackColor = System.Drawing.Color.Transparent;
            this.paramInputText.DownBack = null;
            this.paramInputText.Icon = null;
            this.paramInputText.IconIsButton = false;
            this.paramInputText.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.paramInputText.IsPasswordChat = '\0';
            this.paramInputText.IsSystemPasswordChar = false;
            this.paramInputText.Lines = new string[0];
            this.paramInputText.Location = new System.Drawing.Point(16, 22);
            this.paramInputText.Margin = new System.Windows.Forms.Padding(0);
            this.paramInputText.MaxLength = 32767;
            this.paramInputText.MinimumSize = new System.Drawing.Size(28, 28);
            this.paramInputText.MouseBack = null;
            this.paramInputText.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.paramInputText.Multiline = false;
            this.paramInputText.Name = "paramInputText";
            this.paramInputText.NormlBack = null;
            this.paramInputText.Padding = new System.Windows.Forms.Padding(5);
            this.paramInputText.ReadOnly = false;
            this.paramInputText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.paramInputText.Size = new System.Drawing.Size(142, 28);
            // 
            // 
            // 
            this.paramInputText.SkinTxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.paramInputText.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paramInputText.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paramInputText.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.paramInputText.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.paramInputText.SkinTxt.Name = "BaseText";
            this.paramInputText.SkinTxt.Size = new System.Drawing.Size(132, 18);
            this.paramInputText.SkinTxt.TabIndex = 0;
            this.paramInputText.SkinTxt.WaterColor = System.Drawing.SystemColors.ActiveBorder;
            this.paramInputText.SkinTxt.WaterText = "";
            this.paramInputText.TabIndex = 1;
            this.paramInputText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.paramInputText.WaterColor = System.Drawing.SystemColors.ActiveBorder;
            this.paramInputText.WaterText = "";
            this.paramInputText.WordWrap = true;

            this.paramsItem.BackColor = System.Drawing.Color.Transparent;
            this.paramsItem.Controls.Add(this.paramName);
            this.paramsItem.Controls.Add(this.paramsType);
            this.paramsItem.Controls.Add(this.paramInputText);
            this.paramsItem.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.paramsItem.DownBack = null;
            this.paramsItem.Location = new System.Drawing.Point(3, 3);
            this.paramsItem.Margin = new Padding(1);
            this.paramsItem.MouseBack = null;
            this.paramsItem.Name = "paramsItem";
            this.paramsItem.NormlBack = null;
            this.paramsItem.Size = new System.Drawing.Size(168, 55);
            this.paramsItem.TabIndex = 10;

            parentPanel.Controls.Add(this.paramsItem);
        }
                    
    }
}