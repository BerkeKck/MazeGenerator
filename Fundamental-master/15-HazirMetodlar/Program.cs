namespace _15_HazirMetodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Math sinifinin metodlari
            //Console.WriteLine(Math.PI);

            ////Mutlak  deger alma
            //Console.WriteLine( Math.Abs(-12));

            ////Verilen ondalikli sayiyi aşağı yuvarlama 
            //Console.WriteLine(Math.Floor(12.99));
            ////Verilen ondalikli sayiyi yukari yuvarlama 
            //Console.WriteLine(Math.Ceiling(12.99));
            //Console.WriteLine("***** Round *******");

            //// Round metodu verilen ondalikli sayiyi tek ve cift olma durumuna göre yuvarlar.
            //// Eger cift ise aşağı , tek ise yukari yuvarlar
            //Console.WriteLine(Math.Round(48.50));
            //Console.WriteLine(Math.Round(49.50));

            ////Truncate metodu ondakli sayinin ondalik kismini atar

            //Console.WriteLine(Math.Truncate(48.75));

            ////Verilen sayinin Kuvvetini almak
            //Console.WriteLine("Power => "+ Math.Pow(2,4));

            ////KareKok alma
            //Console.WriteLine("KareKok =>" +Math.Sqrt(5));

            ////Küp Kök Alma 
            //Console.WriteLine("KüpKök => " + Math.Pow(8, 1/(double)3));

            //// Verilen sayini isaretini verir
            ////Eger sayi negatif ise -1 ,pozitif ise +1 verecektir
            //Console.WriteLine("Sign =>"+Math.Sign(-3));
            //Console.WriteLine("Sign =>" + Math.Sign(0));
            //Console.WriteLine("Sign =>" + Math.Sign(3));
            //// Max ,Min
            //Console.WriteLine("Max => " + Math.Max(3, 5));
            //Console.WriteLine("Min => " + Math.Min(3, Math.Min(7,8)));


            #endregion

            #region string metodlari
            // Elimizdeki metinsel degerleri manupulasyonunda hazir olarak kullanacagimiz bir cok metod .NET alt yapisinda mevcuttur

            //CompareTo > Elimizdeki string ifadeyi verilen string ile karşilastirir.

            string cumle = "Buna göre kahvehane, kafeterya, pastane, hazır yemek şirketleri dahil lokantalarda KDV oranı yüzde 8’den yüzde 10’a çıkacak.Gazino, bar, dans salonu, pavyon, taverna, birahane gibi yerlerde verilen hizmetlere uygulanan KDV oranı da yüzde 18’den yüzde 20’ye yükseltilecek.Tebliğ taslağı görüşlerin alınmasının ardından Resmi Gazete’de yayınlandığı tarihte yürürlüğe girecek.";
            #region CompareTo
            //string test = "Ali veli ayse";
            //string test2 = "Ali veli ";
            //int deger = test.CompareTo(test2);
            //string mesaj = "";
            //switch (deger)
            //{

            //    case -1:
            //        mesaj = "Verilen kelime digeri ile eşleşmemiştir";
            //        break;
            //    case 0:
            //        mesaj = "Kelimeler eşttir";
            //        break;
            //    case 1:
            //        mesaj = "Fazla kelime var";
            //        break;
            //    default:
            //        break;
            //}
            //Console.WriteLine(mesaj); 
            #endregion

            #region Contains 
            // Verilen ifade elimzdeki string icerisinde varmi yokmu ona bakar.
            // Buyuk küçük harf duyarlidir
            //string cumle = "Bugun gunlerden carsamba";
            //bool varmi = cumle.Contains("Bugun");
            //Console.WriteLine("Aradiginiz kelime " + (varmi?"Bulunmaktadir":"Bulunmamamktadir"));
            #endregion


            #region StartWith EndWith
            // Girilen deger ile elimizdeki string başlayip başlamadigini kontrol eder.
            // Geriye bool deger doner

            //string cumle = "Bugun gunlerden carsamba";
            //bool varmi = cumle.StartsWith("Bugun");
            //Console.WriteLine("Cumle Bugun ile " + (varmi ? "Başlamaktadir" : "Başlamamaktadir"));
            // varmi = cumle.EndsWith("Bugun");
            //Console.WriteLine("Cumle Bugun ile " + (varmi ? "Sonlanmaktadir" : "Sonlanmamaktadir"));
            #endregion


            #region Remove
            //1. Kullanimi 
            string yeniCumle = cumle.Remove(11);
            //Console.WriteLine(yeniCumle);
            //Console.WriteLine(cumle);

            //2. Kullanimi 
            //yeniCumle = cumle.Remove(10, 10);
            //Console.WriteLine(cumle);
            //Console.WriteLine(yeniCumle);
            #endregion

            #region Split
            //Split Elimizdeki string'i  parçalamaya yarar. 
            // Neye göre parçalayacagini ise metod'a parametre olarak geçilir.
            //var sonuc = cumle.Split(',');
            //foreach (string s in sonuc)
            //{
            //    Console.WriteLine(s);
            //}

            //Paragraftaki Cumle sayisini bulma 
            //var cumleler = cumle.Split(".");
            //foreach (var item in cumleler)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Replace
            // Verilen kelime yada karakteri elimdeki string icerisinde arar bulur ve degistirir.

            // yeniCumle = cumle.Replace("dans", "****");
            //Console.WriteLine(yeniCumle);


            //Cumle icerisinde asagidaki blacklist icerisindeki kelimeler yerine **** bastirin
            //List<string> blackList = new List<string>();
            //blackList.Add("bar");
            //blackList.Add("dans");
            //blackList.Add("pastane");
            //blackList.Add("gazino");
            //blackList.Add("pavyon");
            //blackList.Add("taverna");



            #endregion

            #region Substring
            // elimizdeki metin icerisinde verilen sayidan  başlayarak diger verilen sayi kadar olan kismini bize verir.

            //string substr = cumle.Substring(10);
            //Console.WriteLine(substr);
            //substr = cumle.Substring(10,10);
            //Console.WriteLine(substr);

            #endregion

            #region Trim
            //string str = "           elimizdeki metin icerisinde ki bosluklari siler              ";
            //Console.WriteLine(str.TrimStart());
            //Console.WriteLine(str.TrimEnd());
            //Console.WriteLine(str.Trim());
            #endregion


            #region Char işlemleri

            char ch = '5';
            //Console.WriteLine(Char.IsLower(ch)); //Kucuk harf olup olmadigini kontrol eder
            //Console.WriteLine(Char.IsUpper(ch)); //Buyuk harf olup olmadigini kontrol eder

            //Console.WriteLine(Char.IsNumber(ch)); //Sayi   olup olmadigini kontrol eder
            //Console.WriteLine(Char.IsDigit(ch)); //Kucuk harf olup olmadigini kontrol eder
            //Console.WriteLine(Char.IsWhiteSpace(ch)); //Boşluk  olup olmadigini kontrol eder


            //string ifadeler aslinda char dizisidir. ForEach ile donulebilir.
            foreach (char c in cumle)
            {
                Console.WriteLine(c);
            }
            #endregion



            #region Odevler
            string kod = "Kasa-001";
            //Odev Elimizdeki kodu "Kasa-002" şeklinde yazmak 
            string kizlikSoyadi = "Demir";
            // Ekran Ciktisi *e*i* seklinde yazdiralim
            string tcno = "12345678912";
            //TcNo nun son 4 hanesini ekrana yazdirin 
            #endregion


            //

            #endregion

            #region DateTime metodlari

            #endregion

            Console.WriteLine("Hello, World!");
        }
    }
}
