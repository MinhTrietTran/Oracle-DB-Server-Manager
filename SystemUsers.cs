using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsersManagement
{
    public partial class SystemUsers : Form
    {
        public SystemUsers()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void SystemUsers_Load(object sender, EventArgs e)
        {
            try
            {
                usersDGV.DataSource = modify.Table("SELECT * FROM all_users ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // Filter users
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string userName = searchTextBox.Text.Trim();
            if (userName == "")
            {
                SystemUsers_Load(sender, e);

            }
            else
            {
                string query = "SELECT * FROM all_users WHERE USERNAME LIKE '%" + userName + "%'";
                usersDGV.DataSource = modify.Table(query);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string userName = searchTextBox.Text.Trim();
            if (userName == "")
            {
                SystemUsers_Load(sender, e);

            }
        }

        // Exit
        private void exitBtn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Make color
        private void searchBtn_MouseEnter(object sender, EventArgs e)
        {
            searchBtn.BackColor = Color.Aqua;
        }

        private void searchBtn_MouseLeave(object sender, EventArgs e)
        {
            searchBtn.BackColor = Color.White;
        }

        // Flow
        private void usersAndRolesBtn_Click(object sender, EventArgs e)
        {
            UsersAndRoles obj = new UsersAndRoles();
            this.Hide();
            obj.Show();
        }
    }
}
