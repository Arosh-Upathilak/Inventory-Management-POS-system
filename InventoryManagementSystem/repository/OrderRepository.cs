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
    public class OrderRepository
    {
        private readonly DBConnector dbConnector;
        public OrderRepository(DBConnector _dbConnector)
        {
            dbConnector = _dbConnector;
        }

        public List<OrderDto> GetAllOrders(string searchText="")
        {
            List<OrderDto> orders = new List<OrderDto>();
            using (MySqlConnection connection = dbConnector.CreateConnection())
            {
                string query = @"select * from Orders where concat(orderId,orderDate,productId,customerId,productName,qty,price,tPrice) like concat('%',@searchText,'%') ";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchText", searchText);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            orders.Add(new OrderDto()
                            {
                                orderId = Convert.ToInt32(reader["OrderId"].ToString()),
                                orderDate = Convert.ToDateTime(reader["orderDate"].ToString()),
                                productId = Convert.ToInt32(reader["productId"].ToString()),
                                productName = reader["productName"].ToString(),
                                customerId = Convert.ToInt32(reader["customerId"].ToString()),
                                qty = Convert.ToInt32(reader["qty"].ToString()),
                                price = Convert.ToInt32(reader["price"].ToString()),
                                tPrice = Convert.ToInt32(reader["tPrice"].ToString())
                            });
                        }
                    }
                    connection.Close();
                }
            }
            return orders;
        }

        public void CreateOrder(OrderDto orderDto)
        {
            using (MySqlConnection connection = dbConnector.CreateConnection())
            {
                int currentQty;
                int orderId;
                connection.Open();
                string queryGetQuantity = @"select productQuantity from Products where productId = @productId";
                using (MySqlCommand commandGetQuantity = new MySqlCommand(queryGetQuantity, connection))
                {
                    commandGetQuantity.Parameters.AddWithValue("@productId", orderDto.productId);
                    object result = commandGetQuantity.ExecuteScalar();
                    if (result == null)
                        throw new Exception("Product not found");
                    currentQty = Convert.ToInt32(commandGetQuantity.ExecuteScalar());
                }
                if(currentQty < Convert.ToInt32(orderDto.qty))
                {
                    throw new Exception("Not enough stock available");
                }
                string query = @"insert into Orders (orderDate,productId,customerId,productName,qty,price,tPrice) values (@orderDate,@productId,@customerId,@productName,@qty,@price,@tPrice); select last_insert_id()";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@orderDate", orderDto.orderDate);
                    command.Parameters.AddWithValue("@productId", orderDto.productId);
                    command.Parameters.AddWithValue("@customerId", orderDto.customerId);
                    command.Parameters.AddWithValue("@productName", orderDto.productName);
                    command.Parameters.AddWithValue("@qty", orderDto.qty);
                    command.Parameters.AddWithValue("@price", orderDto.price);
                    command.Parameters.AddWithValue("@tPrice", orderDto.tPrice);
                    command.Parameters.AddWithValue("@productQuantity", orderDto.qty);
                    orderId= Convert.ToInt32(command.ExecuteScalar());
                }

                string queryTemp = @"insert into TempOrders (orderId,temorderDate,temproductId,temcustomerId,temproductName,temqty,temprice,temtPrice) values (@orderId,@orderDate,@productId,@customerId,@productName,@qty,@price,@tPrice)";
                using (MySqlCommand command = new MySqlCommand(queryTemp, connection))
                {
                    command.Parameters.AddWithValue("@orderId", orderId);
                    command.Parameters.AddWithValue("@orderDate", orderDto.orderDate);
                    command.Parameters.AddWithValue("@productId", orderDto.productId);
                    command.Parameters.AddWithValue("@customerId", orderDto.customerId);
                    command.Parameters.AddWithValue("@productName", orderDto.productName);
                    command.Parameters.AddWithValue("@qty", orderDto.qty);
                    command.Parameters.AddWithValue("@price", orderDto.price);
                    command.Parameters.AddWithValue("@tPrice", orderDto.tPrice);
                    command.Parameters.AddWithValue("@productQuantity", orderDto.qty);
                    command.ExecuteNonQuery();
                }

                string querySetQuantity = @"update Products set productQuantity = @productQuantity where productId = @productId";
                using (MySqlCommand commandSetSetQuantity = new MySqlCommand(querySetQuantity, connection))
                {
                    commandSetSetQuantity.Parameters.AddWithValue("@productId", orderDto.productId);
                    commandSetSetQuantity.Parameters.AddWithValue("@productQuantity", currentQty - Convert.ToInt32(orderDto.qty));
                    commandSetSetQuantity.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public bool DeleteOrder(int orderId)
        {
            using (MySqlConnection connection = dbConnector.CreateConnection())
            {
                int productId;
                int currentQty;
                int deleteQty;
                int rowEffect;
                connection.Open();
                string queryGetProductId = @"select productId,qty from Orders where orderId = @orderId";
                using (MySqlCommand commandGetProduct = new MySqlCommand(queryGetProductId, connection))
                {
                    commandGetProduct.Parameters.AddWithValue("@orderId", orderId);
                    using (MySqlDataReader reader = commandGetProduct.ExecuteReader())
                    {
                        if (!reader.Read())
                            throw new Exception("Order not found");

                        productId = reader.GetInt32("productId");
                        deleteQty = reader.GetInt32("qty");
                    }
                }

                string queryGetQuantity = @"select productQuantity from Products where productId = @productId";
                using (MySqlCommand commandGetQuantity = new MySqlCommand(queryGetQuantity, connection))
                {
                    commandGetQuantity.Parameters.AddWithValue("@productId", productId);
                    object result = commandGetQuantity.ExecuteScalar();
                    if (result == null)
                        throw new Exception("Product not found");
                    currentQty = Convert.ToInt32(commandGetQuantity.ExecuteScalar());
                }

                string query = @"Delete from Orders where orderId = @orderId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@orderId", orderId);
                    rowEffect = command.ExecuteNonQuery();
                }

                string querySetQuantity = @"update Products set productQuantity = @productQuantity where productId = @productId";
                using (MySqlCommand commandSetSetQuantity = new MySqlCommand(querySetQuantity, connection))
                {
                    commandSetSetQuantity.Parameters.AddWithValue("@productId", productId);
                    commandSetSetQuantity.Parameters.AddWithValue("@productQuantity", currentQty + deleteQty);
                    commandSetSetQuantity.ExecuteNonQuery();
                }
                connection.Close();
                return rowEffect > 0;

            }
        }

        public OrderEditDto GetOrderById(int orderId)
        {
            OrderEditDto order = null;
            using (MySqlConnection connection = dbConnector.CreateConnection())
            {
                string query = @"select p.productId,p.productName,p.productQuantity,p.productPrice,p.productDescription,p.productCategory,o.qty as orderQuantity,o.orderDate as orderDate,o.orderId from products as p left join (orders as o) on o.productId = p.productId where o.orderId =@orderId;";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@orderId", orderId);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())   
                        {
                            order = new OrderEditDto()
                            {
                                productId = Convert.ToInt32(reader["productId"]),
                                productName = reader["productName"].ToString(),
                                productQuantity = Convert.ToInt32(reader["productQuantity"]),
                                productPrice = Convert.ToInt32(reader["productPrice"]),
                                productDescription = reader["productDescription"].ToString(),
                                productCategory = reader["productCategory"].ToString(),
                                orderQuantity = Convert.ToInt32(reader["orderQuantity"]),
                                orderDate = Convert.ToDateTime(reader["orderDate"]),
                                orderId = Convert.ToInt32(reader["orderId"])
                            };
                        }
                    }
                    connection.Close();
                }
            }
            return order;
        }

        public bool UpdateOrder(int orderId,int orderqty, int tPrice,int productId,int qty)
        {
            using (MySqlConnection connection = dbConnector.CreateConnection())
            {
                connection.Open();
                int rowEffect;
                string querySetProduct = @"update Products set productQuantity=@productQuantity where productId=@productId";
                using (MySqlCommand command = new MySqlCommand(querySetProduct, connection))
                {
                    command.Parameters.AddWithValue("@productId", productId);
                    command.Parameters.AddWithValue("@productQuantity", qty);
                    command.Parameters.AddWithValue("@tPrice", tPrice);
                    command.ExecuteNonQuery();
                    
                }

                string query = @"update Orders set qty=@qty,tPrice=@tPrice where orderId=@orderId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@orderId", orderId);
                    command.Parameters.AddWithValue("@qty", orderqty);
                    command.Parameters.AddWithValue("@tPrice", tPrice);
                    rowEffect = command.ExecuteNonQuery(); 
                    
                }
                connection.Close();
                return rowEffect > 0;
            }
        }
    }
}
