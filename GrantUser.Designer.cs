namespace UsersManagement
{
    partial class GrantUser
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
            this.grantBtn = new System.Windows.Forms.Button();
            this.selectPrivilegeComboBox = new System.Windows.Forms.ComboBox();
            this.selectPrivilegeLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.grantRoleForUserLabel = new System.Windows.Forms.Label();
            this.exitBtn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grantBtn
            // 
            this.grantBtn.BackColor = System.Drawing.Color.White;
            this.grantBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grantBtn.ForeColor = System.Drawing.Color.Black;
            this.grantBtn.Location = new System.Drawing.Point(226, 407);
            this.grantBtn.Name = "grantBtn";
            this.grantBtn.Size = new System.Drawing.Size(102, 37);
            this.grantBtn.TabIndex = 22;
            this.grantBtn.Text = "Grant";
            this.grantBtn.UseVisualStyleBackColor = false;
            // 
            // selectPrivilegeComboBox
            // 
            this.selectPrivilegeComboBox.FormattingEnabled = true;
            this.selectPrivilegeComboBox.Items.AddRange(new object[] {
            "SELECT",
            "UPDATE",
            "INSERT",
            "DELETE"});
            this.selectPrivilegeComboBox.Location = new System.Drawing.Point(226, 211);
            this.selectPrivilegeComboBox.Name = "selectPrivilegeComboBox";
            this.selectPrivilegeComboBox.Size = new System.Drawing.Size(239, 24);
            this.selectPrivilegeComboBox.TabIndex = 21;
            // 
            // selectPrivilegeLabel
            // 
            this.selectPrivilegeLabel.AutoSize = true;
            this.selectPrivilegeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPrivilegeLabel.Location = new System.Drawing.Point(61, 211);
            this.selectPrivilegeLabel.Name = "selectPrivilegeLabel";
            this.selectPrivilegeLabel.Size = new System.Drawing.Size(140, 29);
            this.selectPrivilegeLabel.TabIndex = 20;
            this.selectPrivilegeLabel.Text = "Select role";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(226, 142);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(239, 22);
            this.usernameTextBox.TabIndex = 19;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(61, 142);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(132, 29);
            this.userNameLabel.TabIndex = 18;
            this.userNameLabel.Text = "Username";
            // 
            // grantRoleForUserLabel
            // 
            this.grantRoleForUserLabel.AutoSize = true;
            this.grantRoleForUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grantRoleForUserLabel.ForeColor = System.Drawing.Color.Green;
            this.grantRoleForUserLabel.Location = new System.Drawing.Point(12, 9);
            this.grantRoleForUserLabel.Name = "grantRoleForUserLabel";
            this.grantRoleForUserLabel.Size = new System.Drawing.Size(281, 29);
            this.grantRoleForUserLabel.TabIndex = 17;
            this.grantRoleForUserLabel.Text = "Grant privilege for user";
            // 
            // exitBtn1
            // 
            this.exitBtn1.BackColor = System.Drawing.Color.Red;
            this.exitBtn1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn1.Location = new System.Drawing.Point(591, 7);
            this.exitBtn1.Name = "exitBtn1";
            this.exitBtn1.Size = new System.Drawing.Size(37, 35);
            this.exitBtn1.TabIndex = 16;
            this.exitBtn1.Text = "X";
            this.exitBtn1.UseVisualStyleBackColor = false;
            // 
            // GrantUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.grantBtn);
            this.Controls.Add(this.selectPrivilegeComboBox);
            this.Controls.Add(this.selectPrivilegeLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.grantRoleForUserLabel);
            this.Controls.Add(this.exitBtn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GrantUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrantUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button grantBtn;
        private System.Windows.Forms.ComboBox selectPrivilegeComboBox;
        private System.Windows.Forms.Label selectPrivilegeLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label grantRoleForUserLabel;
        private System.Windows.Forms.Button exitBtn1;
    }
}