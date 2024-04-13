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

namespace UsersManagement
{
    public partial class GrantRoleUser : Form
    {
        public GrantRoleUser()
        {
            InitializeComponent();
        }

        private void Grant_button_Click(object sender, EventArgs e)
        {
            string Role = ROLE_TextBox.Text;
            string User = USER_TextBox.Text;
            if (Role == "" || User == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin trước khi cấp quyền");
                return;
            }

            using (OracleConnection oracleConnection = Connection.GetOracleConnection())
            {
                oracleConnection.Open();

                string query1 = $"SELECT CASE WHEN EXISTS(SELECT 1 FROM DBA_ROLES WHERE ROLE = '{Role}') THEN 'ROLE' ELSE 'UNKNOWN' END AS OBJECT_TYPE FROM DUAL";
                string query2 = $"SELECT CASE WHEN EXISTS(SELECT 1 FROM ALL_USERS WHERE USERNAME = '{User}') THEN 'USER' ELSE 'UNKNOWN' END AS OBJECT_TYPE FROM DUAL";

                using (OracleCommand command1 = new OracleCommand(query1, oracleConnection))
                {
                    using (OracleDataReader reader = command1.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string objectType = reader["OBJECT_TYPE"].ToString();
                            if (objectType == "UNKNOWN")
                            {
                                MessageBox.Show("Role không tồn tại, vui lòng nhập lại!");
                                oracleConnection.Close();
                                return;
                            }
                        }
                    }
                }

                using (OracleCommand command2 = new OracleCommand(query2, oracleConnection))
                {
                    using (OracleDataReader reader = command2.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string objectType = reader["OBJECT_TYPE"].ToString();
                            if (objectType == "UNKNOWN")
                            {
                                MessageBox.Show("User không tồn tại, vui lòng nhập lại!");
                                oracleConnection.Close();
                                return;
                            }
                        }
                    }
                }

                string query3 = $"GRANT {Role} TO {User}";
                using(OracleCommand command3 = new OracleCommand(query3, oracleConnection))
                {
                    command3.ExecuteNonQuery();
                    MessageBox.Show("Thêm role cho user thành công!");
                    oracleConnection.Close();
                    this.Hide();
                }
            }
        }

        private void ExitGrant_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
