using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunshineMinistriesContact.Data_Acess_Layer
{
    public class AccessData
    {

        //public static SqlConnection GetConnection()
        //{
        //    string connectionString = "";
        //    SqlConnection connection = new SqlConnection(connectionString);
        //    return connection;
        //}

            //POSTGRES CONNECTION
        public static NpgsqlConnection GetConnection()
        {
            string connectionString = String.Format("Server={0};Port={1};" + "User Id={2};Password={3};" +
                "Database={4};", "localhost", "5432", "postgres", "superuser", "sunshinedb");
            var connection = new NpgsqlConnection(connectionString);
            return connection;
        }

    }
}
