using CompanyInfo.Entities.Models.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInfo.Entities.DbContexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Urun> MyProperty { get; set; }

        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Tedarikci> Tedarikciler { get; set; }
        public DbSet<Birim> Birim { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=IstkaCompanyInfo;
            Trusted_Connection=true;TrustServerCertificate=true");
        }

    }
}
