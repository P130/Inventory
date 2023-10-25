using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace InventorySystem.Models
{
    public class Customer
    {
        [Key]
        [Required]
        [DisplayName("Customer Id")]
        public int Cust_Id { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string CFirst_Name { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string CLast_Name { get; set; }
        [Required]
        [DisplayName("Email")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Phone")]
        public int Phone { get; set; }
        [Required]
        [DisplayName("Street")]
        public string Street { get; set; }
        [Required]
        [DisplayName("City")]
        public string City { get; set; }
        [Required]
        [DisplayName("ZipCode")]
        public int Zipcode { get; set; }
    }
}
