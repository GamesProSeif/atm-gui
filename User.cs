using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ATM_GUI
{
    [Table("users")]
    public class User
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("password")]
        public string Password { get; set; }
        private double balance;
        [Column("balance")]
        public double Balance {
            get { return balance; }
            set { if (value >= 0) balance = value; }
        }
        [Column("createdAt")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Column("modifiedAt")]
        public DateTime ModifiedAt { get; set; } = DateTime.Now;

        public User() { }
        public User(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }
    }
}
