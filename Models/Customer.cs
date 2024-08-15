using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string MemberType { get; set; }
        
        
        public static void CreateModel(ModelBuilder model)
        {
            model.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Name).HasColumnType("varchar(50)").IsRequired();
                entity.Property(e => e.Address).HasColumnType("varchar(150)").IsRequired();
                entity.Property(e => e.PhoneNumber).HasColumnType("varchar(50)").IsRequired();
                entity.Property(e => e.MemberType).HasColumnType("varchar(50)").IsRequired();
            });
        }
    }
}
