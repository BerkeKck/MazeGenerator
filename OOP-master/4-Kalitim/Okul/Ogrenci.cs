using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Kalitim.Okul
{
    public class Ogrenci:Kisi
    {
        private DateTime _dogumtarihi;
        public int OgrenciNo { get; set; }
        public Sinif Sinif { get; set; }
        public string Sube { get; set; }

        // 18 yasindan buyuk ogrenci kabul etmiyoruz .
        // 14 yasindan kucuk olamaz
        public DateTime DogumTarihi 
        {
            get 
            {
                if (_dogumtarihi != null)
                {
                    return _dogumtarihi;
                }
                else
                {
                    return new DateTime(0000,1,1);
                }
               
            }
            set 
            {
                //Property uzerine atanan deger value kelimesi ile temsil edilir
                int yas = (DateTime.Now.Year - value.Year);
                if (yas > 18 || yas < 14)
                {
                    throw new Exception("Yaş 14 ile 18 arasinda olmalidir");
                }
                else
                {
                    _dogumtarihi = value;
                }
            
            } 
        }
    }
}
