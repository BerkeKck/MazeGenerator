using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10_Interface.Personeller.Abstract;

namespace _10_Interface.Personeller.Concrete
{
    public class ITMudur : Mudur, IITPersonel
    {
        public void BilgisayarArizasiCoz()
        {
            throw new NotImplementedException();
        }

        public void KodYaz()
        {
            throw new NotImplementedException();
        }

        public void NetworkProblemiCoz()
        {
            throw new NotImplementedException();
        }

        public void WebSitesiTasarla()
        {
            throw new NotImplementedException();
        }
    }
}
