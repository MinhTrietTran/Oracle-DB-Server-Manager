using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
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
    public partial class AddPrivilegesMem : Form
    {
        public AddPrivilegesMem()
        {
            InitializeComponent();
        }

        private void UsernameRole_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void GrantPrivileges_Click(object sender, EventArgs e)
        {   
            using (OracleConnection oracleConnection = Connection.GetOracleConnection())
            {
                oracleConnection.Open();

                string strsql = "";
                string query = "";
                string list_column = "";
                string Privilege = PrivilegesCheckBox.Text;
                string grantee = UsernameRoleTextBox.Text;
                string table = TableCheckBox.Text;
                if (Privilege == "" || grantee == "" || table == "")
                {
                    MessageBox.Show("Chưa đủ thông tin để cấp quyền!");
                    return;
                }
                if (Privilege == "INSERT" || Privilege == "DELETE")
                {
                    query = $"GRANT {Privilege} ON {table} TO {grantee}";
                }
                else if (Privilege == "UPDATE" || Privilege == "SELECT")
                {
                    
                    for (int i = 0; i < ColumnListCheckBox.Items.Count; i++)
                    {
                        if (ColumnListCheckBox.GetItemChecked(i))
                        {
                            if (list_column == "")
                                list_column += ColumnListCheckBox.Items[i].ToString();
                            else
                                list_column += "," + ColumnListCheckBox.Items[i].ToString();
                        }
                    }
                    if (Privilege == "UPDATE")
                        query = $"GRANT {Privilege} ({list_column}) ON {table} TO {grantee}";
                    else
                    {
                        string view_name = $"UV_{table}_{grantee}";
                        strsql = $"CREATE OR REPLACE VIEW {view_name} " +
                                 $"AS SELECT {list_column} FROM {table}";
                        query = $"GRANT SELECT ON {view_name} to {grantee}";
                        using (OracleCommand command = new OracleCommand(strsql, oracleConnection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
                   
                if (WithGrantOption.Checked)
                {
                    query += " WITH GRANT OPTION";
                }

                using (OracleCommand command = new OracleCommand(query, oracleConnection))
                {    
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Thêm quyền thành công!");
                        }
                        else
                            MessageBox.Show("Thêm quyền thất bại!");
                    }
                }
                oracleConnection.Close();
                this.Hide();
            }
        }

        private void TableCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColumnListCheckBox.Items.Clear();
            if (PrivilegesCheckBox.Text == "UPDATE" || PrivilegesCheckBox.Text == "SELECT"){
                string query = $"SELECT COLUMN_NAME FROM ALL_TAB_COLUMNS WHERE TABLE_NAME = '{TableCheckBox.Text}'";
                using (OracleConnection oracleConnection = Connection.GetOracleConnection())
                {
                    oracleConnection.Open();
                    using (OracleCommand command = new OracleCommand(query, oracleConnection))
                    {
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string columnName = reader["COLUMN_NAME"].ToString();

                                // Assuming you have a CheckBoxList control named "checkboxList" on your form
                                ColumnListCheckBox.Items.Add(columnName);
                            }
                        }
                    }
                    oracleConnection.Close();
                }
            }
        }

        private void CheckRoleUser_Click(object sender, EventArgs e)
        {
            string objectType = "";
            string query = "";
            using (OracleConnection oracleConnection = Connection.GetOracleConnection())
            {
                oracleConnection.Open();
                if (UsernameRoleTextBox.Text == "")
                {
                    MessageBox.Show("Please complete all information");
                }
                else
                {
                    string data = UsernameRoleTextBox.Text;
                    query = $"SELECT CASE WHEN EXISTS (SELECT 1 FROM ALL_USERS WHERE USERNAME = '{data}') THEN 'USER' WHEN EXISTS (SELECT 1 FROM DBA_ROLES WHERE ROLE = '{data}') THEN 'ROLE' ELSE 'UNKNOWN' END AS OBJECT_TYPE FROM DUAL";
                    using (OracleCommand command = new OracleCommand(query, oracleConnection))
                    {
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                objectType = reader["OBJECT_TYPE"].ToString();
                                OBJECT_TYPE.Text = $"Là {objectType}";
                            }
                        }
                    }

                }

                if (objectType == "UNKNOWN")
                {
                    MessageBox.Show("Không tìm thấy user hay role, vui lòng nhập lại và kiểm tra!");
                    OBJECT_TYPE.Text = "";
                    PrivilegesCheckBox.Enabled = false;
                    WithGrantOption.Enabled = false;
                    oracleConnection.Close();
                    return;
                }
                else if (objectType == "ROLE" || objectType == "USER")
                {
                    PrivilegesCheckBox.Enabled = true;
                    WithGrantOption.Enabled = true;
                }
                oracleConnection.Close();
            }
        }

        private void CloseAddPrivMem_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void PrivilegesCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PrivilegesCheckBox.Text != "")
            {
                TableCheckBox.Enabled = true;
            }
            if (PrivilegesCheckBox.Text == "INSERT" || PrivilegesCheckBox.Text == "DELETE")
            {
                ColumnListCheckBox.Enabled = false;
            }
            else
            { ColumnListCheckBox.Enabled = true; }
        }

        private void ColumnListCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
