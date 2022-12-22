using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLite;

namespace ATM_GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitiateDB();
            Application.Run(new MainForm());
        }

        static void InitiateDB()
        {
            if (!System.IO.File.Exists("database.db3"))
            {
                var db = new SQLiteConnection("database.db3");
                db.CreateTable<User>();
                db.Close();
                Console.WriteLine("Created DB");
            }
        }
    }
}
