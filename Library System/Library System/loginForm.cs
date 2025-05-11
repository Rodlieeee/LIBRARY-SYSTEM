using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    public partial class loginForm: Form
    {
        public loginForm()
        {
            InitializeComponent();
            passwordInput.UseSystemPasswordChar = true;
            passwordInput.Multiline = false;

        }

        private void submitButtonLogIn_Click(object sender, EventArgs e)
        {
            if (userNameInput.Text == "admin" && passwordInput.Text == "abc@123"){
                new LibSys().Show();
                this.Hide();
            }
            else {
                MessageBox.Show("The Username or Password is incorrect, please try again");
                userNameInput.Clear();
                passwordInput.Clear();
                userNameInput.Focus();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showPassCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCheck.Checked==true)
            {
                passwordInput.UseSystemPasswordChar = false;
                

            }
            else
            {
                passwordInput.UseSystemPasswordChar = true;
                passwordInput.Multiline = false;
            } 
        }
    }
}
