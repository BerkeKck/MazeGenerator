using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Polimorfizim.AlanHesabi
{
    public class Sekil    
    {  

        // Property arka tarafta get ve set metodlari olan ozel yapilar
        public virtual int YariCap { get; set; }
        public virtual int KisaKenar { get; set; }
        public virtual int UzunKenar { get; set; }
        public virtual double AlanHesapla()
        {
            return 0;
        }
        public virtual double CevreHesapla()
        {
            return 0;
        }
    }
}
