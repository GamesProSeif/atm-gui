using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_GUI
{
    internal partial class Deposit : AtmForm
    {
        private User user;

        public Deposit(User user)
        {
            InitializeComponent();
            this.user = user;
            TB_DEPO.GotFocus += RText;
            TB_DEPO.LostFocus += AText;
        }

        void RText(object sender, EventArgs e)
        {
            if (TB_DEPO.Text == "Enter The Amount")
            {
                TB_DEPO.Text = "";
                TB_DEPO.ForeColor = Color.Black;
            }
        }

        public void AText(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TB_DEPO.Text))
            {
                TB_DEPO.Text = "Enter The Amount";
                TB_DEPO.ForeColor = Color.Gray;
            }
        }

        private void logoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LoginForm().Show();
            Close();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            double amount=Convert.ToDouble(TB_DEPO.Text);
            userController.UpdateUserBalance(user, amount + user.Balance);
            new Receipt(user, 1, amount).Show();
            Close();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
                new chooseDeposit(user).Show();
            Close();
        }
      
    }
}
