using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier.Models
{
    public class User
    {
        public int Id { get; set; }
        public string User_Type { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public static void CreateModel(ModelBuilder model)
        {
            model.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.User_Type).HasColumnType("varchar(50)").IsRequired();
                entity.Property(e => e.Name).HasColumnType("varchar(50)").IsRequired();
                entity.Property(e => e.Address).HasColumnType("varchar(150)").IsRequired();
                entity.Property(e => e.PhoneNumber).HasColumnType("varchar(50)").IsRequired();
                entity.Property(e => e.Username).HasColumnType("varchar(50)").IsRequired();
                entity.Property(e => e.Password).HasColumnType("varchar(50)");
            });

        }
    }
}
