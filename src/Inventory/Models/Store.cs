using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace InventorySystem.Models
{
    public class Store
    {
        [Key]
        [Required]
        [DisplayName("Store Id")]
        public int Store_Id { get; set; }
        [Required]
        [DisplayName("Store Name")]
        public string Store_Name { get; set; }
        [Required]
        [DisplayName("Phone")]
        public int Phone { get; set; }
        [Required]
        [DisplayName("Email")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Street")]
        public string Street { get; set; }
        [Required]
        [DisplayName("City")]
        public string City { get; set; }
        [Required]
        [DisplayName("State")]
        public string State { get; set; }
        [Required]
        [DisplayName("Zipcode")]
        public int Zip_Code { get; set; }
    }
}
