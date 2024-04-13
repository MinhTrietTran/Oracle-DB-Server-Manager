using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace UsersManagement
{
    public partial class Privileges : Form
    {
        
        public Privileges()
        {
            InitializeComponent();
        }
        
        Modify modify = new Modify();

        // Display data
        public void Privileges_load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1._USER_' table. You can move, or remove it, as needed.
            //this.uSER_TableAdapter.Fill(this.dataSet1._USER_);

            try
            {
                TablePrivileges.DataSource = modify.Table("SELECT* FROM ALL_TAB_PRIVS WHERE GRANTEE IN (SELECT USERNAME FROM ALL_USERS) ");
                ColumnPrivileges.DataSource = modify.Table("SELECT  GRANTEE, PRIVILEGE, TABLE_NAME, COLUMN_NAME FROM ALL_COL_PRIVS WHERE GRANTEE IN (SELECT USERNAME FROM ALL_USERS)");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }


        }
        // Edit role
        private void editRoleBtn_Click(object sender, EventArgs e)
        {
            if (TablePrivileges.SelectedRows.Count > 0)
            {
                string roleName = ColumnPrivileges.SelectedRows[0].Cells[0].Value.ToString();
                EditRole targetForm = new EditRole();
                targetForm.RoleName = roleName;
                targetForm.Show();
            }
            else
            {
                MessageBox.Show("Please choose the role you want to edit !");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void privilegesBtn_Click(object sender, EventArgs e)
        {
            /*this.Close(); // Đóng Form1
            Privileges newForm = new Privileges();
            newForm.Show();*/
        }

        private void AddPrivileges_click(object sender, EventArgs e)
        {
            AddPrivilegesMem newForm = new AddPrivilegesMem();
            newForm.Show();
        }

        private void DeletePrivileges_Click(object sender, EventArgs e)
        {
            AddPrivilegesMem newForm = new AddPrivilegesMem();
            newForm.Show();
        }

        private void TablePrivileges_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Privileges_load(sender, e);
        }

        private void usersAndRolesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersAndRoles newForm = new UsersAndRoles();
            newForm.Show();
        }

        private void GrantRoleToUser_Click(object sender, EventArgs e)
        {
            GrantRoleUser newFrom = new GrantRoleUser();
            newFrom.Show();
        }
    }
}
