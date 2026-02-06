using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class UserDto
    {
        [MaxLength(50)]
        [Required]
        public string username {  get; set; }
        [MaxLength(50)]
        [Required]
        public string fullname { get; set; }
        [MaxLength(50)]
        [Required]
        public string password { get; set; }
        [MaxLength(10)]
        [Required]
        public string phone { get; set; }

    }
}
