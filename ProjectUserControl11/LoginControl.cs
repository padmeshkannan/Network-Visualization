using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ObjectAccess;
using Library;

namespace ProjectUserControl
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }
        ObjectAccess.ConnectDB dbObject = new ConnectDB();

        public delegate void EventHandler(Object sender, EventArgs e);
        public event EventHandler LoginSuccess;

        public event EventHandler NewUserForm;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if ((txtUserName.Text != "") && (txtPwd.Text != ""))
            {
                int usrID = dbObject.VerifyCredentials(txtUserName.Text, txtPwd.Text);
                if (usrID != 0)
                {
                    //PropertyClass.UserId = usrID;
                    //PropertyClass.UserName = txtUserName.Text;
                    LoginSuccess(this, new System.EventArgs());
                }
                else
                    ErrorLabel.Visible = true;
            }
            else
            {
                ErrorLabel.Visible = true;
               // LoginFailed(this, new System.EventArgs());
            }
                
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

       

        private void LoginControl_Load(object sender, EventArgs e)
        {
            
            ErrorLabel.Visible = false;   
        }

       

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            
            NewUserForm(this, new System.EventArgs());
        }

        private void btnNewUser_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
