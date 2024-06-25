using System.Threading.Channels;

namespace _1_FirstConsole
{ 
   
    internal class Program
    {
        /*
         * 
         * Main Metodu olmazsa program calismaz. 
         * Isletim sistemleri Calistirilacak programda mutlaka Main Metodunu arar.
         * 
         * 
         * 
         * Kisa Yollar :
         * 
         *      ctrl + shift + b => programi derler
         *      
         *      ctrl + k + c => secilen yeri yorum satiri yapar
         *      
         *      ctrl + k + u => secilen yeri yorum satirindan cikartir
         *      
         *      ctrl + k + s => Region Olusturmaya yarar
         */

        static void Main(string[] args)
        {

            // DEgisken Tanimlari
            // veritipi <degisken ismi>;
            #region Giris
            //string kelime1, kelime2;
            //int sayi1, sayi2;


            //// Bu bir yorum Satiridir
            //Console.BackgroundColor = ConsoleColor.Magenta;
            //Console.ForegroundColor = ConsoleColor.Yellow;

            //Console.WriteLine("Bir kelime giriniz :");
            //kelime1 = Console.ReadLine();
            //Console.WriteLine("Baska bir  kelime giriniz :");
            //kelime2 = Console.ReadLine();

            ////Girilen Kelimeleri ekrana basalim
            //Console.WriteLine("Girilen Kelimeler " + kelime1 + " " + kelime2);


            ////Ekrani Beklemtmek icin yazildi
            //Console.ReadLine(); 
            #endregion
            #region Tamsayi degisken tipleri
            /* Tam Sayi Veri Tipleri
            * 
            * byte : Uzunluğu 1 byte’tır, 0 ile 255 arasında değer alır.

           sbyte : Uzunluğu 1 byte’tır, -128 ile 127 arasında değer alır.

           short : Uzunluğu 2 byte’tır, -32768 ile 32767 arasında değer alır.

           ushort : Uzunlupu 2 byte’tır, 0 ile 65535 arasında değer alır.

           int : Uzunluğu 4 byte’tır, -2.147.483.648 ile 2.147.483.648 arasında değer alır.

           uint : Uzunluğu 4 byte’tır, 0 ile 4.294.967.295 arasında değer alır.

           long : Uzunluğu 8 byte’tır, -10^20 ile 10^20 arasında değer alır.

           ulong : Uzunluğu 8 byte’tır, 0 ile 2 x 10^20 arasında değer alır.
        */



            #endregion


            #region Degisken Tanimlama Kurallari
            /* sayi ile baslayamaz
                 *  _ haric özel karakter iceremez
                 *  255 karakterden buyuk olamaz
                 *  Kelimeler arasi bosluk birakilamaz
                 *  Microsoft PascalCase kullanilir
            */
            #endregion

            #region Iki  sayinin toplami  
            // Asagidaki degisken tanimlamalari aynidir
            //string input1, input2;
            //int sayi1;
            //Int32 sayi2 = 0; // kisa keyword int

            //Int64 sayi3 = 0; // Kisa keyword long 
            //long sayi4 = 0;

            //Console.WriteLine("Birinci Sayiyi Giriniz:");
            //input1 = Console.ReadLine();
            ////Girilen ifadeyi int veri tipine ceverimek icin  
            //// 1. Yol

            //sayi1 = Convert.ToInt32(input1);
            //Console.WriteLine("Ikinci  Sayiyi Giriniz:");
            //input2 = Console.ReadLine();

            ////Girilen ifadeyi int veri tipine ceverimek icin  
            //// 2. Yol
            //sayi2 = int.Parse(input2);

            //Console.WriteLine("Girilen sayilarin Toplami:" + (sayi1 + sayi2)); // Burasi ise toplama islemi yapar
            //Console.WriteLine("Girilen sayilarin Toplami:" + (input1 + input2)); // Burasi string birlestirme işlemi yapar 
            #endregion

            #region Kesirli Sayilar 
            /* 
              * Kesirli Sayilar
              * float : Uzunluğu 4 byte’tır, 1.5 x 10-45 ile 3.4 x 1038 arasında değer alır.

                 double : Uzunluğu 8 byte’tır, 5.0 x 10-324 ile 1.7 x 10308 arasında değer alır.

                 decimal : Uzunluğu 12 byte’tır, ±1.0 x 10-28 ile ±7.9 x 1028 arasında değer alır.
              */
            // Asagidaki tanimlama hata verecektir
            //float sayiFloat = 12.5;
            //decimal sayiDecimal = 12.5;

            // Eger noktali bir sayi atamasi yapiliyorsa default olarak c# double kabul eder
            double sayiDouble = 12.5;


            //Duzeltilmis hali 

            float sayiFloat = 12.5f;
            decimal sayiDecimal = 12.5m;
            #endregion

            #region String Degiskenler 
            /*
             *  string  => kelime yada cumle,paragraf artik ne atadiysaniz kabul eder
             *   
             *  char : uzunlugu 2 byte'tir. Unicode karakter temsil eder . bir karakter kabul eder
             */

            string str = "sldfjaşlskjf addfjş adfjk lakdjsf .akljdf alsdkfj aj ";
            char c = 'a';
            #endregion

            #region Mantiksal Degisken 
            // bool veri tipi true yada false degerleri alir
            bool devammi = false;

            #endregion


            #region null ifadesi ve nullable degiskenler
            // null ascii tablodaki 0. elemandir. Ozel bir karakterdir. Hiçlik anlamina gelir

            //int a = null; Bu satir hata verecektir. Nullable degildir cunku
            //herhangi bir veri tipinin sonuna ? eklenirse nullable oldugu anlamaina gelir
            int? b = null;
            #endregion


            #region var keyword'u
            // Degisken tanimlamalarinda omce tip sonra degisken adi verilmek zorundadir.
            // var ile kullanilir ise atanan deger ne ise degisken o veri tipine burunur

            var ali = "Ali veli";
            var sayi = 12.5;

            #endregion

            #region Tarih ve Zaman Veri Tipleri
            // Tarih ve zamani beraber tutar
            DateTime dateTime = DateTime.Now;
            //Kendi belirledigimiz tarihi olusturma
            DateTime tarih = new DateTime(2000, 2, 2, 12, 15, 30);
            Console.WriteLine(dateTime);


            //DateOnly Sadece tarihi tutar . Zamani Tutmaz
            //Sql Server icersindeki karsiligi Date
            DateOnly trh = new DateOnly(2000,2,2);
            // Sadece Zamani Tutamak icin TimeOnly
            TimeOnly trh2 = new TimeOnly(12, 12, 12, 12);
            #endregion

            #region Degiskenlerde Scope Kavrami
            string cumle = "Deneme 123";


            {

                cumle = cumle + " alt scope";
                int sayi3 = 0;
                sayi3 = 5 * 4;
                {
                    Console.WriteLine(sayi3);
                    int sayi4 = 0;
                }
                // burasida hata verecektir. sayi4 ust scope icerisinde kaldi
                //Console.WriteLine(sayi4);
            }

            // Burasi Hata Verecektir .
            // Cunku Yukaridaki scope icerisinde kaldi. Ve biz sayi3 degiskenine ulasamiyoruz
            //Console.WriteLine(sayi3);
            Console.WriteLine(cumle);
            #endregion

            #region Bir siniftaki ogrencinin ozelliklerini temsilen degisken tanimlamalarini yapiniz 
            string ad, soyad, gsm, email;
            DateOnly dogumTarihi;
            long tcno = 12345678901;
            string tcnostr = "12345678901";
            bool cinsiyet;

            Int16 UnitInStock;
            short UnitsOnOrder;
            bool Discontiinued;
            #endregion
        }

       
    }


}

