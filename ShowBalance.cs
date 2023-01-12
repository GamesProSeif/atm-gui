using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATM_GUI
{
    internal partial class ShowBalance : AtmForm
    {
        private User user;

        public ShowBalance(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void logoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LoginForm().Show();
            Close();
        }

        private void balance_TextChanged(object sender, EventArgs e)
        {
            balance.Text = "" + user.Balance;
        }

        private void ShowBalance_Load(object sender, EventArgs e)
        {
            balance.Text = "" + user.Balance;
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            new OperationChoiceForm(user).Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Receipt(user).Show();
            Close();
        }
    }
}
