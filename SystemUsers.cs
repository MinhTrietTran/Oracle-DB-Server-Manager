﻿using System;
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
        private string UserName;
        public SystemUsers()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void SystemUsers_Load(object sender, EventArgs e)
        {
            try
            {
                usersDGV.DataSource = modify.Table("SELECT U.USERNAME, " +
                                                            "COALESCE(DRP.GRANTED_ROLE, 'N/A') AS GRANTED_ROLE, "+
                                                            "COALESCE(DRP.ADMIN_OPTION, 'N/A') AS ADMIN_OPTION, " +
                                                            "COALESCE(DRP.DEFAULT_ROLE, 'N/A') AS DEFAULT_ROLE, " +
                                                            "COALESCE(DRP.INHERITED, 'N/A') AS INHERITED " +
                                                    "FROM  DBA_USERS U " +
                                                    "LEFT JOIN DBA_ROLE_PRIVS DRP ON  U.USERNAME = DRP.GRANTEE");
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
                // ERROR
                string query = "SELECT U.USERNAME, " +
                                                            "COALESCE(DRP.GRANTED_ROLE, 'N/A') AS GRANTED_ROLE, " +
                                                            "COALESCE(DRP.ADMIN_OPTION, 'N/A') AS ADMIN_OPTION, " +
                                                            "COALESCE(DRP.DEFAULT_ROLE, 'N/A') AS DEFAULT_ROLE, " +
                                                            "COALESCE(DRP.INHERITED, 'N/A') AS INHERITED " +
                                                    "FROM  DBA_USERS U " +
                                                    "LEFT JOIN DBA_ROLE_PRIVS DRP ON  U.USERNAME = DRP.GRANTEE " +
                                                    "WHERE UPPER(U.USERNAME) LIKE '%" + userName + "%' ";
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

        // Refresh
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            SystemUsers_Load(sender, e);
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        // Grant
        private void grantBtn_Click(object sender, EventArgs e)
        {
            if (usersDGV.SelectedRows.Count > 0)
            {
                GrantRoleForUser target = new GrantRoleForUser();
                target.UsernameSelected =  UserName;
                target.Show();
            }
            else
            {
                MessageBox.Show("Please choose the user you want to grant role !");
            }
        }

        // Get username by cell click
        private void usersDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (usersDGV.SelectedRows.Count > 0)
            {
                UserName = usersDGV.SelectedRows[0].Cells[0].Value.ToString();
            }
             
        }

        private void revokeBtn_Click(object sender, EventArgs e)
        {
            if (usersDGV.SelectedRows.Count > 0)
            {
                RevokeRoleFromUser target = new RevokeRoleFromUser();
                target.UsernameSelected = UserName;
                target.Show();
            }
            else
            {
                MessageBox.Show("Please choose the user you want to revoke role !");
            }
        }

        private void privilegesBtn_Click(object sender, EventArgs e)
        {
            Privileges obj = new Privileges();
            obj.Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
