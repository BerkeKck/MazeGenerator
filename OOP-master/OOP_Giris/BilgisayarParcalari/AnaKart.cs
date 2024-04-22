using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Giris.BilgisayarParcalari
{
    public enum RamTipi:byte
    {
        DDR1=1,
        DDR2=2, 
        DDR3=3, 
        DDR4=4, 
        DDR5=5, 
        DDR6=6
    }

    public class AnaKart
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public RamTipi RamTipi { get; set; }
        public bool Wifi { get; set; }
      

        public float Fiyat { get; set; }
    }
}
