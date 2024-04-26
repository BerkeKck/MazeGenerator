using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Constructor.Personeller
{
    public class Kisi : Adres
    {
        public string GobekAdi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Gsm { get; set; }
        public string Email { get; set; }
        public bool Cinsiyet { get; set; }
        //public Adres Adress { get; set; }

        public Kisi(string ad, string soyad, bool cinsiyet)
        {

            if (!string.IsNullOrEmpty(ad) && !string.IsNullOrEmpty(soyad))
            {
                Ad = ad;
                Soyad = soyad;
                Cinsiyet = cinsiyet;

                Sehir = "Istanbul";
                Ulke = "Turkiye";
                Ilce = "Kadikoy";
            }
            else
            {
                throw new Exception("Isim Ve Soy isim alanlari Boş Gecilemez");
            }
           
            //Eger Adres Class'i Kalitim Vermeseydi Property olarak tanimlanabilirdi.
            //Boyle bir durumda Bu proerty'i new lemek gerekir
            //Adress = new Adres { Sehir = "Istanbul", Ilce = "Kadikoy", Ulke = "Turkiye" };
        }

        public string KisiBilgileriVer()
        {
            return $"Adi:{Ad}\nSoyadi:{Soyad}\nSehir:{Sehir}";
        }


        // object veri tipinden gelen ToString() Metodunu ezip Yerine kendi
        // kodlarimi calistirmasini istiyorum
        public override string ToString()
        {
            return $"Adi:{Ad}\nSoyadi:{Soyad}\nSehir:{Sehir}";
        }
    }
}
