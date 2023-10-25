using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventorySystem.Models
{
    public class Staff
    {
        [Key]
        [Required]
        [DisplayName("Staff Id")]
        public int Staff_Id { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string First_Name { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string Last_Name { get; set; }
        [Required]
        [DisplayName("Email")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Phone")]
        public string Phone { get; set; }
        [Required]
        [DisplayName("Active")]
        public string Active { get; set; }
        [ForeignKey("Store")]
        [Required]
        [DisplayName("Store Id")]
        public int Store_Id { get; set; }
        [Required]
        [DisplayName("Manager Id")]
        public int Manager_Id { get; set; }
    }
}
