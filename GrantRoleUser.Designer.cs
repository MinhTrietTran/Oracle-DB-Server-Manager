namespace UsersManagement
{
    partial class GrantRoleUser
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
            this.Grant_button = new System.Windows.Forms.Button();
            this.Role_label = new System.Windows.Forms.Label();
            this.User_label = new System.Windows.Forms.Label();
            this.ROLE_TextBox = new System.Windows.Forms.TextBox();
            this.USER_TextBox = new System.Windows.Forms.TextBox();
            this.ExitGrant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Grant_button
            // 
            this.Grant_button.BackColor = System.Drawing.SystemColors.Control;
            this.Grant_button.Location = new System.Drawing.Point(138, 175);
            this.Grant_button.Name = "Grant_button";
            this.Grant_button.Size = new System.Drawing.Size(75, 23);
            this.Grant_button.TabIndex = 0;
            this.Grant_button.Text = "Cấp quyền";
            this.Grant_button.UseVisualStyleBackColor = false;
            this.Grant_button.Click += new System.EventHandler(this.Grant_button_Click);
            // 
            // Role_label
            // 
            this.Role_label.AutoSize = true;
            this.Role_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role_label.Location = new System.Drawing.Point(75, 67);
            this.Role_label.Name = "Role_label";
            this.Role_label.Size = new System.Drawing.Size(40, 16);
            this.Role_label.TabIndex = 1;
            this.Role_label.Text = "Role";
            // 
            // User_label
            // 
            this.User_label.AutoSize = true;
            this.User_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_label.Location = new System.Drawing.Point(75, 126);
            this.User_label.Name = "User_label";
            this.User_label.Size = new System.Drawing.Size(40, 16);
            this.User_label.TabIndex = 2;
            this.User_label.Text = "User";
            // 
            // ROLE_TextBox
            // 
            this.ROLE_TextBox.Location = new System.Drawing.Point(121, 67);
            this.ROLE_TextBox.Name = "ROLE_TextBox";
            this.ROLE_TextBox.Size = new System.Drawing.Size(124, 20);
            this.ROLE_TextBox.TabIndex = 3;
            // 
            // USER_TextBox
            // 
            this.USER_TextBox.Location = new System.Drawing.Point(121, 122);
            this.USER_TextBox.Name = "USER_TextBox";
            this.USER_TextBox.Size = new System.Drawing.Size(124, 20);
            this.USER_TextBox.TabIndex = 4;
            // 
            // ExitGrant
            // 
            this.ExitGrant.Location = new System.Drawing.Point(273, 214);
            this.ExitGrant.Name = "ExitGrant";
            this.ExitGrant.Size = new System.Drawing.Size(75, 23);
            this.ExitGrant.TabIndex = 5;
            this.ExitGrant.Text = "Close";
            this.ExitGrant.UseVisualStyleBackColor = true;
            this.ExitGrant.Click += new System.EventHandler(this.ExitGrant_Click);
            // 
            // GrantRoleUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 249);
            this.ControlBox = false;
            this.Controls.Add(this.ExitGrant);
            this.Controls.Add(this.USER_TextBox);
            this.Controls.Add(this.ROLE_TextBox);
            this.Controls.Add(this.User_label);
            this.Controls.Add(this.Role_label);
            this.Controls.Add(this.Grant_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GrantRoleUser";
            this.Text = "GrantRoleUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Grant_button;
        private System.Windows.Forms.Label Role_label;
        private System.Windows.Forms.Label User_label;
        private System.Windows.Forms.TextBox ROLE_TextBox;
        private System.Windows.Forms.TextBox USER_TextBox;
        private System.Windows.Forms.Button ExitGrant;
    }
}