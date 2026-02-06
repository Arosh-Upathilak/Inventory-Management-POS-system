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
    public class CategoryRepository
    {
        private readonly DBConnector dbConnector;

        public CategoryRepository(DBConnector _dbConnector)
        {
            dbConnector = _dbConnector;
        }

        public List<CategoryDto> GetAllCategory()
        {
            List<CategoryDto> categories = new List<CategoryDto>();
            using (MySqlConnection connection = dbConnector.CreateConnection())
            {
                string query = @"select * from Categories";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categories.Add(new CategoryDto()
                            {
                                categoryId = Convert.ToInt32(reader["categoryId"].ToString()),
                                categoryname = reader["categoryname"].ToString(),
                            });
                        }
                    }
                    connection.Close();
                }
            }
            return categories;
        }

        public void CreateCategory(CategoryDto categoryDto)
        {
            using (MySqlConnection connection = dbConnector.CreateConnection())
            {
                string query = @"insert into Categories (categoryname) values (@categoryname)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@categoryname", categoryDto.categoryname);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public bool DeleteCategory(int categoryId)
        {
            using (MySqlConnection connection = dbConnector.CreateConnection())
            {
                string query = @"Delete from Categories where categoryId = @categoryId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@categoryId", categoryId);
                    connection.Open();
                    int rowEffect = command.ExecuteNonQuery();
                    connection.Close();
                    return rowEffect > 0;
                }
            }
        }

        public bool UpdateCategory(CategoryDto categoryDto)
        {
            using (MySqlConnection connection = dbConnector.CreateConnection())
            {
                string query = @"update Categories set categoryname=@categoryname where categoryId=@categoryId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@categoryId", categoryDto.categoryId);
                    command.Parameters.AddWithValue("@categoryname", categoryDto.categoryname);
                    connection.Open();
                    int rowEffect = command.ExecuteNonQuery();
                    connection.Close();
                    return rowEffect > 0;
                }
            }
        }

    }
}
