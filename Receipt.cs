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
    internal partial class Receipt : AtmForm
    {
        private User user;
        private int process;
        private double amount;
        public Receipt(User user, int process, double amount)
        {
            InitializeComponent();
            this.user = user;
            this.process = process;
            this.amount = amount;
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            username.Text = ""+user.Id;
            if (process == 1)
                textBox1.Text = "Deposit";
            else if (process == 2)
                textBox1.Text = "Withdraw";
            else
                textBox1.Text = "Balance Check";
            textBox2.Text = "" + amount;
            textBox3.Text=""+DateTime.Now.ToString();

        }

        private void logoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LoginForm().Show();
            Close();
        }
    }
}
