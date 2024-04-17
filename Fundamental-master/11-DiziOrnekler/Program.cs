namespace _11_DiziOrnekler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1-100 arasinda 50 adet sayi uretip br diziye atalim  
            //int[] sayilar = new int[50];
            Random rnd = new Random();
            //for (int i = 0; i < sayilar.Length; i++) 
            //{ 
            //    sayilar[i] = 1+ rnd.Next(100); 
            //}

            #endregion
            #region Dizi Boyutunu ekrandan alma
            //int elemanSayisi = 0;
            //Console.WriteLine("Dizi eleman Sayisini Giriniz");
            //elemanSayisi = int.Parse(Console.ReadLine());

            //int[] sayilar = new int[elemanSayisi];
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sayilar[i] = 1 + rnd.Next(100);
            //}
            #endregion

            #region Zar similasyonu 
            // Ekrandan deneme sayisini okutturalim
            //Girilen sayi kadar zar atip sonuclarini ekrandan bastiralim
            //Zar 1-6 arasinda degerleri olan küptür
            // 1-6 arasindaki degeri random olusturabilirim

            // int denemeSayisi = 0;
            // Console.WriteLine("Deneme Sayisini Giriniz:");
            // denemeSayisi =int.Parse(Console.ReadLine());

            // int gelendeger = rnd.Next(6);//0-5 arasinda bir sayi uretecektir.

            // int[] zar = { 0, 0, 0, 0, 0, 0 };
            // //Deneme sayisina gore for dongusu kurulur
            // for (int i = 0; i < denemeSayisi; i++)
            // {
            //     gelendeger = rnd.Next(6); // zar atimi burada gerceklesir
            //     zar[gelendeger] += 1;
            //     #region Amele Yontemi
            //     //switch (gelendeger) 
            //     //{
            //     //    case 0:
            //     //        zar[0] += 1;
            //     //        break;
            //     //    case 1:
            //     //        zar[1] += 1;
            //     //        break;
            //     //    case 2:
            //     //        zar[2] += 1;
            //     //        break;
            //     //    case 3:
            //     //        zar[3] += 1;
            //     //        break;
            //     //    case 4:
            //     //        zar[4] += 1;
            //     //        break;
            //     //    case 5:
            //     //        zar[5] += 1;
            //     //        break;


            //     //} 
            //     #endregion
            // }
            // // Zar dizisinin sonuclari ekrana bastirilir
            //for (int i = 0; i < zar.Length; i++)
            // {
            //     Console.WriteLine($" Gelen {i+1} sayisi : {zar[i]} Gelen Olasiligi: {zar[i]/(float)denemeSayisi}");
            // }
            #endregion

            #region Dizideki en buyuk ve en kucuk elemani bulma
            //int[] sayilar = { 1, 12, 3,9,4,21,0,49,32 };
            //int enBuyuk, enKucuk;
            //enBuyuk = 0;
            //enKucuk = sayilar[0];
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] > enBuyuk)
            //    {
            //        enBuyuk=sayilar[i];
            //    }
            //    if (enKucuk > sayilar[i])
            //    {
            //        enKucuk = sayilar[i];
            //    }
            //}
            //Console.WriteLine($" En buyuk Eleman {enBuyuk} En Kucuk Eleman {enKucuk}");

            ////kolay yolu.
            //sayilar.Max();
            //sayilar.Min();
            //Console.WriteLine($" En buyuk Eleman {sayilar.Max()} En Kucuk Eleman {sayilar.Min()}");
            #endregion

           
            

            Console.WriteLine("Hello, World!");
        }
    }
}
