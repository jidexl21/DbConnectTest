using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Connect
    {
        private static string connectionString = @"Server=DESKTOP-DI2HUE4;Database=;User Id=sa;Password=P@ssw0rd;";
        public void runQry(string queryString, Dictionary<string,object> args) {
            DataTable data = new DataTable(); 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                foreach (KeyValuePair<string, object> kv in args) {
                   command.Parameters.AddWithValue($"@{kv.Key}", kv.Value);
                }
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(queryString, connection);
                da.Fill(data);
            }
        }
    }

}
