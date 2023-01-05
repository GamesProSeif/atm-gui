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
            username.GotFocus += RUtext;
            password.GotFocus += RPtext;
            username.LostFocus += AUtext;
            password.LostFocus += APtext;
            
            
        }
        //username and password placeholder text remover
        public void RUtext(object sender, EventArgs e)
        {
            if (username.Text == "Enter Your Username")
            {
                username.Text = "";
                username.ForeColor = Color.Black;
            }
        }
        public void RPtext(object sender, EventArgs e)
        {
            
            if (password.Text == "Enter Your Password")
            {

                password.Text = "."; /*I do not know why on earth, but setting this 
                              * to empty doesnt let the next line work and strikes an error*/
                password.UseSystemPasswordChar = true;
                password.Text = "";
                password.ForeColor = Color.Black;
            }
        }
        //username and password placeholder applying after leaving
        public void AUtext(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(username.Text))
            {
                username.Text = "Enter Your Username";
                username.ForeColor = Color.Gray;
            }
        }

        public void APtext(object sender, EventArgs e)
        {
            
            if (String.IsNullOrWhiteSpace(password.Text))
            {
                password.Text = "Enter Your Password";
                password.UseSystemPasswordChar = false;
                password.ForeColor = Color.Gray;
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

        //Implement FalseInput
        private void TriggerFalseInput()
        {
            WrongInfo.Visible = true;
        }

        //@TODO: Implement OpenMainForm
        private void OpenMainForm(User user)
        {
            new OperationChoiceForm(user).Show();
            Close();
        }

    }
}
