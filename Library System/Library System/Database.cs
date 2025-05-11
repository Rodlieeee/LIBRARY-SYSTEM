using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    using MySql.Data.MySqlClient;

    public class Database
    {
        
        private static string connectionString = "server=localhost;user=root;password=bc@123!;database=librarysys;";

        
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
