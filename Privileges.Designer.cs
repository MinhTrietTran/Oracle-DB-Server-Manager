namespace UsersManagement
{
    partial class Privileges
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.exitBtn = new System.Windows.Forms.Button();
            this.uSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new UsersManagement.DataSet1();
            this.uSER_TableAdapter = new UsersManagement.DataSet1TableAdapters.USER_TableAdapter();
            this.TablePrivileges = new System.Windows.Forms.DataGridView();
            this.toolBarPanel = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.usersAndRolesBtn = new System.Windows.Forms.Button();
            this.privilegesBtn = new System.Windows.Forms.Button();
            this.systemUsersBtn = new System.Windows.Forms.Button();
            this.appName = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.ColumnPrivileges = new System.Windows.Forms.DataGridView();
            this.roleNameLabel = new System.Windows.Forms.Label();
            this.AddPrivileges = new System.Windows.Forms.Button();
            this.DeletePrivileges = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.AddRoleToUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablePrivileges)).BeginInit();
            this.toolBarPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnPrivileges)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn.Location = new System.Drawing.Point(923, 10);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(28, 28);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // uSERBindingSource
            // 
            this.uSERBindingSource.DataMember = "USER$";
            this.uSERBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSER_TableAdapter
            // 
            this.uSER_TableAdapter.ClearBeforeFill = true;
            // 
            // TablePrivileges
            // 
            this.TablePrivileges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablePrivileges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablePrivileges.Location = new System.Drawing.Point(10, 43);
            this.TablePrivileges.Margin = new System.Windows.Forms.Padding(2);
            this.TablePrivileges.Name = "TablePrivileges";
            this.TablePrivileges.RowHeadersWidth = 51;
            this.TablePrivileges.RowTemplate.Height = 24;
            this.TablePrivileges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablePrivileges.Size = new System.Drawing.Size(910, 121);
            this.TablePrivileges.TabIndex = 1;
            this.TablePrivileges.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablePrivileges_CellContentClick);
            // 
            // toolBarPanel
            // 
            this.toolBarPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.toolBarPanel.Controls.Add(this.logoutBtn);
            this.toolBarPanel.Controls.Add(this.usersAndRolesBtn);
            this.toolBarPanel.Controls.Add(this.privilegesBtn);
            this.toolBarPanel.Controls.Add(this.systemUsersBtn);
            this.toolBarPanel.Controls.Add(this.appName);
            this.toolBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBarPanel.Location = new System.Drawing.Point(0, 0);
            this.toolBarPanel.Margin = new System.Windows.Forms.Padding(2);
            this.toolBarPanel.Name = "toolBarPanel";
            this.toolBarPanel.Size = new System.Drawing.Size(960, 81);
            this.toolBarPanel.TabIndex = 2;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.LightBlue;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(573, 46);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(194, 37);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "Log out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            // 
            // usersAndRolesBtn
            // 
            this.usersAndRolesBtn.BackColor = System.Drawing.Color.LightBlue;
            this.usersAndRolesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAndRolesBtn.Location = new System.Drawing.Point(385, 46);
            this.usersAndRolesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.usersAndRolesBtn.Name = "usersAndRolesBtn";
            this.usersAndRolesBtn.Size = new System.Drawing.Size(194, 37);
            this.usersAndRolesBtn.TabIndex = 3;
            this.usersAndRolesBtn.Text = "Users and Roles";
            this.usersAndRolesBtn.UseVisualStyleBackColor = false;
            this.usersAndRolesBtn.Click += new System.EventHandler(this.usersAndRolesBtn_Click);
            // 
            // privilegesBtn
            // 
            this.privilegesBtn.BackColor = System.Drawing.Color.White;
            this.privilegesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privilegesBtn.Location = new System.Drawing.Point(193, 46);
            this.privilegesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.privilegesBtn.Name = "privilegesBtn";
            this.privilegesBtn.Size = new System.Drawing.Size(194, 37);
            this.privilegesBtn.TabIndex = 2;
            this.privilegesBtn.Text = "Privileges ";
            this.privilegesBtn.UseVisualStyleBackColor = false;
            // 
            // systemUsersBtn
            // 
            this.systemUsersBtn.BackColor = System.Drawing.Color.LightBlue;
            this.systemUsersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemUsersBtn.ForeColor = System.Drawing.Color.Black;
            this.systemUsersBtn.Location = new System.Drawing.Point(0, 46);
            this.systemUsersBtn.Margin = new System.Windows.Forms.Padding(2);
            this.systemUsersBtn.Name = "systemUsersBtn";
            this.systemUsersBtn.Size = new System.Drawing.Size(194, 37);
            this.systemUsersBtn.TabIndex = 1;
            this.systemUsersBtn.Text = "System Users";
            this.systemUsersBtn.UseVisualStyleBackColor = false;
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.Location = new System.Drawing.Point(8, 6);
            this.appName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(231, 17);
            this.appName.TabIndex = 0;
            this.appName.Text = "Oracle DB Server Manager 1.0";
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.leftPanel.Controls.Add(this.userNameLabel);
            this.leftPanel.Controls.Add(this.TablePrivileges);
            this.leftPanel.Location = new System.Drawing.Point(11, 179);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(938, 186);
            this.leftPanel.TabIndex = 3;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.userNameLabel.Location = new System.Drawing.Point(8, 9);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(49, 18);
            this.userNameLabel.TabIndex = 4;
            this.userNameLabel.Text = "Table";
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.rightPanel.Controls.Add(this.ColumnPrivileges);
            this.rightPanel.Controls.Add(this.roleNameLabel);
            this.rightPanel.Location = new System.Drawing.Point(11, 388);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(938, 186);
            this.rightPanel.TabIndex = 4;
            // 
            // ColumnPrivileges
            // 
            this.ColumnPrivileges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ColumnPrivileges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ColumnPrivileges.Location = new System.Drawing.Point(16, 43);
            this.ColumnPrivileges.Margin = new System.Windows.Forms.Padding(2);
            this.ColumnPrivileges.Name = "ColumnPrivileges";
            this.ColumnPrivileges.RowHeadersWidth = 51;
            this.ColumnPrivileges.RowTemplate.Height = 24;
            this.ColumnPrivileges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ColumnPrivileges.Size = new System.Drawing.Size(904, 121);
            this.ColumnPrivileges.TabIndex = 9;
            // 
            // roleNameLabel
            // 
            this.roleNameLabel.AutoSize = true;
            this.roleNameLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.roleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleNameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.roleNameLabel.Location = new System.Drawing.Point(13, 9);
            this.roleNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roleNameLabel.Name = "roleNameLabel";
            this.roleNameLabel.Size = new System.Drawing.Size(66, 18);
            this.roleNameLabel.TabIndex = 9;
            this.roleNameLabel.Text = "Column";
            // 
            // AddPrivileges
            // 
            this.AddPrivileges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPrivileges.Location = new System.Drawing.Point(27, 106);
            this.AddPrivileges.Name = "AddPrivileges";
            this.AddPrivileges.Size = new System.Drawing.Size(117, 45);
            this.AddPrivileges.TabIndex = 5;
            this.AddPrivileges.Text = "Cấp quyền cho user/role";
            this.AddPrivileges.UseVisualStyleBackColor = true;
            this.AddPrivileges.Click += new System.EventHandler(this.AddPrivileges_click);
            // 
            // DeletePrivileges
            // 
            this.DeletePrivileges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePrivileges.Location = new System.Drawing.Point(193, 106);
            this.DeletePrivileges.Name = "DeletePrivileges";
            this.DeletePrivileges.Size = new System.Drawing.Size(121, 45);
            this.DeletePrivileges.TabIndex = 6;
            this.DeletePrivileges.Text = "Hủy quyền của role/user";
            this.DeletePrivileges.UseVisualStyleBackColor = true;
            this.DeletePrivileges.Click += new System.EventHandler(this.DeletePrivileges_Click);
            // 
            // Refresh
            // 
            this.Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Refresh.Location = new System.Drawing.Point(856, 106);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 7;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // AddRoleToUser
            // 
            this.AddRoleToUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRoleToUser.Location = new System.Drawing.Point(367, 106);
            this.AddRoleToUser.Name = "AddRoleToUser";
            this.AddRoleToUser.Size = new System.Drawing.Size(117, 45);
            this.AddRoleToUser.TabIndex = 8;
            this.AddRoleToUser.Text = "Cấp Role cho User";
            this.AddRoleToUser.UseVisualStyleBackColor = true;
            this.AddRoleToUser.Click += new System.EventHandler(this.GrantRoleToUser_Click);
            // 
            // Privileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.AddRoleToUser);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.DeletePrivileges);
            this.Controls.Add(this.AddPrivileges);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.toolBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Privileges";
            this.Text = "Privileges";
            this.Load += new System.EventHandler(this.Privileges_load);
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablePrivileges)).EndInit();
            this.toolBarPanel.ResumeLayout(false);
            this.toolBarPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnPrivileges)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource uSERBindingSource;
        private DataSet1TableAdapters.USER_TableAdapter uSER_TableAdapter;
        private System.Windows.Forms.DataGridView TablePrivileges;
        private System.Windows.Forms.Panel toolBarPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.Button privilegesBtn;
        private System.Windows.Forms.Button systemUsersBtn;
        private System.Windows.Forms.Button usersAndRolesBtn;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label roleNameLabel;
        private System.Windows.Forms.DataGridView ColumnPrivileges;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button AddPrivileges;
        private System.Windows.Forms.Button DeletePrivileges;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button AddRoleToUser;
    }
}