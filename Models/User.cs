using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Tipe_User { get; set; }
        public string Name { get; set; }
        public string Alamat { get; set; }
        public string NoTelp { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public static void CreateModel(ModelBuilder model)
        {
            model.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Tipe_User).HasColumnType("varchar(50)").IsRequired();
                entity.Property(e => e.Name).HasColumnType("varchar(50)").IsRequired();
                entity.Property(e => e.Alamat).HasColumnType("varchar(150)").IsRequired();
                entity.Property(e => e.NoTelp).HasColumnType("varchar(50)").IsRequired();
                entity.Property(e => e.Username).HasColumnType("varchar(50)").IsRequired();
                entity.Property(e => e.Password).HasColumnType("varchar(50)");
            });

        }
    }
}
