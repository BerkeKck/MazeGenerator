using _14_Firma.FirmaEntities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _14_Firma.DbContexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Tedarikci> Tedarikciler { get; set; }
        public DbSet<Urun> Urunler { get; set; }

    }
}
