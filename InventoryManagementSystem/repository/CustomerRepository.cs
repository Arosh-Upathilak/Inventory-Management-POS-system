using InventoryManagementSystem.Data;
using InventoryManagementSystem.Dtos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Repository
{
    public class CustomerRepository
    {
        private readonly DBConnector dbConnector;

        public CustomerRepository(DBConnector _dbConnector)
        {
            dbConnector = _dbConnector;
        }

        public List<CustomerDto> GetAllCustomers(string search="")
        {
            List<CustomerDto> customers = new List<CustomerDto>();
            using (MySqlConnection connection = dbConnector.CreateConnection())
            {
                string query = @"select * from Customers where concat(customerId,customerName,customerPhone) like concat('%',@search,'%')";
                using (MySqlCommand command = new MySqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@search", search);
                    connection.Open();
                    using(MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customers.Add(new CustomerDto()
                            {
                                customerId = Convert.ToInt32(reader["customerId"].ToString()),
                                customerName = reader["customerName"].ToString(),
                                customerPhone = reader["customerPhone"].ToString(),
                            });
                        }
                    }
                    connection.Close();
                }
            }
            return customers;
        }

        public void CreateCustomer(CustomerDto customerDto)
        {
            using (MySqlConnection connection = dbConnector.CreateConnection())
            {
                string query = @"insert into Customers (customerName,customerPhone) values (@customerName,@customerPhone)";
                using (MySqlCommand command = new MySqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@customerName", customerDto.customerName);
                    command.Parameters.AddWithValue("@customerPhone", customerDto.customerPhone);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public bool DeleteCustomer(int customerId)
        {
            using(MySqlConnection connection = dbConnector.CreateConnection())
            {
                string query = @"Delete from Customers where customerId = @customerId";
                using(MySqlCommand command = new MySqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@customerId", customerId);
                    connection.Open();
                    int rowEffect = command.ExecuteNonQuery();
                    connection.Close();
                    return rowEffect > 0;
                }
            }
        }

        public bool UpdateCustomer(CustomerDto customerDto)
        {
            using(MySqlConnection connection =  dbConnector.CreateConnection())
            {
                string query = @"update Customers set customerName=@customerName,customerPhone=@customerPhone where customerId=@customerId";
                using(MySqlCommand command = new MySqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@customerId", customerDto.customerId);
                    command.Parameters.AddWithValue("@customerName", customerDto.customerName);
                    command.Parameters.AddWithValue("@customerPhone", customerDto.customerPhone);
                    connection.Open();
                    int rowEffect = command.ExecuteNonQuery();
                    connection.Close();
                    return rowEffect > 0;
                }
            }
        }
    }
}
