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
    internal partial class chooseWithdraw : AtmForm
    {
        private User user;
        public chooseWithdraw(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button200_Click(object sender, EventArgs e)
        {
            double availableBalance = user.Balance;
            if (200 > availableBalance)
                MessageBox.Show("Sorry You Have Insufficient Funds");
            else
            {
                userController.UpdateUserBalance(user, user.Balance - 200);
                new Receipt(user, 2, 200).Show();
                Close();
            }
        }

        private void button500_Click(object sender, EventArgs e)
        {
            double availableBalance = user.Balance;
            if (500 > availableBalance)
                MessageBox.Show("Sorry You Have Insufficient Funds");
            else
            {
                userController.UpdateUserBalance(user, user.Balance - 500);
                new Receipt(user, 2, 500).Show();
                Close();
            }
        }

        private void button1000_Click(object sender, EventArgs e)
        {
            double availableBalance = user.Balance;
            if (1000 > availableBalance)
                MessageBox.Show("Sorry You Have Insufficient Funds");
            else
            {
                userController.UpdateUserBalance(user, user.Balance - 1000);
                new Receipt(user, 2, 1000).Show();
                Close();
            }
        }

        private void button2000_Click(object sender, EventArgs e)
        {
            double availableBalance = user.Balance;
            if (2000 > availableBalance)
                MessageBox.Show("Sorry You Have Insufficient Funds");
            else
            {
                userController.UpdateUserBalance(user, user.Balance - 2000);
                new Receipt(user, 2, 2000).Show();
                Close();
            }
        }

        private void Otherbutton_Click(object sender, EventArgs e)
        {
            new Withdraw(user).Show();
                Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new OperationChoiceForm(user).Show();
            Close();
        }
    }
}
