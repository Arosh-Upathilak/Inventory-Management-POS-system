using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Dtos
{
    public class TempOrderDto
    {
        public int temorderId { get; set; }
        public int orderId { get; set; }
        [Required]
        public DateTime temorderDate { get; set; }
        [Required]
        public int temproductId { get; set; }
        [Required]
        public int temcustomerId { get; set; }
        [Required]
        public string temproductName { get; set; }
        [Required]
        public int temqty { get; set; }
        [Required]
        public int temprice { get; set; }
        [Required]
        public int temtPrice { get; set; }
    }
}
