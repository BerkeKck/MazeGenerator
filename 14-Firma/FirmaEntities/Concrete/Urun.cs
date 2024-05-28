using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Firma.FirmaEntities.Concrete
{
    public class Urun
    {
        public int Id { get; set; }
        public string Isim { get; set; }   
        public int Fiyat { get; set; }
        public ICollection<Tedarikci> Tedarikciler { get; set; }

        public ICollection<Kategori> Kategoriler { get; set; }
    }
}
