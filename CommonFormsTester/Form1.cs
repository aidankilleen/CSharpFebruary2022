using CommonFormsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonFormsTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();

            DialogResult res = frm.ShowDialog(this);

            if (res == DialogResult.OK)
            {
                MessageBox.Show("logged in");
            } else
            {
                MessageBox.Show("login failed");
            }

        }
    }
}
