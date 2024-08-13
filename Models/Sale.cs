using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalPrice { get; set; }
        public User User { get; set; }

        public static void CreateModel(ModelBuilder model)
        {
            model.Entity<Sale>(e =>
            {
                e.HasKey(e => e.Id);
                e.Property(e => e.Id).ValueGeneratedOnAdd();
                e.Property(e => e.SaleDate).HasColumnType("date").IsRequired();
                e.Property(e => e.TotalPrice).HasColumnType("decimal(10,2)").IsRequired();
                e.HasOne(e => e.User);
            });
        }
    }
}
