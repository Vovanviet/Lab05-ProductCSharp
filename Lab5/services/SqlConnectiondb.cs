using System;
using System.Data.SqlClient;

namespace Lab5.services
{
    public class SqlConnectiondb
    {
        public SqlConnection GetSqlConnection()
        {
            string connectionString = "Server = DESKTOP-72U9R1B\\SQLEXPESS;Initial Catalog =dbTest; Integrated Security= SSPI";
            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }
    }
}
