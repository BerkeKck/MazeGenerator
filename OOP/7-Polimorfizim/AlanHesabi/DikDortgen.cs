using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Polimorfizim.AlanHesabi
{
    public  class DikDortgen :Sekil
    {

        // Property 'lerde ovveride edilebilir
        public override int KisaKenar { 
            get => base.KisaKenar;
           set
           { 

                if (value > 0)
                {
                    base.KisaKenar = value;
                }
            }
        
        }

        public string Test()
        {
            return "Test";
        }

        public string Test2 => "Test2";
        public override double AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        }

        public override double CevreHesapla()
        {
            return 2*(KisaKenar + UzunKenar);
        }
    }
}
