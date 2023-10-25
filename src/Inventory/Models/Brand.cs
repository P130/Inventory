using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace InventorySystem.Models
{
    public class Brand
    {
        [Key]
        [Required]
        [DisplayName("Brand Id")]
        public int Brand_Id { get; set; }
        [Required]
        [DisplayName("Brand Name")]
        public string Brand_Name { get; set; }
    }
}