using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Polimorfizim.AlanHesabi
{
    public class Kare :Sekil
    {
        public override double AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        }

        public override double CevreHesapla()
        {
            return 2 * (KisaKenar + UzunKenar);
        }
    }
}
