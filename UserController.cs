using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ATM_GUI
{
    // Controller used to apply changes to user database
    // Make sure to add UserController as an instance variable to all forms
    internal class UserController
    {
       
        private string DatabasePath ="atm-gui.db3";

        public UserController()
        {
            // Create database if not found in "Documents" folder
            if (!System.IO.File.Exists(DatabasePath))
            {
                var db = CreateConnection();
                db.CreateTable<User>();
                db.Close();
            }
        }

        // Creates a connection to the database
        public SQLiteConnection CreateConnection()
        {
            return new SQLiteConnection(DatabasePath, false);
        }

        // Inserts a user given a User object
        public void InsertUser(User user)
        {
            var db = CreateConnection();
            db.Insert(user);
            db.Close();
        }

        // Gets a user using Id
        public User GetUserById(string id)
        {
            var db = CreateConnection();
            User user = db.Find<User>(id);
            db.Close();
            return user;
        }

        // Gets a user by Name
        public User GetUserByName(string name)
        {
            var db = CreateConnection();
            User user = db.Find<User>(u => u.Name == name);
            db.Close();
            return user;
        }

        // Lists all users in database
        public List<User> ListUsers()
        {
            var db = CreateConnection();
            var results = db.Table<User>().ToList();
            db.Close();
            return results;
        }

        // Updates the user balance
        public void UpdateUserBalance(User user, double balance)
        {
            var db = CreateConnection();
            User newUser = new User()
            {
                Id = user.Id,
                Name = user.Name,
                Password = user.Password,
                CreatedAt = user.CreatedAt,
                ModifiedAt = DateTime.Now,
                Balance = balance
            };
            db.Update(newUser);
            db.Close();
        }

        // Deletes a user given a user Id
        public void DeleteUser(string id)
        {
            var db = CreateConnection();
            db.Delete<User>(id);
            db.Close();
        }
    }
}
