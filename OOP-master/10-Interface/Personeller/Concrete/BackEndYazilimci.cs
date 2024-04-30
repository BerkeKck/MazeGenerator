using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10_Interface.Personeller.Abstract;

namespace _10_Interface.Personeller.Concrete
{
    public class BackEndYazilimci : Personel, IBackEndYazilim
    {
        public void DatabaseTasarla()
        {
            throw new NotImplementedException();
        }

        public void DebugYap()
        {
            throw new NotImplementedException();
        }

        public void YaizlimGuncelle()
        {
            throw new NotImplementedException();
        }
    }
}
