using Cashier.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier
{
    internal class Database : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetail> SaleDetails { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Server=localhost;Database=Cashier;Username=postgres;Password=123;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Product.CreateModel(modelBuilder);
            Sale.CreateModel(modelBuilder);
            SaleDetail.CreateModel(modelBuilder);
            User.CreateModel(modelBuilder);
            Customer.CreateModel(modelBuilder);
        }
    }
}
