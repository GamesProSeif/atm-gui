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
            // Create new user
            user = new User(username.Text, password.Text);
            userController.InsertUser(user);

            // Open Main Form if successful
            OpenMainForm(user);
        }

        //@TODO: Implement UsernameTaken Error
        private void TriggerUsernameTakenError()
        {
            Debug.WriteLine("Username taken");
        }

        //@TODO: Implement OpenMainForm
        private void OpenMainForm(User user)
        {
            Debug.WriteLine("Proceed to main form with user: " + user.Name);
        }
    }
}
