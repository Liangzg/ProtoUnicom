using System;
using System.Reflection;
using CCWin.SkinControl;

namespace ProtoTool.View
{
    public class ParamView
    {

        private MainForm mainForm;

        private Type curProtoType;

        public ParamView(MainForm main)
        {
            this.mainForm = main;
        }

        /// <summary>
        /// 刷新参数面板
        /// </summary>
        /// <param name="protoType"></param>
        public void ReflushParamsView(Type protoType)
        {
            if (protoType == null) return;

            curProtoType = protoType;

            PropertyInfo[] properties = protoType.GetProperties();

            SkinFlowLayoutPanel parentPanel = this.mainForm.ParamFlowPanel;
            parentPanel.Controls.Clear();

            
            foreach (PropertyInfo propertyInfo in properties)
            {
                ParamItem item = new ParamItem(parentPanel);

                if (!propertyInfo.PropertyType.Name.StartsWith("Nullable"))
                {
                    item.ParamName.Text = propertyInfo.Name +  " *";
                    item.ParamsType.Text = propertyInfo.PropertyType.Name;
                }
                else
                {
                    item.ParamName.Text = propertyInfo.Name;

                    string fullProperty = propertyInfo.PropertyType.FullName;
                    int index = fullProperty.IndexOf("[[");
                    int lastIndex = fullProperty.IndexOf(",");
                    fullProperty = fullProperty.Substring(index + 1 , lastIndex - index - 1);
                    string propertyTypeName = fullProperty.Substring(fullProperty.IndexOf(".") + 1);
                    item.ParamsType.Text = propertyTypeName;
                }

            }
            parentPanel.ResumeLayout(false);
        }

        /// <summary>
        /// 实例化Proto请求数据结构
        /// </summary>
        /// <returns></returns>
        public byte[] InstanceProtoClass()
        {

            return null;
        }
    }
}