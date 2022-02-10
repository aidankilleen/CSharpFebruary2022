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

            if (selectedUser != null)
            {
                txtName.Text = selectedUser.Name;
                txtId.Text = $"{ selectedUser.Id }";
                txtEmail.Text = selectedUser.Email;
                chkActive.Checked = selectedUser.Active;


                if (btnEdit.Enabled == false)
                {
                    // get out of editing mode
                    ConfigureControls(false);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            User selectedUser = (User)lstUsers.SelectedItem;

            if (selectedUser != null)
            {
                DialogResult result = MessageBox.Show(this, "Are you sure?",
                                                $"Delete {selectedUser.Name}",
                                                MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    dao.DeleteUser(selectedUser.Id);

                    // remove user from the list
                    lstUsers.Items.Remove(selectedUser);
                }
            }
        }

        private void ConfigureControls(bool editing)
        {
            txtName.ReadOnly = !editing;
            txtEmail.ReadOnly = !editing;
            chkActive.Enabled = editing;
            btnSave.Enabled = editing;
            btnCancel.Enabled = editing;
            btnEdit.Enabled = !editing;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            User selectedUser = (User)lstUsers.SelectedItem;

            if (selectedUser != null)
            {
                ConfigureControls(true);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User selectedUser = (User)lstUsers.SelectedItem;

            if (selectedUser != null)
            {
                string updatedName = txtName.Text;
                string updatedEmail = txtEmail.Text;
                bool updatedActive = chkActive.Checked;
                int id = int.Parse(txtId.Text);

                User updatedUser = new User(id, updatedName, updatedEmail, updatedActive);

                dao.UpdateUser(updatedUser);

                ConfigureControls(false);
                int index = lstUsers.SelectedIndex;
                lstUsers.Items[index] = updatedUser;

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            User selectedUser = (User)lstUsers.SelectedItem;

            if (selectedUser != null)
            {
                txtName.Text = selectedUser.Name;
                txtEmail.Text = selectedUser.Email;
                chkActive.Checked = selectedUser.Active;

                ConfigureControls(false);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUserForm frmAddUser = new AddUserForm();
            frmAddUser.User = new User();

            DialogResult result = frmAddUser.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                // write the new user object to the database
                User addedUser = dao.AddUser(frmAddUser.User);
                lstUsers.Items.Add(addedUser);
            }
        }
    }
}
