using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Kalitim.Okul
{
    public class Ogretmen:Kisi
    {
       

        public string Brans { get; set; }
       
        //40 saatten fazla olamaz.
        public int GirdigiDersSaati { get; set; }

        //Maas Asgari ucretten asagi olmayacak
        public decimal Maas { get; set; }

        // 24 yasindan kucuk olmamasi lazim
        public DateTime DogumTarihi { get; set; }
    }
}
