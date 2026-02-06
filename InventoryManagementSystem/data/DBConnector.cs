using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.Configuration;


namespace InventoryManagementSystem.Data
{
    public  class DBConnector 
    {
        private readonly string _connectionString;
        public DBConnector()
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory) 
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

            _connectionString = configuration.GetConnectionString("DefaultConnection")
                ?? throw new Exception("DefaultConnection not found in appsettings.json");


        }

        public MySqlConnection CreateConnection()
        {
            return new MySqlConnection(_connectionString);
        }

    }
}
