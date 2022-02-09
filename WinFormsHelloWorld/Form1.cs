using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserDaoLibrary;

namespace WinFormsHelloWorld
{

    public partial class Form1 : Form
    {
        //member variables
        UserDao dao = new UserDao();
        private List<User> users;

        public Form1()
        {
            InitializeComponent();

            users = dao.GetUsers();

            foreach(User u in users)
            {
                lstUsers.Items.Add(u);
            }
 
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            User selectedUser = (User)lstUsers.SelectedItem;

            txtName.Text = selectedUser.Name;
            txtId.Text = $"{ selectedUser.Id }";
            txtEmail.Text = selectedUser.Email;
            chkActive.Checked = selectedUser.Active;

        }
    }
}
