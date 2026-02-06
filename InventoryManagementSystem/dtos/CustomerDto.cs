using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Dtos
{
    public class CustomerDto
    {
        public int customerId { get; set; }
        [Required]
        public string customerName { get; set; }
        [Required]
        public string customerPhone { get; set; }
    }
}
