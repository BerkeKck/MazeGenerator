using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10_Interface.Personeller.Abstract;

namespace _10_Interface.Personeller.Concrete
{
    public class Mudur : Personel, IPersonel, IInsanKaynaklari
    {
        public void ElamanGorusmesiYap()
        {
            throw new NotImplementedException();
        }

        public void IsIlaniVer()
        {
            throw new NotImplementedException();
        }

        public void MaasHesapla()
        {
            throw new NotImplementedException();
        }

        public void PerformansDegerlemesiYap()
        {
            throw new NotImplementedException();
        }
    }
}
