using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CommonFormsLibrary
{
    public partial class LoginForm : Form
    {
        public string Username { get; set; }
        public bool LoggedIn { get; set; } = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // TODO - do this properly!!!!
            if (txtName.Text.Equals("Aidan") && 
                txtPassword.Text.Equals("password123"))
            {
                LoggedIn = true;
                DialogResult = DialogResult.OK;
            } else
            {
                DialogResult = DialogResult.Cancel;
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoggedIn = false;
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
