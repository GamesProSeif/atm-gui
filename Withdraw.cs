using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_GUI
{
    internal partial class Withdraw : AtmForm
    {
        private User user;

        public Withdraw(User user)
        {
            InitializeComponent();
            this.user = user;
            TB_WITH.GotFocus += RText;
            TB_WITH.LostFocus += AText;
        }
       
        void RText(object sender, EventArgs e)
        {
            if (TB_WITH.Text == "Enter The Amount")
            {
                TB_WITH.Text = "";
                TB_WITH.ForeColor = Color.Black;
            }
        }

        public void AText(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TB_WITH.Text))
            {
                TB_WITH.Text = "Enter The Amount";
                TB_WITH.ForeColor = Color.Gray;
            }
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            textBox2.Text=""+ user.Balance;
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(TB_WITH.Text);
            double availableBalance = user.Balance;
            if (amount > availableBalance)
                MessageBox.Show("Sorry You Have Insufficient Funds");
            else
            {
                userController.UpdateUserBalance(user, user.Balance - amount);
                new Receipt(user, 2, amount).Show();
                Close();
            }
        }

        private void logoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LoginForm().Show();
            Close();
        }

       
       

        private void Back_button_Click(object sender, EventArgs e)
        {
            new chooseWithdraw(user).Show();
            Close();
        }
    }
}
