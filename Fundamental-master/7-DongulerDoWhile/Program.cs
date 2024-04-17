using System.Drawing;
using System.Runtime.Intrinsics.Arm;

namespace _7_DongulerDoWhile
{
    internal class Program
    {
        //DONGULER - LOOPS
        //Bir baslangic degeri olan, belirli bir kosul gerceklesene dek suren ve bu surec icerisinde bir takim islemleri tekrarli olarak gerceklestiren nesnelere "dongu" adini vermekteyiz.
        //FOR -  WHILE - DOWHILE
        static void Main(string[] args)
        {
            Random random = new Random();
            #region While Dongusu
            #region Konu Anlatimi
            //while (condition)
            //{
            //    // code block to be executed
            //}

            //1- 10 arasindaki sayilari ekrana basalim

            //int sayac = 1;
            //while (sayac <= 10)
            //{
            //    Console.WriteLine(sayac);
            //    sayac++;sayac = sayac + 1;

            //} 
            #endregion

            #region 1-50 arasindaki tek sayilari bastiralim
            //int index = 0;
            //while (index <= 50)
            //{
            //    if (index % 2 != 0)
            //    {
            //        Console.WriteLine(index);
            //    }
            //    index++;
            //}

            #endregion

            #region  Ekrandan 0 girilene kadar sayilari okutunuz . 
            // Okutulan sayilarin cift toplmalarini ekrana yaziniz
            //int sayi =0;
            //int ciftToplam = 0;

            //while (true)
            //{
            //    Console.Write("Bir sayi Giriniz:");
            //    sayi = int.Parse(Console.ReadLine());
            //    if (sayi == 0)
            //    {
            //        break;// burada donguyu kirar 
            //    }
            //    else if (sayi%2==0)
            //    {
            //        ciftToplam = ciftToplam + sayi; // ciftToplam += sayi;

            //    }



            //}
            //Console.WriteLine("Toplam :"+ciftToplam);
            #endregion

            #region 8 Haneli Rastgele sayisal bir sifre uretelim
            //string sifre = "";
            //int index = 1;
            //while (index <= 8)
            //{
            //    sifre = sifre + random.Next(0, 10);
            //    index++;
            //}
            //Console.WriteLine(sifre);
            #region Erol Aydemir Yorumu
            //int sifre;
            //while (true)
            //{
            //    Console.Write("Üretmek için 1, Çıkmak İçin 0:");
            //    string i = Console.ReadLine();
            //    if (i == "1")
            //    {
            //        sifre = random.Next(0000000, 99999999);
            //        Console.WriteLine(sifre);
            //    }
            //    else if (i == "0")
            //    {
            //        Console.WriteLine("Çıkıldı.");
            //        break;
            //    }
            //} 
            #endregion
            #region Muhammed Talha 

            //int index = 0;
            //string sayis = "";

            //while (index < 8)
            //{
            //    if (index == 0)
            //    {
            //        sayis += new Random().Next(1, 10).ToString();
            //    }
            //    else
            //    {
            //        sayis += new Random().Next(0, 10).ToString();
            //    }

            //    index++;
            //}

            //Console.WriteLine(int.Parse(sayis));
            #endregion
            #region Omer Faruk 

            //int sayac = 1;
            //int c;
            //Random rnd = new Random();

            //while (sayac <= 8)
            //{
            //    c = rnd.Next(0, 10);
            //    Console.Write(c);
            //    sayac++;
            //}


            #endregion
            #endregion
            #region Karakterli Sifre Uretme
            //char ch ;
            //Console.WriteLine(char.ConvertFromUtf32(100));
            // Ascii Tabloda 48-57 arasi sayisal alan
            // 65-90 arasi Buyuk Harf ile Alfabe
            // 97 ile 122 arasi kucuk hafler


            // 33- 127 arasinda random bir deger olusturlmasi yeterli olacaktir

            //string sifre = "";
            //int index = 1;
            //Console.WriteLine("Uretilecek şifre uzunlugu:");
            //int uzunluk =int.Parse(Console.ReadLine());
            //while (index <= uzunluk)
            //{
            //    sifre = sifre + char.ConvertFromUtf32(random.Next(33, 127));
            //    index++;
            //}
            //Console.WriteLine(sifre); 
            #endregion
            #region 1-100 arasindaki sayilarin cift toplamlari ile 
            // Tek toplamlari arasindaki farkin karesi nedir?
            // int ciftToplam = 0;
            // int tekToplam = 0;
            // int counter = 1;
            // while (counter <= 100)
            // {
            //     if (counter % 2 == 1)
            //     {
            //         tekToplam += counter;
            //     }
            //     else if (counter % 2 == 0)
            //     {
            //         ciftToplam += counter;
            //     }
            //     counter++;
            // }
            //Console.WriteLine($"{(tekToplam - ciftToplam) * (tekToplam - ciftToplam)}");


            #endregion
            #endregion



            #region Do-While Dongusu
            #region Konu Anlatimi
            /*  do-while dongusunun while'den farki 
                   Donguye en az bir kere girer.
             kullanimi 
             do
             {

                 // yapilacak isler...

             }while(kosul)


              */
            #endregion

            #region Anket
            //Bir urun icin yapilan ankette begenen,begenmeyen ve kararsiz kalanlarin sayisini 
            // ve toplam musteri sayisini ekrana yazdiran program. "Baska musteri varmi ?" sorusuna hayir(H/h) demedigi surece ankete devam edilsin.
            //int begenenSayisi=0, begenmeyenSayisi=0, kararsizSayisi = 0,sayac=0;
            //string cevap = "";
            //do
            //{
            //    sayac++;
            //    Console.WriteLine("Urunu Begendinizmi [ E / H / K ]?");
            //    string str = Console.ReadLine();
            //    switch (str)
            //    {

            //        case "e":
            //        case "E":
            //            begenenSayisi=begenenSayisi+1;
            //            break;
            //        case "h":
            //        case "H":
            //            begenmeyenSayisi = begenmeyenSayisi + 1;
            //            break;
            //        case "k":
            //        case "K":
            //            kararsizSayisi = kararsizSayisi + 1;
            //            break;
            //        default:
            //            Console.WriteLine("Yanlis cevap verdiniz .Lutfen yeni giris yapiniz [ E / H / K ]");
            //            break;
            //    }


            //    Console.WriteLine("Baska Anket Yapilacakmi [E/H]");
            //    cevap = Console.ReadLine();
            //    //if (cevap != "E" && cevap != "e")
            //    //{
            //    //    break;
            //    //}
            //} while (cevap == "E" || cevap == "e");
            //#endregion

            //Console.WriteLine("Begenen Sayisi :" + begenenSayisi);
            //Console.WriteLine("Begenmeyen Sayisi :" + begenmeyenSayisi);
            //Console.WriteLine("Kararsiz Sayisi :" + kararsizSayisi);

            //Console.WriteLine("Yapilan Toplam Anket Sayisi:"+sayac);

            #endregion

            #region Kullanicini girdigi kelimeyi kullanicinin istedigi kadar tekrar eden donguyu yaziniz
            string kelime;
            int tekrar, sayac = 0;
            Console.WriteLine("Bir kelime giriniz:");
            kelime = Console.ReadLine();
            Console.WriteLine("Kac kere tekrar edilsin?");
            tekrar = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine(kelime);
                sayac++;
            } while (sayac < tekrar);
            
            #endregion
            // Console.WriteLine("Hello, World!");
            #endregion
        }
    }
}
