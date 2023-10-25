using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace InventorySystem.Models
{
    public class Product
    {
        [Key]
        [Required]
        [DisplayName("Product Id")]
        public int Product_Id { get; set; }
        [Required]
        [DisplayName("Product Name")]
        public string Product_Name { get; set; }
        [Required]
        [DisplayName("Brand Id")]
        public int Brand_Id { get; set; }
        [Required]
        [DisplayName("Catagory Id")]
        public int Category_Id { get; set; }
        [Required]
        [DisplayName("Model Year")]
        public int Model_Year { get; set; }
        [Required]
        [DisplayName("List Price")]
        public int List_Price { get; set; }
    }
}
