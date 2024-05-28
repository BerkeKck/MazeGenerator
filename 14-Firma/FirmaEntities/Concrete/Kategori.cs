using _14_Firma.FirmaEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Firma.FirmaEntities.Concrete
{
    public class Kategori:BaseEntity
    {
        public string Elektronik { get; set; }
        public string BeyazEsya { get; set; }
        public string Bilgisayar { get; set; }
        public string Buzdolabi { get; set; }
        public string NoteBook { get; set; }
        public ICollection<Urun> Urunler { get; set; }
    }
}
