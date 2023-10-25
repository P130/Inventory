using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace InventorySystem.Models
{
    public class Stock
    {
        [Key]
        [Required]
        [DisplayName("Store Id")]
        public int Store_Id { get; set; }
        [Required]
        [DisplayName("Product Id")]
        public int Product_Id { get; set; }
        [Required]
        [DisplayName("Quantity")]
        public int Quantity { get; set; }
    }
}
