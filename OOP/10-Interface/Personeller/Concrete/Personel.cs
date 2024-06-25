using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10_Interface.Personeller.Abstract;

namespace _10_Interface.Personeller.Concrete
{
    // Bir class ancak bir class'tan kalitim alabilirken
    // Birden cok Interface'den kalitim alabilir

    public class Personel : Kisi, IPersonel
    {
        public Departman Departman { get; set; }
        public double Maas { get; set; } = 17001.0;
        public int Test { get; set; }

        public void IseZamanindaGel()
        {

        }

        public void VerilenGoreviYap()
        {

        }
    }
}
