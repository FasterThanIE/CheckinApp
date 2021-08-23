using System;
using System.Data;
using System.Diagnostics;
using MySqlConnector;

namespace CheckinApp
{
    public class UserDetails
    {
	    private string ConnectionString = $"SERVER=localhost;DATABASE=pin_db;UID=root;PASSWORD=;";

        public void AddDetails(string email, string password)
        {
            string Query = "INSERT INTO user_details (email, password) VALUES (@email, @password)";

            using (MySqlConnection sql = new MySqlConnection(ConnectionString))
            {
                sql.Open();

                using (MySqlCommand cmd = new MySqlCommand(Query, sql))
                {
                    cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                    cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
                    cmd.ExecuteNonQuery();
                }
            }
            
        }
    }
}

