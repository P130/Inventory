using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace InventorySystem.Models
{
    public class Order
    {
        [Key]
        [Required]
        public int Order_Id { get; set; }
        [Required]
        [DisplayName("Customer Id")]
        public int Cust_Id { get; set; }
        [Required]
        [DisplayName("Order Status")]
        public string Order_Status { get; set; }
        [Required]
        [DisplayName("Order Date")]
        public DateTime Order_Date { get; set; }
        [Required]
        [DisplayName("Required Date")]
        public DateTime Required_Date { get; set; }
        [Required]
        [DisplayName("Shipped Date")]
        public DateTime Shipped_Date { get; set; }
        [Required]
        [DisplayName("Staff Id")]
        public int Staff_Id { get; set; }
        [Required]
        [DisplayName("Store Id")]
        public int Store_Id { get; set; }



    }
}
