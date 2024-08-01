using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier.Models
{
    public class SaleDetail
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public Sale Sale { get; set; }
        public int Quantity { get; set; }
        public decimal SubTotalPrice { get; set; }
        public User User { get; set; }

        public static void CreateModel(ModelBuilder model)
        {
            model.Entity<SaleDetail>(e =>
            {
                e.HasKey(e => e.Id);
                e.Property(e => e.Id).ValueGeneratedOnAdd();
                e.Property(e => e.Quantity).HasColumnType("int").IsRequired();
                e.Property(e => e.SubTotalPrice).HasColumnType("decimal(10,2)").IsRequired();
                e.HasOne(e => e.Product);
                e.HasOne(e => e.Sale);
                e.HasOne(e => e.User);
            });
        }
    }
}
