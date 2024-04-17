using System.Reflection.Metadata;
using Bogus;
namespace _12_GenelTekrar
{
   
    internal class Program
    {
        static int not3=4;
        static void Main(string[] args)
        {
            #region Degisken Tanimlamalari

            //sayisal tipler 1. tamsayilar
            int sayi1;//4 byte
            Int32 sayi2;//int
            Int64 sayi3;//long
            Int128 sayi4;
            long sayi5;
            ulong sayi6;
            double sayi7;

            //2. noktali ifadeler
            float sayi8 = 12.3f;
            double sayi9=12.3;
            decimal sayi10=12.3m;


            //string ifadeler
            string cumle = "qweqweqwsdvşj ipasdfjiaosdf";
            char ch = 'a'; //Tek karakter tanimlamasi icin 

            //Tarih DEgiskenleri
            DateTime dateTime = DateTime.Now;
            DateOnly dateOnly = new DateOnly();
            TimeOnly timeOnly = new TimeOnly();

            // Mantiksal veri tipi 
            bool bl = true;
            #endregion
            #region Scope
            int not1=5, not2;
            {
                string isim = "Ali";
                Console.WriteLine(not3);
                Console.WriteLine(not1);
            }
            //Console.WriteLine(isim);

            #endregion
            #region if ve switch case
            #region if
            // scope {}
            // if bloklari duruma gore scope calistiran yapilardir
            int a = 5;
            if (a == 1) //Eger kosul dogru ise ilk scope calisir
            {
                //true oldugunda burasi calisir
            }
            else
            {
                //false oldugunda burasi calisir
            }


            if (a == 1) //Eger kosul dogru ise ilk scope calisir
            {
                //true oldugunda burasi calisir
            }
            else if (a == 2)
            {
                //false oldugunda burasi calisir
            }
            else if (a == 3)
            {

            }
            else
            {
                // Yukaridakilerin hic birisi degilse
            }

            #region Yanlis kullanim ornekleri
            //if (a == 1) ;
            //{

            //}
            //if (a == 1) //Eger kosul dogru ise ilk scope calisir
            //{
            //    //true oldugunda burasi calisir
            //}
            //else 
            //{
            //    //false oldugunda burasi calisir
            //}
            //else if (a == 3)
            //{

            //} 

            #region ternary if kullanimi
            //int time = 20;
            //string result =(time < 18) ?  "Good day." : "Good evening.";

            //if (time < 18)
            //{
            //    result = "Good Day";
            //}
            //else
            //{
            //    result = "Good evening";
            //}
            //Console.WriteLine(result);
            int x = 5;
            int y = 3;
            Console.WriteLine(x > y);
            #endregion
            #endregion

            #endregion
            #region Switch Case
            //int day = 14;
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        {
            //            Console.WriteLine("Thursday");
            //            Console.WriteLine("Carsamba");
            //        }
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Looking forward to the Weekend.");
            //        break;
            //}
            #endregion
            #endregion

            #region While loop
            //While döngüsü koşul doğru olduğu sürece işlemleri gerçekleştiren bir döngü tipidir.
            //Eğer koşul yanlış işe döngü tamamlanır.
            //for döngüsünde olduğu gibi, bir koşul sağlandığı sürece dönmeye devam eder.
            //Koşul yanlış(false) sonucunu verdiği zaman ise sonlandırılır.
            // while(statment)
            // {
            // }

            // Ekrandan sifir saysi girilen kadar toplama islemi yapan dongu

            //int sayi = 1;
            //int toplam = 0;
            //while (sayi != 0)
            //{
            //    Console.WriteLine("Bir sayi giriniz");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //   toplam+=sayi;
            //}
            #endregion

            #region do-while
            // for ve while döngülerinde koşul, döngü başlamadan önce kontrol edilir. 
            // do while döngüsünde ise, bu kontrol her döngüden sonra gerçekleştirilir. 
            // Operasyon mantığında do while döngüsü, koşul ne olursa olsun en az bir kere 
            //çalıştırılır.

            // Ekrandan sifir saysi girilen kadar toplama islemi yapan dongu


            //int sayi = 0;
            //int toplam = 0;
            //do
            //{
            //    Console.WriteLine("Bir sayi giriniz");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayi;
            //} while (sayi!=0);
            #endregion
            #region For Dongusu
            //for : bir sayac aracılığı ile adet belirtecek şekilde kodların çalışmasını sağlar. (kaç defa yapılacak)

            //for (int i = 0//kendi sayacının deklarasyonu
            //    ; i < length //kosul
            //    ; i++//sayac değişikliği)
            //{

            //}

            //1-100 arasindaki sayilari bastiralim

            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //100-1 kadar sayiari yazdiralim
            //for (int i = 100; i >=0; i--)
            //{
            //    Console.WriteLine(i);
            //}


            #region Break Continue

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i ==2)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Test");
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 4)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}


            #endregion
            #endregion

