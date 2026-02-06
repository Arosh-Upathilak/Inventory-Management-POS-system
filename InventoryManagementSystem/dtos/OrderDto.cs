using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Dtos
{
    public class OrderDto
    {
        public int orderId { get; set; }
        [Required]
        public DateTime orderDate { get; set; }
        [Required]
        public int productId { get; set; }
        [Required]
        public int customerId { get; set; }
        [Required]
        public string productName { get; set; }
        [Required]
        public int qty { get; set; }
        [Required]
        public int price { get; set; }
        [Required]
        public int tPrice { get; set; }
    }
}
