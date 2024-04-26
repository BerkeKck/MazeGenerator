using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Kalitim.Okul
{
    public class Personel :Kisi
    {
        //Maas Asgari ucretten asagi olmayacak.
        // 17001 Tl
        public decimal Maas { get; set; }

        public string Departman { get; set; }
    }
}
