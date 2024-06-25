using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Polimorfizim.AlanHesabi
{
    public  class Daire :Sekil
    {

      

        public override double AlanHesapla()
        {
            return Math.PI*YariCap*YariCap;
        }

        public override double CevreHesapla()
        {
            return 2 * Math.PI*YariCap;
        }
    }
}
