using _4_Kalitim.Hayvanlar;
using _4_Kalitim.Personeller;
using System.Drawing;
using _4_Kalitim.Hayvanlar.Serdar;
using _4_Kalitim.Bilgisayarlar;
using _4_Kalitim.Okul;
using _4_Kalitim.Kutuphane;
namespace _4_Kalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = new object();
            Sekreter sekreter = new Sekreter();
            sekreter.Sehir = "Istanbul";
            sekreter.Ad = "Ayse";
            sekreter.Soyad = "Kaya";
            sekreter.Sehir = "Izmir";
            //Console.WriteLine(sekreter.KisiBilgileriVer());
            Console.WriteLine(sekreter);

            Console.WriteLine(obj);

            Temp temp = new Temp(); 
            Console.WriteLine(temp);
            



            MuhasaebePersoneli muhasaebe = new MuhasaebePersoneli();
            muhasaebe.Sehir = "Izmir";


            //Karga karga = new Karga();
            //System.Drawing.Color siyah = new();

            //karga.Renkleri = new List<KnownColor>();
            //karga.Renkleri.Add(KnownColor.Blue);
            //karga.Renkleri.Add(KnownColor.Black);

            //baliklar hamsi = new baliklar();
            //hamsi.omurga = OmurgaT.Omurgali;
            //hamsi.UremeTuru = UremeT.yumurtlama;
            //hamsi.BeslenmeTuru = BeslenmeT.Herbivor;
            //hamsi.hucreSayisi = hucreSayisi.CokHucreli;

            //Ogrenci ali = new Ogrenci();

            //try
            //{
            //    ali.DogumTarihi = new DateTime(2000, 1, 1);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("Hata:"+ex.Message);
            //}
            //DogumTarihi Property'si Set Edilir
          
            //ali._dogumtarihi = new DateTime(1990, 1, 1);
            
            //DogumTarihi Property'si Get Edilir
            //DateTime dogumtarihi = ali.DogumTarihi;

            //Console.WriteLine(dogumtarihi);


            Yazar yasarKemal = new Yazar();
            
          


            Console.WriteLine("Hello, World!");
        }
    }
}
