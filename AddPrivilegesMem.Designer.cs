namespace UsersManagement
{
    partial class AddPrivilegesMem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameRoleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ColumnListCheckBox = new System.Windows.Forms.CheckedListBox();
            this.PrivilegesCheckBox = new System.Windows.Forms.ComboBox();
            this.TableCheckBox = new System.Windows.Forms.ComboBox();
            this.WithGrantOption = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GrantPrivileges = new System.Windows.Forms.Button();
            this.OBJECT_TYPE = new System.Windows.Forms.Label();
            this.CheckRoleUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẤP QUYỀN CHO ROLE/USER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username/Role";
            // 
            // UsernameRoleTextBox
            // 
            this.UsernameRoleTextBox.Location = new System.Drawing.Point(123, 69);
            this.UsernameRoleTextBox.Name = "UsernameRoleTextBox";
            this.UsernameRoleTextBox.Size = new System.Drawing.Size(121, 20);
            this.UsernameRoleTextBox.TabIndex = 2;
            this.UsernameRoleTextBox.TextChanged += new System.EventHandler(this.UsernameRole_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kết quả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quyền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bảng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(312, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Thuộc tính";
            // 
            // ColumnListCheckBox
            // 
            this.ColumnListCheckBox.Enabled = false;
            this.ColumnListCheckBox.FormattingEnabled = true;
            this.ColumnListCheckBox.Location = new System.Drawing.Point(305, 102);
            this.ColumnListCheckBox.Name = "ColumnListCheckBox";
            this.ColumnListCheckBox.Size = new System.Drawing.Size(120, 154);
            this.ColumnListCheckBox.TabIndex = 7;
            this.ColumnListCheckBox.SelectedIndexChanged += new System.EventHandler(this.ColumnListCheckBox_SelectedIndexChanged);
            // 
            // PrivilegesCheckBox
            // 
            this.PrivilegesCheckBox.Enabled = false;
            this.PrivilegesCheckBox.FormattingEnabled = true;
            this.PrivilegesCheckBox.Items.AddRange(new object[] {
            "INSERT",
            "DELETE",
            "UPDATE",
            "SELECT"});
            this.PrivilegesCheckBox.Location = new System.Drawing.Point(123, 181);
            this.PrivilegesCheckBox.Name = "PrivilegesCheckBox";
            this.PrivilegesCheckBox.Size = new System.Drawing.Size(121, 21);
            this.PrivilegesCheckBox.TabIndex = 8;
            this.PrivilegesCheckBox.SelectedIndexChanged += new System.EventHandler(this.PrivilegesCheckBox_SelectedIndexChanged);
            // 
            // TableCheckBox
            // 
            this.TableCheckBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TableCheckBox.Enabled = false;
            this.TableCheckBox.FormattingEnabled = true;
            this.TableCheckBox.Items.AddRange(new object[] {
            "BH_KHACHHANG",
            "BH_CUAHANG",
            "BH_SANPHAM",
            "BH_CT_DONHANG",
            "BH_NHANVIEN"});
            this.TableCheckBox.Location = new System.Drawing.Point(123, 241);
            this.TableCheckBox.Name = "TableCheckBox";
            this.TableCheckBox.Size = new System.Drawing.Size(121, 21);
            this.TableCheckBox.TabIndex = 9;
            this.TableCheckBox.SelectedIndexChanged += new System.EventHandler(this.TableCheckBox_SelectedIndexChanged);
            // 
            // WithGrantOption
            // 
            this.WithGrantOption.AutoSize = true;
            this.WithGrantOption.Enabled = false;
            this.WithGrantOption.Location = new System.Drawing.Point(123, 280);
            this.WithGrantOption.Name = "WithGrantOption";
            this.WithGrantOption.Size = new System.Drawing.Size(140, 17);
            this.WithGrantOption.TabIndex = 10;
            this.WithGrantOption.Text = "WITH GRANT OPTION";
            this.WithGrantOption.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CloseAddPrivMem_Click);
            // 
            // GrantPrivileges
            // 
            this.GrantPrivileges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrantPrivileges.Location = new System.Drawing.Point(123, 315);
            this.GrantPrivileges.Name = "GrantPrivileges";
            this.GrantPrivileges.Size = new System.Drawing.Size(88, 23);
            this.GrantPrivileges.TabIndex = 12;
            this.GrantPrivileges.Text = "Cấp quyền";
            this.GrantPrivileges.UseVisualStyleBackColor = true;
            this.GrantPrivileges.Click += new System.EventHandler(this.GrantPrivileges_Click);
            // 
            // OBJECT_TYPE
            // 
            this.OBJECT_TYPE.AutoSize = true;
            this.OBJECT_TYPE.Location = new System.Drawing.Point(123, 128);
            this.OBJECT_TYPE.Name = "OBJECT_TYPE";
            this.OBJECT_TYPE.Size = new System.Drawing.Size(0, 13);
            this.OBJECT_TYPE.TabIndex = 13;
            // 
            // CheckRoleUser
            // 
            this.CheckRoleUser.Location = new System.Drawing.Point(169, 102);
            this.CheckRoleUser.Name = "CheckRoleUser";
            this.CheckRoleUser.Size = new System.Drawing.Size(75, 23);
            this.CheckRoleUser.TabIndex = 14;
            this.CheckRoleUser.Text = "Kiểm tra";
            this.CheckRoleUser.UseVisualStyleBackColor = true;
            this.CheckRoleUser.Click += new System.EventHandler(this.CheckRoleUser_Click);
            // 
            // AddPrivilegesMem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 366);
            this.ControlBox = false;
            this.Controls.Add(this.CheckRoleUser);
            this.Controls.Add(this.OBJECT_TYPE);
            this.Controls.Add(this.GrantPrivileges);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WithGrantOption);
            this.Controls.Add(this.TableCheckBox);
            this.Controls.Add(this.PrivilegesCheckBox);
            this.Controls.Add(this.ColumnListCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsernameRoleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPrivilegesMem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameRoleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox ColumnListCheckBox;
        private System.Windows.Forms.ComboBox PrivilegesCheckBox;
        private System.Windows.Forms.ComboBox TableCheckBox;
        private System.Windows.Forms.CheckBox WithGrantOption;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GrantPrivileges;
        private System.Windows.Forms.Label OBJECT_TYPE;
        private System.Windows.Forms.Button CheckRoleUser;
    }
}
