using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Constructor.Personeller
{
    public class MuhasaebePersoneli :Personel
    {
        public MuhasaebePersoneli(string ad, string soyad, bool cinsiyet) : base(ad, soyad, cinsiyet)
        {
            
        }
    }
}
