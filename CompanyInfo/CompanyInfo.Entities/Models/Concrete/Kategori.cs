using CompanyInfo.Entities.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInfo.Entities.Models.Concrete
{
    public class Kategori :BaseEntity
    {
        //Burada atananlar databasede kolon olur
        public string KategoriAdi  { get; set; }

        public string? Aciklama { get; set; } 
        public ICollection <Urun> Urunler { get; set; }

    }
}
