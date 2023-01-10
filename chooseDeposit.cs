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
    internal partial class chooseDeposit : AtmForm
    {
        private User user;
        public chooseDeposit(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            Close();
        }

        private void button200_Click(object sender, EventArgs e)
        {
            userController.UpdateUserBalance(user, 200 + user.Balance);
            new Receipt(user, 1, 200).Show();
            Close();
        }

        private void button500_Click(object sender, EventArgs e)
        {
            userController.UpdateUserBalance(user, 500 + user.Balance);
            new Receipt(user, 1, 500).Show();
            Close();
        }

        private void button1000_Click(object sender, EventArgs e)
        {
            userController.UpdateUserBalance(user, 1000 + user.Balance);
            new Receipt(user, 1, 1000).Show();
            Close();
        }

        private void button2000_Click(object sender, EventArgs e)
        {
            userController.UpdateUserBalance(user, 2000 + user.Balance);
            new Receipt(user, 1, 2000).Show();
            Close();
        }

        private void Otherbutton_Click(object sender, EventArgs e)
        {
            new Deposit(user).Show();
            Close();
        }
    }
}