            #region Tip Donusumleri
            // Tip Donusumleri :
            /*
                 Veri Tipleri :
                 1- Sayisal Tipler : Int16,Int32,Int64 ,noktali sayisal deger icin float ,double  ve decimal veri tipleri kullanilir
                 2- String ve char tipinde olan veri tipleri var. String , char => sadece 1 adet karakter tutar. 1 byte'tir
                 3- DateTime veri tipimiz var. 

                  1Byte : 8 bit olusur => 0001 0101 => Eger sayisal olarak bu bitler ele alinacaksa 
                    her bir bitin 2'nin kuvveti olacak sekilde hesaplama yapilir. Bu durumda 0011 0101 => 53 olarak hesaplanir. 

             */

            //string str = "";
            //str = Console.ReadLine();//Ekrandan okutulan deger 

            ////int sayi = Convert.ToInt32(str);
            ////DateTime trh = Convert.ToDateTime(str);
            ////bool donustumu = Convert.ToBoolean(str);
            //int result = 0;
            //bool donustumu = false;
            //donustumu = int.TryParse(str, out result);
            //if (donustumu)
            //{
            //    Console.WriteLine($"Donusum Basarili Sekilde Oldu {result}");
            //}
            //else
            //{
            //    Console.WriteLine("Basarisiz oldu");
            //}

            #endregion

            #region Try-Catch
            string str = "";
            //Console.WriteLine("Bir sayi Giriniz:");
            //str = Console.ReadLine();
            //int result = int.Parse(str);
            //try
            //{
            //    //Database Baglantisi ,Web'de yapilacak herhangi bir islem baglanti hatasina neden olabilecegi gibi 
            //    // Herhangi bir cevirme islemide hataya sebep olabilir
            //    //Hata nedir
            //    //uygulamanın çalışmasına engel olan yada istenililen çıktıların dışında değerler ile karşılaşılan her duruma hata denir.
            //    //Hata çeşitleri nelerdir

            //    //1- Derleme Hataları
            //    // int a = (long)4;

            //    //2-Runtime hataları(exception=>tryCatch)
            //    Console.WriteLine("Bir sayi Giriniz:");
            //    str = Console.ReadLine();
            //    int result = int.Parse(str);

            //    decimal d1 = decimal.Parse(str);
            //    double d2 = double.Parse(str);
            //    var d3 = float.Parse(str);
            //    var d4 = DateTime.Parse(str);

            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("Cok buyuk Sayi girdiniz:" + ex.Message);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Sifira Bolme hatasi:" + ex.Message);
            //}

            //catch (FormatException ex)
            //{

            //    Console.WriteLine("Duzgun formatta sayi giriniz :" + ex.Message);
            //} 
            #endregion

            #region ForEach
            Faker faker = new Faker("tr");
            List<string> sehirler = new List<string>();

            for (int i = 0; i < 50; i++)
            {
                sehirler.Add(faker.Address.City());
            }
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Hello Mars");
            //}

            //// ForEach Mutlaka bir Veri setine ihtiyac duyar. 
            //// Diger donguler gibi kurgulanamaz. 
            //foreach (string sehir in sehirler)
            //{
            //    Console.WriteLine(sehir);
            //}

            //int[] sayilar = { 3, 5, 2, 6, 1, 9, 7, 8, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            //string cumle1 = "Bugun gunlerden çarsamba";
            //foreach (var item in cumle1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Donguler
            // 1- 1-50 arasindaki cift ve tek saylarin toplami nedir ?
            int ciftToplam=0, tekToplam = 0;
            for (int i = 1; i <= 50; i++)
            {
                //if (i % 2 == 0)
                //{
                //    ciftToplam += i;
                //}
                //else
                //{
                //    tekToplam += i;
                //}
                if (i % 2 != 0)
                {
                    tekToplam += i;
                }
                else
                {
                    ciftToplam += i;
                }
            }
            /*  Escape (Kaçiş ) Karakterleri
             *  \' – Output a Single quote.
                \” – Output a double quote.
                \ – Output a Backslash.
                \n – Insert a newline.
                \r – Insert a carriage-return.
                \t – Insert a tab.
                \0 – Insert a null character.
                \b – Insert a backspace.
             * 
             * 
             * 
             */
            Console.WriteLine($"Cift Toplam:{ciftToplam} \ntek toplam :{tekToplam}");


            //int sayac = 0;
            //Console.WriteLine(" \"Izmir\" "); //çift tirnak için escape karakter
            //Console.WriteLine("\tId\tSehir");

            //foreach (var sehir in sehirler)
            //{
            //    sayac++;
            //    Console.WriteLine($"\t{sayac}\t{sehir}");
            //}
            #endregion

            // ilk 100 sayi arasinda hem 3 hemde 7 ye bolubebilen sayilar hangileridir
            #region Aleyna
            //Aleyna
            //int sayi = 0;
            //for (sayi = 1; sayi <= 100; sayi++)
            //{
            //    if (sayi % 3 == 0 && sayi % 7 == 0)
            //    {
            //        Console.WriteLine(sayi);
            //    }
            //} 
            #endregion
            #region Eylem
            //int sayac = 0;
            //int toplam = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0 && i % 7 == 0)

            //    {
            //        Console.WriteLine(i);
            //        sayac++;
            //        toplam = toplam + i;

            //    }


            //}
            //Console.WriteLine("3'e ve 7'ye tam bölünen sayı adeti = " + sayac);
            //Console.ReadLine();
            #endregion
            #region Sukru
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion
            Console.WriteLine("Hello, World!");
            }
        }
    }

