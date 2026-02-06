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
    public class TempOrderRepository
    {
        private readonly DBConnector dbConnector;
        public TempOrderRepository(DBConnector _dbConnector)
        {
            dbConnector = _dbConnector;
        }

        public List<TempOrderDto> TempGetAllOrders()
        {
            List<TempOrderDto> orders = new List<TempOrderDto>();
            using (MySqlConnection connection = dbConnector.CreateConnection())
            {
                string query = @"select * from TempOrders ";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            orders.Add(new TempOrderDto()
                            {
                                temorderId = Convert.ToInt32(reader["temorderId"].ToString()),
                                orderId = Convert.ToInt32(reader["orderId"].ToString()),
                                temorderDate = Convert.ToDateTime(reader["temorderDate"].ToString()),
                                temproductId = Convert.ToInt32(reader["temproductId"].ToString()),
                                temproductName = reader["temproductName"].ToString(),
                                temcustomerId = Convert.ToInt32(reader["temcustomerId"].ToString()),
                                temqty = Convert.ToInt32(reader["temqty"].ToString()),
                                temprice = Convert.ToInt32(reader["temprice"].ToString()),
                                temtPrice = Convert.ToInt32(reader["temtPrice"].ToString())
                            });
                        }
                    }
                    connection.Close();
                }
            }
            return orders;
        }

        public void ClearDB()
        {
            using (MySqlConnection connection = dbConnector.CreateConnection())
            {
                string query = @"truncate table TempOrders";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public bool TempDeleteOrder(int temorderId)
        {
            using (MySqlConnection connection = dbConnector.CreateConnection())
            {
                string query = @"Delete from temporders where temorderId = @temorderId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@temorderId", temorderId);
                    connection.Open();
                    int rowEffcet = command.ExecuteNonQuery();
                    connection.Close();
                    return rowEffcet > 0;
                }
            }
        }

        public bool TempUpdateOrder(int temorderId, int temorderqty, int temtPrice)
        {
            using (MySqlConnection connection = dbConnector.CreateConnection())
            {
                string query = @"update temporders set temqty=@temqty,temtPrice=@temtPrice where temorderId=@temorderId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@temorderId", temorderId);
                    command.Parameters.AddWithValue("@temqty", temorderqty);
                    command.Parameters.AddWithValue("@temtPrice", temtPrice);
                    connection.Open();
                    int rowEffect;  rowEffect = command.ExecuteNonQuery();
                    connection.Close();
                    return rowEffect > 0;
                }
                
            }
        }


        public int TempGetInvoiceNumber()
        {
            using (MySqlConnection connection = dbConnector.CreateConnection())
            {
                string query = @"Insert into invoice_counter (last_invoice_number) values (@last_invoice_number); select last_insert_id()";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@last_invoice_number", 1);
                    connection.Open();
                    int id = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();
                    return id;
                }
            }
        }
    }
}
