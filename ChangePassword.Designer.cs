namespace Doctors_Desktop
{
    partial class ChangePassword
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Doctor = new System.Windows.Forms.TabPage();
            this.button_DocUpdate = new System.Windows.Forms.Button();
            this.textBox_DocNewPassword = new System.Windows.Forms.TextBox();
            this.textBox_DocNewUserName = new System.Windows.Forms.TextBox();
            this.textBox_DocCurrentPassword = new System.Windows.Forms.TextBox();
            this.textBox_DocCurrentUserName = new System.Windows.Forms.TextBox();
            this.label_NewPassword = new System.Windows.Forms.Label();
            this.label_NewUserName = new System.Windows.Forms.Label();
            this.label_CurrentPassword = new System.Windows.Forms.Label();
            this.label_CurrentUserName = new System.Windows.Forms.Label();
            this.tabPage_Assistant = new System.Windows.Forms.TabPage();
            this.button_AssUpdate = new System.Windows.Forms.Button();
            this.textBox_AssNewPassword = new System.Windows.Forms.TextBox();
            this.textBox_AssNewUsername = new System.Windows.Forms.TextBox();
            this.textBox_AssCurrentPassword = new System.Windows.Forms.TextBox();
            this.textBox_AssCurrentUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage_Doctor.SuspendLayout();
            this.tabPage_Assistant.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Doctor);
            this.tabControl1.Controls.Add(this.tabPage_Assistant);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(590, 360);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Doctor
            // 
            this.tabPage_Doctor.Controls.Add(this.button_DocUpdate);
            this.tabPage_Doctor.Controls.Add(this.textBox_DocNewPassword);
            this.tabPage_Doctor.Controls.Add(this.textBox_DocNewUserName);
            this.tabPage_Doctor.Controls.Add(this.textBox_DocCurrentPassword);
            this.tabPage_Doctor.Controls.Add(this.textBox_DocCurrentUserName);
            this.tabPage_Doctor.Controls.Add(this.label_NewPassword);
            this.tabPage_Doctor.Controls.Add(this.label_NewUserName);
            this.tabPage_Doctor.Controls.Add(this.label_CurrentPassword);
            this.tabPage_Doctor.Controls.Add(this.label_CurrentUserName);
            this.tabPage_Doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Doctor.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Doctor.Name = "tabPage_Doctor";
            this.tabPage_Doctor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Doctor.Size = new System.Drawing.Size(582, 327);
            this.tabPage_Doctor.TabIndex = 1;
            this.tabPage_Doctor.Text = "Doctor";
            this.tabPage_Doctor.UseVisualStyleBackColor = true;
            // 
            // button_DocUpdate
            // 
            this.button_DocUpdate.Location = new System.Drawing.Point(222, 241);
            this.button_DocUpdate.Name = "button_DocUpdate";
            this.button_DocUpdate.Size = new System.Drawing.Size(156, 47);
            this.button_DocUpdate.TabIndex = 8;
            this.button_DocUpdate.Text = "Update";
            this.button_DocUpdate.UseVisualStyleBackColor = true;
            this.button_DocUpdate.Click += new System.EventHandler(this.button_DocUpdate_Click);
            // 
            // textBox_DocNewPassword
            // 
            this.textBox_DocNewPassword.Location = new System.Drawing.Point(291, 171);
            this.textBox_DocNewPassword.Name = "textBox_DocNewPassword";
            this.textBox_DocNewPassword.PasswordChar = '*';
            this.textBox_DocNewPassword.Size = new System.Drawing.Size(173, 29);
            this.textBox_DocNewPassword.TabIndex = 7;
            // 
            // textBox_DocNewUserName
            // 
            this.textBox_DocNewUserName.Location = new System.Drawing.Point(291, 124);
            this.textBox_DocNewUserName.Name = "textBox_DocNewUserName";
            this.textBox_DocNewUserName.Size = new System.Drawing.Size(173, 29);
            this.textBox_DocNewUserName.TabIndex = 6;
            // 
            // textBox_DocCurrentPassword
            // 
            this.textBox_DocCurrentPassword.Location = new System.Drawing.Point(291, 74);
            this.textBox_DocCurrentPassword.Name = "textBox_DocCurrentPassword";
            this.textBox_DocCurrentPassword.PasswordChar = '*';
            this.textBox_DocCurrentPassword.Size = new System.Drawing.Size(173, 29);
            this.textBox_DocCurrentPassword.TabIndex = 5;
            // 
            // textBox_DocCurrentUserName
            // 
            this.textBox_DocCurrentUserName.Location = new System.Drawing.Point(291, 25);
            this.textBox_DocCurrentUserName.Name = "textBox_DocCurrentUserName";
            this.textBox_DocCurrentUserName.Size = new System.Drawing.Size(173, 29);
            this.textBox_DocCurrentUserName.TabIndex = 4;
            // 
            // label_NewPassword
            // 
            this.label_NewPassword.AutoSize = true;
            this.label_NewPassword.Location = new System.Drawing.Point(108, 174);
            this.label_NewPassword.Name = "label_NewPassword";
            this.label_NewPassword.Size = new System.Drawing.Size(141, 24);
            this.label_NewPassword.TabIndex = 3;
            this.label_NewPassword.Text = "New Password:";
            // 
            // label_NewUserName
            // 
            this.label_NewUserName.AutoSize = true;
            this.label_NewUserName.Location = new System.Drawing.Point(108, 127);
            this.label_NewUserName.Name = "label_NewUserName";
            this.label_NewUserName.Size = new System.Drawing.Size(154, 24);
            this.label_NewUserName.TabIndex = 2;
            this.label_NewUserName.Text = "New User Name:";
            // 
            // label_CurrentPassword
            // 
            this.label_CurrentPassword.AutoSize = true;
            this.label_CurrentPassword.Location = new System.Drawing.Point(108, 74);
            this.label_CurrentPassword.Name = "label_CurrentPassword";
            this.label_CurrentPassword.Size = new System.Drawing.Size(164, 24);
            this.label_CurrentPassword.TabIndex = 1;
            this.label_CurrentPassword.Text = "Current Password:";
            // 
            // label_CurrentUserName
            // 
            this.label_CurrentUserName.AutoSize = true;
            this.label_CurrentUserName.Location = new System.Drawing.Point(108, 25);
            this.label_CurrentUserName.Name = "label_CurrentUserName";
            this.label_CurrentUserName.Size = new System.Drawing.Size(177, 24);
            this.label_CurrentUserName.TabIndex = 0;
            this.label_CurrentUserName.Text = "Current User Name:";
            // 
            // tabPage_Assistant
            // 
            this.tabPage_Assistant.Controls.Add(this.button_AssUpdate);
            this.tabPage_Assistant.Controls.Add(this.textBox_AssNewPassword);
            this.tabPage_Assistant.Controls.Add(this.textBox_AssNewUsername);
            this.tabPage_Assistant.Controls.Add(this.textBox_AssCurrentPassword);
            this.tabPage_Assistant.Controls.Add(this.textBox_AssCurrentUserName);
            this.tabPage_Assistant.Controls.Add(this.label1);
            this.tabPage_Assistant.Controls.Add(this.label2);
            this.tabPage_Assistant.Controls.Add(this.label3);
            this.tabPage_Assistant.Controls.Add(this.label4);
            this.tabPage_Assistant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Assistant.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Assistant.Name = "tabPage_Assistant";
            this.tabPage_Assistant.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Assistant.Size = new System.Drawing.Size(582, 327);
            this.tabPage_Assistant.TabIndex = 2;
            this.tabPage_Assistant.Text = "Assistant";
            this.tabPage_Assistant.UseVisualStyleBackColor = true;
            // 
            // button_AssUpdate
            // 
            this.button_AssUpdate.Location = new System.Drawing.Point(229, 238);
            this.button_AssUpdate.Name = "button_AssUpdate";
            this.button_AssUpdate.Size = new System.Drawing.Size(156, 47);
            this.button_AssUpdate.TabIndex = 17;
            this.button_AssUpdate.Text = "Update";
            this.button_AssUpdate.UseVisualStyleBackColor = true;
            this.button_AssUpdate.Click += new System.EventHandler(this.button_AssUpdate_Click);
            // 
            // textBox_AssNewPassword
            // 
            this.textBox_AssNewPassword.Location = new System.Drawing.Point(298, 168);
            this.textBox_AssNewPassword.Name = "textBox_AssNewPassword";
            this.textBox_AssNewPassword.PasswordChar = '*';
            this.textBox_AssNewPassword.Size = new System.Drawing.Size(173, 29);
            this.textBox_AssNewPassword.TabIndex = 16;
            // 
            // textBox_AssNewUsername
            // 
            this.textBox_AssNewUsername.Location = new System.Drawing.Point(298, 121);
            this.textBox_AssNewUsername.Name = "textBox_AssNewUsername";
            this.textBox_AssNewUsername.Size = new System.Drawing.Size(173, 29);
            this.textBox_AssNewUsername.TabIndex = 15;
            // 
            // textBox_AssCurrentPassword
            // 
            this.textBox_AssCurrentPassword.Location = new System.Drawing.Point(298, 71);
            this.textBox_AssCurrentPassword.Name = "textBox_AssCurrentPassword";
            this.textBox_AssCurrentPassword.PasswordChar = '*';
            this.textBox_AssCurrentPassword.Size = new System.Drawing.Size(173, 29);
            this.textBox_AssCurrentPassword.TabIndex = 14;
            // 
            // textBox_AssCurrentUserName
            // 
            this.textBox_AssCurrentUserName.Location = new System.Drawing.Point(298, 22);
            this.textBox_AssCurrentUserName.Name = "textBox_AssCurrentUserName";
            this.textBox_AssCurrentUserName.Size = new System.Drawing.Size(173, 29);
            this.textBox_AssCurrentUserName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "New Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "New User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Current Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Current User Name:";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 375);
            this.Controls.Add(this.tabControl1);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Doctor.ResumeLayout(false);
            this.tabPage_Doctor.PerformLayout();
            this.tabPage_Assistant.ResumeLayout(false);
            this.tabPage_Assistant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Doctor;
        private System.Windows.Forms.TextBox textBox_DocNewPassword;
        private System.Windows.Forms.TextBox textBox_DocNewUserName;
        private System.Windows.Forms.TextBox textBox_DocCurrentPassword;
        private System.Windows.Forms.TextBox textBox_DocCurrentUserName;
        private System.Windows.Forms.Label label_NewPassword;
        private System.Windows.Forms.Label label_NewUserName;
        private System.Windows.Forms.Label label_CurrentPassword;
        private System.Windows.Forms.Label label_CurrentUserName;
        private System.Windows.Forms.TabPage tabPage_Assistant;
        private System.Windows.Forms.Button button_DocUpdate;
        private System.Windows.Forms.Button button_AssUpdate;
        private System.Windows.Forms.TextBox textBox_AssNewPassword;
        private System.Windows.Forms.TextBox textBox_AssNewUsername;
        private System.Windows.Forms.TextBox textBox_AssCurrentPassword;
        private System.Windows.Forms.TextBox textBox_AssCurrentUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}