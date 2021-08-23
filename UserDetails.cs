using System;
using MySqlConnector;

namespace CheckinApp
{
    public class UserDetails
    {
	    private MySqlConnection SQLConnection;

	    public UserDetails()
        {
            ConnectionString = $"SERVER=localhost;DATABASE=pin_db;UID=root;PASSWORD=;";

            SQLConnection = new MySqlConnection(ConnectionString);
        }

        public void addDetails(string email, string password)
        {
            string Query = "INSERT INTO user_details (email, password) VALUES ('"+email+"', '"+password+"')";
        }
    }
}

