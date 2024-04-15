using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsersManagement
{
    public partial class Privileges : Form
    {
        Modify modify = new Modify();
        public Privileges()
        {
            InitializeComponent();
        }

        private void exitBtn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void systemUsersBtn_Click(object sender, EventArgs e)
        {
            SystemUsers obj = new SystemUsers();
            obj.Show();
            this.Hide();
        }

        private void usersAndRolesBtn_Click(object sender, EventArgs e)
        {
            UsersAndRoles obj = new UsersAndRoles();
            obj.Show();
            this.Hide();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Privileges_Load(sender, e);

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }




        private void Privileges_Load(object sender, EventArgs e)
        {
            toTabCheckBox1.Checked = true;
            totableCheckBox2.Checked = true; 
            UsersPrivsLoadByTab(sender, e);
            RolesPrivsLoadByTab(sender, e);
        }
        private void UsersPrivsLoadByTab(object sender, EventArgs e)
        {
            try
            {
                usersPrivsDGV.DataSource = modify.Table("SELECT U.USERNAME, "+
                                                        "COALESCE(P.TABLE_NAME, 'N/A') AS TABLE_NAME, "+
                                                        "COALESCE(P.GRANTOR, 'N/A') AS GRANTOR, "+
                                                        "COALESCE(P.PRIVILEGE, 'N/A') AS PRIVILEGE, "+
                                                        "COALESCE(P.GRANTABLE, 'N/A') AS GRANTABLE " +
                                                        "FROM DBA_USERS U LEFT JOIN DBA_TAB_PRIVS P ON U.USERNAME = P.GRANTEE");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading users privileges to tables: " + ex.Message);
            }
        }
        private void UserPrivsLoadByCol(object sender, EventArgs e)
        {
            try
            {
                usersPrivsDGV.DataSource = modify.Table("SELECT U.USERNAME, " +
                                                        "COALESCE(P.TABLE_NAME, 'N/A') AS TABLE_NAME, " +
                                                        "COALESCE(P.COLUMN_NAME, 'N/A') AS COLUMN_NAME, " +
                                                        "COALESCE(P.GRANTOR, 'N/A') AS GRANTOR, " +
                                                        "COALESCE(P.PRIVILEGE, 'N/A') AS PRIVILEGE, " +
                                                        "COALESCE(P.GRANTABLE, 'N/A') AS GRANTABLE " +
                                                        "FROM DBA_USERS U LEFT JOIN DBA_COL_PRIVS P ON U.USERNAME = P.GRANTEE");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading users privileges to columns: " + ex.Message);
            }
        }
        private void RolesPrivsLoadByTab(object sender, EventArgs e)
        {
            try
            {
                rolesPrivsDGV.DataSource = modify.Table("SELECT R.ROLE, " +
                                                        "COALESCE(P.TABLE_NAME, 'N/A') AS TABLE_NAME, " +
                                                        "COALESCE(P.GRANTOR, 'N/A') AS GRANTOR, " +
                                                        "COALESCE(P.PRIVILEGE, 'N/A') AS PRIVILEGE, " +
                                                        "COALESCE(P.GRANTABLE, 'N/A') AS GRANTABLE " +
                                                        "FROM DBA_ROLES R LEFT JOIN DBA_TAB_PRIVS P ON R.ROLE = P.GRANTEE");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading roles privileges to tables: " + ex.Message);
            }
        }
        private void RolesPRivsLoadByCol(object sender, EventArgs e)
        {
            try
            {
                rolesPrivsDGV.DataSource = modify.Table("SELECT R.ROLE, " +
                                                        "COALESCE(P.TABLE_NAME, 'N/A') AS TABLE_NAME, " +
                                                        "COALESCE(P.COLUMN_NAME, 'N/A') AS COLUMN_NAME, " +
                                                        "COALESCE(P.GRANTOR, 'N/A') AS GRANTOR, " +
                                                        "COALESCE(P.PRIVILEGE, 'N/A') AS PRIVILEGE, " +
                                                        "COALESCE(P.GRANTABLE, 'N/A') AS GRANTABLE " +
                                                        "FROM DBA_ROLES R LEFT JOIN DBA_COL_PRIVS P ON R.ROLE = P.GRANTEE");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading roles privileges to columns: " + ex.Message);
            }
        }

        private void toTabCheckBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (toTabCheckBox1.Checked == true)
            {
                toColCheckBox1.Checked = false;
                UsersPrivsLoadByTab(sender, e);
            }
            else
            {
                toColCheckBox1.Checked = true;
                UserPrivsLoadByCol (sender, e);
            }
            
        }

        private void toColCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (toColCheckBox1.Checked == true)
            {
                toTabCheckBox1.Checked = false;
                UserPrivsLoadByCol(sender, e);
            }
            else
            { 
                toTabCheckBox1.Checked = true;
                UsersPrivsLoadByTab(sender, e);
            }
        }

        private void totableCheckBox2_CheckStateChanged(object sender, EventArgs e)
        {
            if (totableCheckBox2.Checked == true)
            {
                toColCheckBox2.Checked = false;
                RolesPrivsLoadByTab(sender, e);
            }
            else
            {
                toColCheckBox2.Checked = true;
                RolesPRivsLoadByCol(sender, e);

            }
        }

        private void toColCheckBox2_CheckStateChanged(object sender, EventArgs e)
        {
            if (toColCheckBox2.Checked == true)
            {
                totableCheckBox2.Checked = false;
                RolesPRivsLoadByCol(sender, e);
            }
            else
            {
                totableCheckBox2.Checked = true;
                RolesPrivsLoadByTab(sender, e);
            }
        }
        // Search by users
        private void usersPrivsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (usersPrivsDGV.SelectedRows.Count > 0)
            {
                userNameTextBox.Text = usersPrivsDGV.SelectedRows[0].Cells[0].Value.ToString();
            }
        }
        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text.Trim();
            if (userName == "" && toTabCheckBox1.Checked == true)
            {
                UsersPrivsLoadByTab(sender, e);

            }
            else if (userName == "" && toTabCheckBox1.Checked == false)
            {
                UserPrivsLoadByCol(sender, e);
            }
            else if (toTabCheckBox1.Checked == true)
            {

                string query = "SELECT U.USERNAME, " +
                                "COALESCE(P.TABLE_NAME, 'N/A') AS TABLE_NAME, " +
                                "COALESCE(P.GRANTOR, 'N/A') AS GRANTOR, " +
                                "COALESCE(P.PRIVILEGE, 'N/A') AS PRIVILEGE, " +
                                "COALESCE(P.GRANTABLE, 'N/A') AS GRANTABLE " +
                                "FROM DBA_USERS U LEFT JOIN DBA_TAB_PRIVS P ON U.USERNAME = P.GRANTEE " +
                                "WHERE U." +
                                "USERNAME LIKE '%" + userName + "%'";
                usersPrivsDGV.DataSource = modify.Table(query);
            }
            else
            {
                string query = "SELECT U.USERNAME, " +
                                "COALESCE(P.TABLE_NAME, 'N/A') AS TABLE_NAME, " +
                                "COALESCE(P.COLUMN_NAME, 'N/A') AS COLUMN_NAME, " +
                                "COALESCE(P.GRANTOR, 'N/A') AS GRANTOR, " +
                                "COALESCE(P.PRIVILEGE, 'N/A') AS PRIVILEGE, " +
                                "COALESCE(P.GRANTABLE, 'N/A') AS GRANTABLE " +
                                "FROM DBA_USERS U LEFT JOIN DBA_COL_PRIVS P ON U.USERNAME = P.GRANTEE " +
                                "WHERE U.USERNAME LIKE '%" + userName + "%'";
                usersPrivsDGV.DataSource = modify.Table(query);
            }
        }

        // Search by roles
        private void rolesPrivsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rolesPrivsDGV.SelectedRows.Count > 0)
            {
                roleNameTextBox.Text = rolesPrivsDGV.SelectedRows[0].Cells[0].Value.ToString();
            }
        }
        private void roleNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string roleName = roleNameTextBox.Text.Trim();
            if (roleName == "" && totableCheckBox2.Checked == true)
            {
                RolesPrivsLoadByTab(sender, e);

            }
            else if (roleName == "" && totableCheckBox2.Checked == false)
            {
                RolesPRivsLoadByCol(sender, e);
            }
            else if (toTabCheckBox1.Checked == true)
            {

                string query = "SELECT R.ROLE, " +
                                "COALESCE(P.TABLE_NAME, 'N/A') AS TABLE_NAME, " +
                                "COALESCE(P.GRANTOR, 'N/A') AS GRANTOR, " +
                                "COALESCE(P.PRIVILEGE, 'N/A') AS PRIVILEGE, " +
                                "COALESCE(P.GRANTABLE, 'N/A') AS GRANTABLE " +
                                "FROM DBA_ROLES R LEFT JOIN DBA_TAB_PRIVS P ON R.ROLE = P.GRANTEE "+
                                "WHERE R.ROLE LIKE '%" + roleName + "%'";
                rolesPrivsDGV.DataSource = modify.Table(query);
            }
            else
            {
                string query = "SELECT R.ROLE, " +
                                "COALESCE(P.TABLE_NAME, 'N/A') AS TABLE_NAME, " +
                                "COALESCE(P.COLUMN_NAME, 'N/A') AS COLUMN_NAME, " +
                                "COALESCE(P.GRANTOR, 'N/A') AS GRANTOR, " +
                                "COALESCE(P.PRIVILEGE, 'N/A') AS PRIVILEGE, " +
                                "COALESCE(P.GRANTABLE, 'N/A') AS GRANTABLE " +
                                "FROM DBA_ROLES R LEFT JOIN DBA_COL_PRIVS P ON R.ROLE = P.GRANTEE " +
                                "WHERE R.ROLE LIKE '%" + roleName + "%'";
                rolesPrivsDGV.DataSource = modify.Table(query);
            }
        }

        // Uppercase the search
        private void userNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void roleNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }



        
    }
}
