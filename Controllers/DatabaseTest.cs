using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NataliaMusic.Controllers
{
    public class DatabaseTest
    {
        public static void Main()
        {
            connectionTest();
        }


        public static void connectionTest()
        {
            var dbCon = DatabaseConnect.Instance();
            dbCon.DatabaseName = "NataliaMusic";
            if (dbCon.IsConnect())
            {
                string query = "select * from student;";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("Reader has read the row: (" + reader.GetString(0) + ", " +  reader.GetString(1) + ", " + reader.GetString(2) + ")");                   
                }
            }
            dbCon.Close();
        }

    }
}
