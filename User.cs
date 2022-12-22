using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ATM_GUI
{
    internal class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        private double balance;
        public double Balance {
            get { return balance; }
            set { if (value >= 0) balance = value; }
        }

        public User() { }
        public User(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }
    }
}
