using System;
using System.Data.SqlClient;
using System.IO;
namespace HIMILO_ICT_PAYROLL_SYSTEM
{
    internal class Connections
    {

        public static SqlConnection GetSqlConnection()
        {
            string path = Path.GetFullPath(Environment.CurrentDirectory);
            string database = "HIMILO_ICT_PAYROLL.mdf";
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + database + ";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            // SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-N9PT8FH\SQLEXPRESS;Initial Catalog=HIMILO_ICT_PAYROLL;Integrated Security=True");
            return conn;
        }


    }
}
