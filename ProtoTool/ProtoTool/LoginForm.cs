using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
using LuaFramework;

namespace ProtoTool
{
    public partial class LoginForm : CCSkinMain
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void skinTextBox3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void baseAccentText_TextChanged(object sender, EventArgs e)
        {

        }

        private void onLoginClick(object sender, EventArgs e)
        {
            try
            {
                string ipAddress = this.ipTxt.Text;
                int port = Convert.ToInt32(this.portTxt.Text);

                string account = baseAccentText.Text;
                string password = passwordTxt.Text;


                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
