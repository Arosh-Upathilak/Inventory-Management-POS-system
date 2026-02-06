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
    public class ProductReposiory
    {
        private readonly DBConnector dbConnector;
        public ProductReposiory(DBConnector _dbConnector)
        {
            dbConnector = _dbConnector;
        }

        public List<ProductDto> GetAllProducts(string textSearch="")
        {
            List<ProductDto> products = new List<ProductDto>();
            using (MySqlConnection connection = dbConnector.CreateConnection())
            {
                string query = @"select * from Products where concat(productId,productName,productQuantity,productDescription,productCategory) like concat('%',@textSearch,'%')";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@textSearch", textSearch);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            products.Add(new ProductDto()
                            {
                                productId = Convert.ToInt32(reader["productId"].ToString()),
                                productName = reader["productName"].ToString(),
                                productQuantity = Convert.ToInt32(reader["productQuantity"].ToString()),
                                productPrice = Convert.ToInt32(reader["productPrice"].ToString()),
                                productDescription = reader["productDescription"].ToString(),
                                productCategory = reader["productCategory"].ToString(),
                            });
                        }
                    }
                    connection.Close();
                }
            }
            return products;
        }

        public void CreateProduct(ProductDto productDto)
        {
            using (MySqlConnection connection = dbConnector.CreateConnection())
            {
                string query = @"insert into Products (productName,productQuantity,productPrice,productDescription,productCategory) values (@productName,@productQuantity,@productPrice,@productDescription,@productCategory)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productName", productDto.productName);
                    command.Parameters.AddWithValue("@productQuantity", productDto.productQuantity);
                    command.Parameters.AddWithValue("@productPrice", productDto.productPrice);
                    command.Parameters.AddWithValue("@productDescription", productDto.productDescription);
                    command.Parameters.AddWithValue("@productCategory", productDto.productCategory);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public bool DeleteProduct(int productId)
        {
            using (MySqlConnection connection = dbConnector.CreateConnection())
            {
                string query = @"Delete from Products where productId = @productId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productId", productId);
                    connection.Open();
                    int rowEffect = command.ExecuteNonQuery();
                    connection.Close();
                    return rowEffect > 0;
                }
            }
        }

        public bool UpdateProduct(ProductDto productDto)
        {
            using (MySqlConnection connection = dbConnector.CreateConnection())
            {
                string query = @"update Products set productName=@productName,productQuantity=@productQuantity,productPrice=@productPrice,productDescription=@productDescription,productCategory=@productCategory where productId=@productId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productId", productDto.productId);
                    command.Parameters.AddWithValue("@productName", productDto.productName);
                    command.Parameters.AddWithValue("@productQuantity", productDto.productQuantity);
                    command.Parameters.AddWithValue("@productPrice", productDto.productPrice);
                    command.Parameters.AddWithValue("@productDescription", productDto.productDescription);
                    command.Parameters.AddWithValue("@productCategory", productDto.productCategory);
                    connection.Open();
                    int rowEffect = command.ExecuteNonQuery();
                    connection.Close();
                    return rowEffect > 0;
                }
            }
        }

    }
}
