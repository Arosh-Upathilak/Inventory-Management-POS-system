using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InventoryManagementSystem.Repository
{
    public class UserRepository
    {
        private readonly DBConnector _dbConnector;
        public UserRepository(DBConnector dBConnector) 
        {
            _dbConnector = dBConnector;
        }
        public void CreateUser(UserDto user)
        {
            using(MySqlConnection connection = _dbConnector.CreateConnection())
            {
                string query = @"Insert into Users (username,fullname,password,phone) values
                   (@username,@fullname,@password,@phone)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", user.username);
                    command.Parameters.AddWithValue("@fullname", user.fullname);
                    command.Parameters.AddWithValue("@password", user.password);
                    command.Parameters.AddWithValue("@phone", user.phone);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public List<UserDto> GetAllUsers()
        {
            List<UserDto> users = new List<UserDto>();
           
            using (MySqlConnection connection = _dbConnector.CreateConnection())
            {
                string query = @"select * from Users";
                using(MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using(MySqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            users.Add(new UserDto()
                            {
                                username = reader["username"].ToString(),
                                fullname = reader["fullname"].ToString(),
                                password = reader["password"].ToString(),
                                phone = reader["phone"].ToString(),
                            });
                        }
                    }
                    connection.Close();
                }
            }
            return users;
        }

        public bool DeleteUser(string username)
        {
            string query = @"Delete from Users where username = @username";
            using(MySqlConnection connection = _dbConnector.CreateConnection())
            {
                using(MySqlCommand command = new MySqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();
                    return rowsAffected > 0;
                }

            }
        }

        public bool UpdateUser(UserDto updateUser)
        {
            string qurey = @"Update Users set  fullname=@fullname, password=@password, phone=@phone where username=@username";
            using (MySqlConnection connection = _dbConnector.CreateConnection())
            {
                using (MySqlCommand command = new MySqlCommand(qurey, connection))
                {
                    command.Parameters.AddWithValue("@username", updateUser.username);
                    command.Parameters.AddWithValue("@fullname", updateUser.fullname);
                    command.Parameters.AddWithValue("@password", updateUser.password);
                    command.Parameters.AddWithValue("@phone", updateUser.phone);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();
                    return rowsAffected > 0;
                }
            }
        }

        public string LoginUser(string userName,string password)
        {
            using (MySqlConnection connection = _dbConnector.CreateConnection())
            {
                string query = @"select fullname from Users where username =@username and password =@password";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", userName);
                    command.Parameters.AddWithValue("@password", password);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result == null)
                        throw new Exception("Login Failed");
                    string fullname = Convert.ToString(command.ExecuteScalar());
                    connection.Close();
                    return fullname;
                }
            }
        }
    }
}
