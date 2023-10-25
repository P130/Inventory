using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InventorySystem.Models;

namespace InventrySystem.Data
{
    public class InventrySystemContext : DbContext
    {
        public InventrySystemContext (DbContextOptions<InventrySystemContext> options)
            : base(options)
        {
        }

        public DbSet<InventorySystem.Models.Brand> Brand { get; set; }

        public DbSet<InventorySystem.Models.Catagory> Catagory { get; set; }

        public DbSet<InventorySystem.Models.Customer> Customer { get; set; }

        public DbSet<InventorySystem.Models.Order> Order { get; set; }

        public DbSet<InventorySystem.Models.OrderItem> OrderItem { get; set; }

        public DbSet<InventorySystem.Models.Product> Product { get; set; }

        public DbSet<InventorySystem.Models.Staff> Staff { get; set; }

        public DbSet<InventorySystem.Models.Stock> Stock { get; set; }

        public DbSet<InventorySystem.Models.Store> Store { get; set; }
    }
}
