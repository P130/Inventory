using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace InventorySystem.Models
{
    public class Catagory
    {
        [Key]
        [Required]
        [DisplayName("Catagory Id")]
        public int Category_Id { get; set; }
        [Required]
        [DisplayName("Catagory Name")]
        public string Category_Name { get; set; }
    }
}
