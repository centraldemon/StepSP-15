namespace GitWindowsForm
{
    partial class LoginForm
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
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_enter_name = new System.Windows.Forms.Label();
            this.txtBox_password = new System.Windows.Forms.TextBox();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.gBox_fillInfo = new System.Windows.Forms.GroupBox();
            this.btn_registretion = new System.Windows.Forms.Button();
            this.gBox_fillInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_email.Location = new System.Drawing.Point(6, 75);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(120, 16);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "Enter Password:";
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
            // txtBox_password
            // 
            this.txtBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_password.Location = new System.Drawing.Point(142, 69);
            this.txtBox_password.Name = "txtBox_password";
            this.txtBox_password.Size = new System.Drawing.Size(183, 26);
            this.txtBox_password.TabIndex = 2;
            // 
            // txtBox_name
            // 
            this.txtBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_name.Location = new System.Drawing.Point(142, 37);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(183, 26);
            this.txtBox_name.TabIndex = 2;
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_login.Location = new System.Drawing.Point(250, 135);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // gBox_fillInfo
            // 
            this.gBox_fillInfo.Controls.Add(this.btn_registretion);
            this.gBox_fillInfo.Controls.Add(this.lbl_email);
            this.gBox_fillInfo.Controls.Add(this.lbl_enter_name);
            this.gBox_fillInfo.Controls.Add(this.txtBox_password);
            this.gBox_fillInfo.Controls.Add(this.txtBox_name);
            this.gBox_fillInfo.Controls.Add(this.btn_login);
            this.gBox_fillInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gBox_fillInfo.Location = new System.Drawing.Point(12, 12);
            this.gBox_fillInfo.Name = "gBox_fillInfo";
            this.gBox_fillInfo.Size = new System.Drawing.Size(341, 175);
            this.gBox_fillInfo.TabIndex = 4;
            this.gBox_fillInfo.TabStop = false;
            this.gBox_fillInfo.Text = "Fill Info";
            // 
            // btn_registretion
            // 
            this.btn_registretion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_registretion.Location = new System.Drawing.Point(169, 135);
            this.btn_registretion.Name = "btn_registretion";
            this.btn_registretion.Size = new System.Drawing.Size(75, 23);
            this.btn_registretion.TabIndex = 3;
            this.btn_registretion.Text = "Registration";
            this.btn_registretion.UseVisualStyleBackColor = true;
            this.btn_registretion.Click += new System.EventHandler(this.btn_registretion_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 199);
            this.Controls.Add(this.gBox_fillInfo);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.gBox_fillInfo.ResumeLayout(false);
            this.gBox_fillInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_enter_name;
        private System.Windows.Forms.TextBox txtBox_password;
        private System.Windows.Forms.TextBox txtBox_name;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.GroupBox gBox_fillInfo;
        private System.Windows.Forms.Button btn_registretion;
    }
}