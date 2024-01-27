﻿using System;
using System.Data.SqlClient;

namespace WrightBrothersApi.Controllers
{
    public class SecureLogin
    {
        private readonly string _connectionString;

        public SecureLogin(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool AuthenticateUser(string username, string password)
        {
            string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";

            using (SqlConnection connection = new)
        }
    }
}
{
    public class SqlInjectionExample
    {
        private readonly string _connectionString;

        public SqlInjectionExample(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool AuthenticateUser(string username, string password)
        {
            string query = "SELECT * FROM Users WHERE Username = '" + username + "' AND Password = '" + password + "'";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Close();
                        return true;
                    }

                    reader.Close();
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
