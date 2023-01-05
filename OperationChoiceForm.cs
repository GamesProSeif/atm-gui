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
    public partial class OperationChoiceForm : Form
    {
        private User user;

        public OperationChoiceForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (Application.OpenForms.Count == 1)
                Application.Exit();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            // Open deposit form
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            // Open withdraw form
        }

        private void showBalanceButton_Click(object sender, EventArgs e)
        {
            // Open receipt with show balance option
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
