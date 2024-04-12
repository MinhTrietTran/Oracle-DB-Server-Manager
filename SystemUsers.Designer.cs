namespace UsersManagement
{
    partial class SystemUsers
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.toolBarPanel = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.usersAndRolesBtn = new System.Windows.Forms.Button();
            this.privilegesBtn = new System.Windows.Forms.Button();
            this.systemUsersBtn = new System.Windows.Forms.Button();
            this.appName = new System.Windows.Forms.Label();
            this.usersDGV = new System.Windows.Forms.DataGridView();
            this.searchBtn = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.exitBtn1 = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.toolBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn.Location = new System.Drawing.Point(1213, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(37, 35);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.mainPanel.Controls.Add(this.searchTextBox);
            this.mainPanel.Controls.Add(this.searchBtn);
            this.mainPanel.Controls.Add(this.usersDGV);
            this.mainPanel.Location = new System.Drawing.Point(14, 118);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1254, 590);
            this.mainPanel.TabIndex = 6;
            // 
            // toolBarPanel
            // 
            this.toolBarPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.toolBarPanel.Controls.Add(this.exitBtn1);
            this.toolBarPanel.Controls.Add(this.logoutBtn);
            this.toolBarPanel.Controls.Add(this.usersAndRolesBtn);
            this.toolBarPanel.Controls.Add(this.privilegesBtn);
            this.toolBarPanel.Controls.Add(this.systemUsersBtn);
            this.toolBarPanel.Controls.Add(this.appName);
            this.toolBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBarPanel.Location = new System.Drawing.Point(0, 0);
            this.toolBarPanel.Name = "toolBarPanel";
            this.toolBarPanel.Size = new System.Drawing.Size(1280, 100);
            this.toolBarPanel.TabIndex = 5;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.LightBlue;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(769, 56);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(259, 45);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "Log out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            // 
            // usersAndRolesBtn
            // 
            this.usersAndRolesBtn.BackColor = System.Drawing.Color.LightBlue;
            this.usersAndRolesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAndRolesBtn.Location = new System.Drawing.Point(513, 56);
            this.usersAndRolesBtn.Name = "usersAndRolesBtn";
            this.usersAndRolesBtn.Size = new System.Drawing.Size(259, 45);
            this.usersAndRolesBtn.TabIndex = 3;
            this.usersAndRolesBtn.Text = "Users and Roles";
            this.usersAndRolesBtn.UseVisualStyleBackColor = false;
            this.usersAndRolesBtn.Click += new System.EventHandler(this.usersAndRolesBtn_Click);
            // 
            // privilegesBtn
            // 
            this.privilegesBtn.BackColor = System.Drawing.Color.LightBlue;
            this.privilegesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privilegesBtn.Location = new System.Drawing.Point(257, 56);
            this.privilegesBtn.Name = "privilegesBtn";
            this.privilegesBtn.Size = new System.Drawing.Size(259, 45);
            this.privilegesBtn.TabIndex = 2;
            this.privilegesBtn.Text = "Privileges ";
            this.privilegesBtn.UseVisualStyleBackColor = false;
            // 
            // systemUsersBtn
            // 
            this.systemUsersBtn.BackColor = System.Drawing.Color.White;
            this.systemUsersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemUsersBtn.ForeColor = System.Drawing.Color.Black;
            this.systemUsersBtn.Location = new System.Drawing.Point(0, 56);
            this.systemUsersBtn.Name = "systemUsersBtn";
            this.systemUsersBtn.Size = new System.Drawing.Size(259, 45);
            this.systemUsersBtn.TabIndex = 1;
            this.systemUsersBtn.Text = "System Users";
            this.systemUsersBtn.UseVisualStyleBackColor = false;
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.Location = new System.Drawing.Point(10, 7);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(268, 20);
            this.appName.TabIndex = 0;
            this.appName.Text = "Oracle DB Server Manager 1.0";
            // 
            // usersDGV
            // 
            this.usersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDGV.Location = new System.Drawing.Point(16, 59);
            this.usersDGV.Name = "usersDGV";
            this.usersDGV.RowHeadersWidth = 51;
            this.usersDGV.RowTemplate.Height = 24;
            this.usersDGV.Size = new System.Drawing.Size(1220, 517);
            this.usersDGV.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.AutoSize = true;
            this.searchBtn.BackColor = System.Drawing.Color.White;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(1153, 10);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(55, 39);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "🔎";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            this.searchBtn.MouseEnter += new System.EventHandler(this.searchBtn_MouseEnter);
            this.searchBtn.MouseLeave += new System.EventHandler(this.searchBtn_MouseLeave);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(924, 10);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(229, 39);
            this.searchTextBox.TabIndex = 2;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // exitBtn1
            // 
            this.exitBtn1.BackColor = System.Drawing.Color.Red;
            this.exitBtn1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn1.Location = new System.Drawing.Point(1231, 12);
            this.exitBtn1.Name = "exitBtn1";
            this.exitBtn1.Size = new System.Drawing.Size(37, 35);
            this.exitBtn1.TabIndex = 5;
            this.exitBtn1.Text = "X";
            this.exitBtn1.UseVisualStyleBackColor = false;
            this.exitBtn1.Click += new System.EventHandler(this.exitBtn1_Click);
            // 
            // SystemUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.toolBarPanel);
            this.Controls.Add(this.exitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SystemUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemUsers";
            this.Load += new System.EventHandler(this.SystemUsers_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.toolBarPanel.ResumeLayout(false);
            this.toolBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel toolBarPanel;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button usersAndRolesBtn;
        private System.Windows.Forms.Button privilegesBtn;
        private System.Windows.Forms.Button systemUsersBtn;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.DataGridView usersDGV;
        private System.Windows.Forms.Label searchBtn;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button exitBtn1;
    }
}