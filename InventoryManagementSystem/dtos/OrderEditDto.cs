using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Dtos
{
    public class OrderEditDto
    {
        public int productId { get; set; }
        [Required]
        [MaxLength(100)]
        public string productName { get; set; }
        [Required]
        public int productQuantity { get; set; }
        [Required]
        public int productPrice { get; set; }
        [Required]
        [MaxLength(100)]
        public string productDescription { get; set; }
        [Required]
        public string productCategory { get; set; }
        [Required]
        public int orderQuantity { get; set; }
        [Required]
        public DateTime orderDate { get; set; }
        [Required]
        public int orderId { get; set; }
    }
}
