using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Kalitim.Hayvanlar.Genel
{
    public enum SolunumTipi
    {
        Solungac,
        Akciger
    }

    public class Baliklar :BaseHayvan
    {
        public SolunumTipi SolunumTipi { get; set; }

        // Yetenekleri  : Yuzebilir , Ucabilir , Beslenme 
        public void Yumurtlayabilir()
        {

        }
    }
}
