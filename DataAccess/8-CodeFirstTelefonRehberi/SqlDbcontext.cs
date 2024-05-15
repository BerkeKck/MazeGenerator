using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_CodeFirstTelefonRehberi
{
    public class SqlDbcontext : DbContext
    {
        public DbSet<Kisi> Kisiler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Server=127.0.0.1;Database=Istka2024Kutuphane;User Id=postgres;Password=qweasd");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kisi>().HasKey(p => p.Id);
            modelBuilder.Entity<Kisi>().HasMany(p => p.Emailler).WithOne(p => p.Kisi).HasForeignKey(p => p.KisiId);

            modelBuilder.Entity<Kisi>().HasMany(p => p.Telefonlar).WithOne(p => p.Kisi).HasForeignKey(p => p.KisiId);

        }

    }
}
