using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ObjectAccess;

namespace ProjectUserControl
{
    public partial class NewUserControl : UserControl
    {
        public NewUserControl()
        {
            InitializeComponent();
        }
        ObjectAccess.ConnectDB dbObject = new ConnectDB();

        public delegate void EventHandler(Object sender, EventArgs e);
        public event EventHandler NewUserSuccess;
        public event EventHandler Login;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if ((txtFirstName.Text != "")
               && (txtLastName.Text != "") && (txtUsername.Text != "")
               && (txtPwd.Text != "") && (txtMobile.Text != "")
               && (txtCity.Text.Trim() != "")

                )
            {
                ErrorLabel.Visible = false;

                int result = dbObject.AddNewUser(txtFirstName.Text, txtLastName.Text, txtMobile.Text,
                        txtUsername.Text, txtPwd.Text,
                       cboSecurityQuestion.SelectedItem.ToString(), txtSecurityAnswer.Text, txtCity.Text);
                if (result == 1)
                {
                    MessageBox.Show("User Added Successfully !!!");
                    NewUserSuccess(this, new System.EventArgs());
                }
                else
                {
                    MessageBox.Show("Issue in the connectivity");
                }
            }
        }

        private void NewUserControl_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login(this, new System.EventArgs());

        }
    }
}
