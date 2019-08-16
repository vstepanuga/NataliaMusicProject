using System;
using System.Collections.Generic;
using Dapper;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace NataliaMusic.Controllers
{
    public class DatabaseConnect
    {
        public class Student
        {
            public int? student_id { get; set; }
            public string name { get; set; }
            public string student_link { get; set; }
        }

        public static IEnumerable<Student> GetDatabaseStudents()
        {
            var ConnectionString = "Database=NataliaMusic;Data Source=localhost;User ID=vstepa;Password=iHeIVXtViN8QpcXj6wzz";
            MySqlConnection MySql_conn = new MySqlConnection(ConnectionString);

            string query = "select * from student;";
            var studentList = MySql_conn.Query<Student>(query);

            return studentList;
        }
    }
}
