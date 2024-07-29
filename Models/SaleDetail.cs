using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier.Models
{
    internal class SaleDetail
    {
        public int Id { get; set; }
        public Product ProductId { get; set; }
        public Sale SaleId { get; set; }
        public int Quantity { get; set; }
        public decimal SubTotalPrice { get; set; }
        public User UserId { get; set; }

        public static void CreateModel(ModelBuilder model)
        {
            model.Entity<SaleDetail>(e =>
            {
                e.HasKey(e => e.Id);
                e.Property(e => e.Id).ValueGeneratedOnAdd();
                e.HasOne(e => e.ProductId);
                e.HasOne(e => e.SaleId);
                e.Property(e => e.Quantity).HasColumnType("int").IsRequired();
                e.Property(e => e.SubTotalPrice).HasColumnType("decimal(10,2)").IsRequired();
                e.HasOne(e => e.UserId);
            });
        }
    }
}
