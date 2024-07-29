using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public static void CreateModel(ModelBuilder model)
        {
            model.Entity<Product>(e =>
            {
                e.HasKey(e => e.Id);
                e.Property(e => e.Id).ValueGeneratedOnAdd();
                e.Property(e => e.Name).HasColumnType("varchar(50)").IsRequired();
                e.Property(e => e.Price).HasColumnType("decimal(10,2)").IsRequired();
                e.Property(e => e.Stock).HasColumnType("int").IsRequired();
            });
        }

    }
}
