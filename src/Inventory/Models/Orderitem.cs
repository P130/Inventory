using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace InventorySystem.Models
{
    public class OrderItem
    {
        [Key]
        [Required]
        [DisplayName("Order Id")]
        public int Order_Id { get; set; }
        [Required]
        [DisplayName("Item Id")]
        public int Item_Id { get; set; }
        [Required]
        [DisplayName("Product Id")]
        public int Product_Id { get; set; }
        [Required]
        [DisplayName("Quantity")]
        public int Quantity { get; set; }
        [Required]
        [DisplayName("List Price")]
        public int List_Price { get; set; }
        [Required]
        [DisplayName("Discount")]
        public int Discount { get; set; }
    }
}
