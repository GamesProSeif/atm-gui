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
    internal partial class OperationChoiceForm : AtmForm
    {
        private User user;

        public OperationChoiceForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            // Open deposit form
            new chooseDeposit(user).Show();
            Close();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            // Open withdraw form
            new chooseWithdraw(user).Show();
            Close();
        }

        private void showBalanceButton_Click(object sender, EventArgs e)
        {
            // Open receipt with show balance option
            new ShowBalance(user).Show();
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
