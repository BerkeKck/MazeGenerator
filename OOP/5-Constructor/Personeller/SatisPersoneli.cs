using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Constructor.Personeller
{
    public class SatisPersoneli:Personel
    {

        // Burada Miras aldigimiz base sinifin yapici metoduna parametre gondermek icin 
        //bawe keyword'u kullanilir
        public SatisPersoneli(string ad,string soyad,bool cinsiyet):base(ad, soyad, cinsiyet) 
        {
            
        }

    }
}
