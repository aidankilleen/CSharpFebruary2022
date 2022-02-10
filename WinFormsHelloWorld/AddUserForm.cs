using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UserDaoLibrary;

namespace WinFormsHelloWorld
{
    public partial class AddUserForm : Form
    {
        public User User { get; set; }

        public AddUserForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            User.Name = txtName.Text;
            User.Email = txtEmail.Text;
            User.Active = chkActive.Checked;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
