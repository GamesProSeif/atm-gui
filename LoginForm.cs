using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLite;

namespace ATM_GUI
{
    public partial class LoginForm : Form
    {
        UserController userController = new UserController();

        public LoginForm()
        {
            InitializeComponent();
            //Placeholder Text for username & pass
            username.Text = "Enter Your Username";
            password.Text= "Enter Your Password";
        }
        //username and password placeholder text remover
        private void username_Enter(object sender, EventArgs e)
        {
            if(username.Text== "Enter Your Username")
            {
                username.Text = "";
            }
        }
        
        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Enter Your Password")
            {
                password.Text = "";
            }
        }
        //username and password placeholder applying after leaving
        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "Enter Your Username";
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Enter Your Password";
            }
        }

        // Switch to RegisterForm
        private void registerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RegisterForm().Show();
            Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (Application.OpenForms.Count == 1)
                Application.Exit();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            // Attempt to find user
            User user = userController.GetUserByName(username.Text);

            // TriggerFalseInput if user is not found or not matching password
            if (user == null || user.Password != password.Text) {
                TriggerFalseInput();
                return;
            }
            // Open Main Form if successful
            OpenMainForm(user);
        }

        //@TODO: Implement FalseInput
        private void TriggerFalseInput()
        {
            Debug.WriteLine("Username and password do not match");
        }

        //@TODO: Implement OpenMainForm
        private void OpenMainForm(User user)
        {
            Debug.WriteLine("Proceed to main form with user: " + user.Name);
        }

    }
}
