using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitWindowsForm
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBox_name.Text) 
                && !String.IsNullOrEmpty(txtBox_lastName.Text) 
                && !String.IsNullOrEmpty(txtBox_lastName.Text)
                && !String.IsNullOrEmpty(txtBox_password.Text)
                )
            {
                
            }
            else
            {
                MessageBox.Show("You Entered Wrong Data!","Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBox_name.Text = string.Empty;
                txtBox_lastName.Text = string.Empty;
                txtBox_email.Text = string.Empty;
                txtBox_password.Text = string.Empty;
            }
        }

        private void chckBox_hidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBox_hidePassword.Checked)
                txtBox_password.UseSystemPasswordChar = true;
            else
                txtBox_password.UseSystemPasswordChar = false;
        }
    }
}
