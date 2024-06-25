namespace _10_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Bir siniftaki ogrencilerin notlarini tutacak degiskenleri tanimlayiniz.
            // Sinif 5 kisidir.. Asagidaki kod hammaliye kodudur 
            int ogrenci1, ogrenci2, ogrenci3, ogrenci4,ogrenci5 ;
            //Birden fazla aynı tipteki veriyi bir arada tutmamizi saglayan nesnelere dizi denir.
            // Dizi Opreranti [] ile gosterilir
            // tanimalasi tip[] diziAdi;
            //ogrencilerin notlari tutacak dizi tanimi 

            //1. Tanimlama Yontemi 
            int[] notlar = new int[5]; 
            Random rand = new Random();
            //Notlar Dizisini Ratgele degerlerle doldurma
            for (int i = 0; i < notlar.Length ; i++)
            {
                notlar[i]=1+ rand.Next(100);
            }

            //MAnuel Deger Atama . 3 siradaki  ogrenciye not girisi 
            notlar[2] = 60;
            //Degeri Ekrana Bastirma 
            Console.WriteLine(notlar); // Bu şekilde sadece dizini tipini verir
            Console.WriteLine(notlar[1]);//Dizideki 2. elemanin degerini verir
                                         //EĞER;
                                         //Index was outside the bounds of the array.
                                         //hatası aliyorsaniz, bilin ki dizinin boyutlarini asacak sekilde eleman ekleme cabasindasiniz... Hata nerde diye bakma, eleman ekleme yada atama islemlerine git!
           //notlar[5] = 56;// Burasi Index outside the bound hatasi verecektir.

            #region Dizilerde 2. Tanimlama Yontemi
            //Diziler tainmlandigi anda sabit boyuttadir.
            //Asagidaki tanimlama ilk deger atamasinin yapidigi bir tanimlamadir.
            int[] sayilar = new int[] { 1,2,3,4,5,6,7,8,9};
            #endregion

            #region 3. Yontem
            // Tanimlamasi VeriTipi[] DiziAdi = {dizielemanlari};
            //Asagidaki tanimlama ilk deger atamasinin yapildigi bir tanimlamadir.
            //Bu tanimlamada new keywordune gerek yoktur
            int[] sayilar2 = { 1,2,3,4,5,6};
            #endregion


            #region  Diger Veri Tipleri ile Dizi tanimlama
            string[] sehirler = { "Adana", "Ankara", "Izmir", "Istanbul" };
            char[] harfler = { 'a', 'b', 'c' };
            char[] chars = new char[10];
            bool[] tercihler = { true, false, false, false, true };
            bool[] tercih2 = new bool[10];
            DateTime[] dateTimes = { DateTime.MinValue, DateTime.MaxValue, DateTime.Now };
            #endregion


            #region Sorular
            //Kullanicilarin Adlari ve Soyadlarini tutan dizi tanimlamasi
            string[] adsoyadlar = new string[10];
            // Kullanicilarin email'lerini tutan dizi 
            string[] emailler = new string[10];
            emailler[0] = "ali@gmail.com";

            //gsm'lerini tutuan dizi
            string[] gsmler = new string[10];
            // Dogum Tarihlerini tutan dizi tanimlamasini yapiniz 
            DateTime[] dogumGunleri = new DateTime[10];
            #endregion
            Console.WriteLine("Hello, World!");
        }
    }
}
