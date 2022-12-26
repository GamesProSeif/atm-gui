using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_GUI
{
    public partial class RegisterForm : Form
    {
        UserController userController = new UserController();

        public RegisterForm()
        {
            InitializeComponent();
            //Placeholder Text for username & pass
            username.GotFocus += RUtext;
            password.GotFocus += RPtext;
            username.LostFocus += AUtext;
            password.LostFocus += APtext;
            passconfirm.GotFocus += RPCtext; 
            passconfirm.LostFocus += APCtext;
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

                password.Text = "."; 
                password.UseSystemPasswordChar = true;
                password.Text = "";
                password.ForeColor = Color.Black;
            }
        }
        public void RPCtext(object sender, EventArgs e)
        {

            if (passconfirm.Text == "Confirm Password")
            {

                passconfirm.Text = "."; 
                passconfirm.UseSystemPasswordChar = true;
                passconfirm.Text = "";
                passconfirm.ForeColor = Color.Black;
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
        public void APCtext(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(passconfirm.Text))
            {
                passconfirm.Text = "Confirm Password";
                passconfirm.UseSystemPasswordChar = false;
                passconfirm.ForeColor = Color.Gray;
            }

        }
        // Switch to LoginForm
        private void loginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LoginForm().Show();
            Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (Application.OpenForms.Count == 1)
                Application.Exit();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            // Attempt to find user to ensure no duplicate names
            User user = userController.GetUserByName(username.Text);
            if (user != null)
            {
                // Trigger username taken
                TriggerUsernameTakenError();
                return;
            }
            else if(user==null)
            {
                //condition to ensure if username is ok removes error
                UserTaken.Visible = false;
                if (password.Text != passconfirm.Text)
                {

                    TriggerWrongPasswordError();
                    return;
                }
            }
            //checks password
            

            // Create new user
            user = new User(username.Text, password.Text);
            userController.InsertUser(user);

            // Open Main Form if successful
            OpenMainForm(user);
        }

        // UsernameTaken Error 
        private void TriggerUsernameTakenError()
        {
            UserTaken.Visible = true;
        }
        //Wrong password
        private void TriggerWrongPasswordError()
        {
            passmatch.Visible = true;
        }

        //@TODO: Implement OpenMainForm
        private void OpenMainForm(User user)
        {
            Debug.WriteLine("Proceed to main form with user: " + user.Name);
        }

       
    }
}
