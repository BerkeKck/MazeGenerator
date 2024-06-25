using System.Collections;

namespace _13_ArraySinifiVeListeler
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            int[] sayilar = { 1, 12, 3, 9, 4, 21, 0, 49, 32 };

            // Dizileri Siralama ve diger operasyonlar icin Array Sinifi Kullanilir.

            // Siralamak isin short metodunu kullaniriz
            #region Siralama
            //Array.Sort(sayilar);

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            #endregion

            #region Dizi boyutunu arttirma Array Sinifi
            #region Manuel yontem
            //Console.WriteLine("Yeni  dizi Boyunutunu giriniz ");
            //int boyut = int.Parse(Console.ReadLine());

            //int[] yeniDizi = new int[boyut];
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    yeniDizi[i] = sayilar[i];
            //}
            //for (int i = 0; i < yeniDizi.Length; i++)
            //{
            //    Console.WriteLine(yeniDizi[i]);
            //} 
            #endregion

            Array.Resize(ref sayilar, 15);

            //foreach (var i in sayilar)
            //{
            //    Console.WriteLine(i);
            //}
            string[] sehirler = new string[4] { "İzmir", "İstanbul", "Ankara", "Eskişehir" };

            //Array.Reverse(sehirler);
            //foreach (var item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Clear(sayilar);
            //Array.Clear(sayilar, 3,2);
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region ArrayList
            ArrayList arrayList = new ArrayList();
            arrayList.Add(3);//integer
            arrayList.Add("ali");//string
            arrayList.Add(DateTime.Now);//dateTime

            for (int i = 0; i<arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            List<object> listArray = new List<object>();
            listArray.Add(12);
            listArray.Add("ali");
            listArray.Add(DateTime.Now);

            #endregion
            #region Listeler
            List<int> notlar = new List<int>();
            //notlar.Add("Ali");
            Random rnd = new Random();
            int gelendeger = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    gelendeger = rnd.Next(100);
            //    Console.WriteLine(gelendeger);
            //    notlar.Add(gelendeger);
            //}
            //notlar.Sort();

            //foreach (int i in notlar)
            //{
            //    Console.WriteLine(i);
            //}
            List<string> isimler = new List<string>();
            List<string> isimler2 = new List<string>() { "ali","veli","ayse","fatma"};
            List<string> isimler3 = new List<string> { "ali", "veli", "ayse", "fatma" };
          

            List<DateTime> dateTimes = new List<DateTime>();
            List<bool> bools = new List<bool>();
            //foreach (var item in isimler3)
            //{
            //    Console.WriteLine(item);
            //}
            //isimler3.ForEach(s =>Console.WriteLine(s));

            //Listeden eleman Cikartmakk icin Kullanilir
            //isimler3.Remove("ayse");
            //foreach (var item in isimler3)
            //{
            //    Console.WriteLine(item);
            //}

            //Belirli bir indexdeki elemani listeden atmaya yarar
            //isimler2.RemoveAt(0);
            //foreach (var item in isimler2)
            //{
            //    Console.WriteLine(item);
            //}



            #region Contains 
            //Listede belirli bir arama yapmaya yarar 
            //1. Yontem
            //bool varmi = isimler2.Contains("ayse");

            //if (isimler2.Contains("ayse"))
            //{
            //    Console.WriteLine("Ayse Listede mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Listede Yok");
            //}
            //// 2. yontem . Ternary if ile 
            //string sonuc = isimler2.Contains("ayse") ? "Ayse Listede mevcut" : "Listede Yok";

            //// 3. Yontem En Kisa Olani 
            //Console.WriteLine(isimler2.Contains("ayse") ? "Ayse Listede mevcut" : "Listede Yok");

            #endregion
            #region CopyTo
            string[] yeniIsimler = new string[10];
            //Bu tum listeyi diziye aktarir
            //isimler2.CopyTo(yeniIsimler);
            //Bu dizide 2. elemanindan itibaren listeyi kopyalar
            //isimler2.CopyTo(yeniIsimler, 2);

            //isimler2 listesinden 1. index'ten baslayarak yeniIsimler dizisinde
            //0. indexten itibren 2 adet kopyalama yapar
            isimler2.CopyTo(1, yeniIsimler, 0, 2); 
            #endregion


           
            #endregion
            Console.WriteLine("Hello, World!");
        }
    }
}
