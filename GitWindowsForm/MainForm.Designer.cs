namespace GitWindowsForm
{
    partial class RegisterForm
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
            this.btn_register = new System.Windows.Forms.Button();
            this.lbl_enter_name = new System.Windows.Forms.Label();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txtBox_email = new System.Windows.Forms.TextBox();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.txtBox_lastName = new System.Windows.Forms.TextBox();
            this.gBox_fillInfo = new System.Windows.Forms.GroupBox();
            this.txtBox_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.chckBox_hidePassword = new System.Windows.Forms.CheckBox();
            this.gBox_fillInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_register.Location = new System.Drawing.Point(250, 190);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 5;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // lbl_enter_name
            // 
            this.lbl_enter_name.AutoSize = true;
            this.lbl_enter_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_enter_name.Location = new System.Drawing.Point(6, 43);
            this.lbl_enter_name.Name = "lbl_enter_name";
            this.lbl_enter_name.Size = new System.Drawing.Size(93, 16);
            this.lbl_enter_name.TabIndex = 1;
            this.lbl_enter_name.Text = "Enter Name:";
            // 
            // txtBox_name
            // 
            this.txtBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_name.Location = new System.Drawing.Point(142, 37);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(183, 26);
            this.txtBox_name.TabIndex = 0;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_email.Location = new System.Drawing.Point(6, 75);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(91, 16);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "Enter Email:";
            // 
            // txtBox_email
            // 
            this.txtBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_email.Location = new System.Drawing.Point(142, 69);
            this.txtBox_email.Name = "txtBox_email";
            this.txtBox_email.Size = new System.Drawing.Size(183, 26);
            this.txtBox_email.TabIndex = 1;
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_lastName.Location = new System.Drawing.Point(6, 107);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(122, 16);
            this.lbl_lastName.TabIndex = 1;
            this.lbl_lastName.Text = "Enter LastName:";
            // 
            // txtBox_lastName
            // 
            this.txtBox_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_lastName.Location = new System.Drawing.Point(142, 101);
            this.txtBox_lastName.Name = "txtBox_lastName";
            this.txtBox_lastName.Size = new System.Drawing.Size(183, 26);
            this.txtBox_lastName.TabIndex = 2;
            // 
            // gBox_fillInfo
            // 
            this.gBox_fillInfo.Controls.Add(this.chckBox_hidePassword);
            this.gBox_fillInfo.Controls.Add(this.lbl_password);
            this.gBox_fillInfo.Controls.Add(this.lbl_lastName);
            this.gBox_fillInfo.Controls.Add(this.txtBox_password);
            this.gBox_fillInfo.Controls.Add(this.txtBox_lastName);
            this.gBox_fillInfo.Controls.Add(this.lbl_email);
            this.gBox_fillInfo.Controls.Add(this.lbl_enter_name);
            this.gBox_fillInfo.Controls.Add(this.txtBox_email);
            this.gBox_fillInfo.Controls.Add(this.txtBox_name);
            this.gBox_fillInfo.Controls.Add(this.btn_register);
            this.gBox_fillInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gBox_fillInfo.Location = new System.Drawing.Point(12, 12);
            this.gBox_fillInfo.Name = "gBox_fillInfo";
            this.gBox_fillInfo.Size = new System.Drawing.Size(345, 220);
            this.gBox_fillInfo.TabIndex = 3;
            this.gBox_fillInfo.TabStop = false;
            this.gBox_fillInfo.Text = "Fill Info";
            // 
            // txtBox_password
            // 
            this.txtBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_password.Location = new System.Drawing.Point(142, 158);
            this.txtBox_password.Name = "txtBox_password";
            this.txtBox_password.Size = new System.Drawing.Size(183, 26);
            this.txtBox_password.TabIndex = 3;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_password.Location = new System.Drawing.Point(6, 164);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(120, 16);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Enter Password:";
            // 
            // chckBox_hidePassword
            // 
            this.chckBox_hidePassword.AutoSize = true;
            this.chckBox_hidePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chckBox_hidePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chckBox_hidePassword.Location = new System.Drawing.Point(134, 196);
            this.chckBox_hidePassword.Name = "chckBox_hidePassword";
            this.chckBox_hidePassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chckBox_hidePassword.Size = new System.Drawing.Size(110, 17);
            this.chckBox_hidePassword.TabIndex = 4;
            this.chckBox_hidePassword.Text = "Hide Password";
            this.chckBox_hidePassword.UseVisualStyleBackColor = true;
            this.chckBox_hidePassword.CheckedChanged += new System.EventHandler(this.chckBox_hidePassword_CheckedChanged);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 244);
            this.Controls.Add(this.gBox_fillInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register Form";
            this.gBox_fillInfo.ResumeLayout(false);
            this.gBox_fillInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label lbl_enter_name;
        private System.Windows.Forms.TextBox txtBox_name;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txtBox_email;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.TextBox txtBox_lastName;
        private System.Windows.Forms.GroupBox gBox_fillInfo;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txtBox_password;
        private System.Windows.Forms.CheckBox chckBox_hidePassword;
    }
}

