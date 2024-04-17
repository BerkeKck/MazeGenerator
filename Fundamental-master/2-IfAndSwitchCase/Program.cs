namespace _2_IfAndSwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Konu Anlatimi
            /*
             * Şartli Scope çalistirmak icin kullanilir
             * ilk şarti if , ikinci ... n-1 . sart
             * else ile biter .
             * Sadece bir scope çalisir
             */
            // Kisa Yol Shift+ Enter Scope acmaya yarar

            // if 'de kiyaslama operatoru "==" tir
            // ve operatoru && ile ifade edilir. yada ifadesi ise || ile 
            //
            // if ifadelerinin sonuna ; koymayin


            #endregion

            #region Su Sicakligi
            //int suSickaligi;
            //string input;
            //Console.Write("Suyun Sicakligini Giriniz");
            //input = Console.ReadLine();

            //suSickaligi = int.Parse(input);
            //if (suSickaligi <= 0)
            //{
            //    Console.WriteLine("Su kati haldedir");
            //}
            //else if (suSickaligi > 0 && suSickaligi < 100)
            //{
            //    Console.WriteLine("Su sivi haldedir");
            //}
            //else
            //{
            //    Console.WriteLine("Su gaz haldedir");
            //}
            #endregion

            #region Haftanin Gunleri : Ekrandan 1-7 arasinda bir sayi aliniz.
            // Girilen Sayiya Gore haftanin gununu yazdiriniz 
            // Pazar 1. Gun .

            // int gun = 0;
            // string input;
            // Console.WriteLine("Haftanin Gununu giriniz:");
            //input = Console.ReadLine();
            // gun = int.Parse(Console.ReadLine());

            // if (gun == 1)
            // {
            //     Console.WriteLine("Pazar");
            // }
            // else if (gun == 2)
            // {
            //     Console.WriteLine("Pazartesi");
            // }
            // else if (gun == 3)
            // {
            //     Console.WriteLine("Sali");
            // }
            // else if (gun == 4)
            // {
            //     Console.WriteLine("Carsamba");
            // }
            // else if (gun == 5)
            // {
            //     Console.WriteLine("Persembe");
            // }
            // else if (gun == 6)
            // {
            //     Console.WriteLine("Cuma");
            // }
            // else
            // {
            //     Console.WriteLine("Cumartesi");
            // }

            #endregion

            #region Ekrandan okutulan 3 sayinin buyuk olanini bulunuz
            //int sayi1, sayi2, sayi3;

            //Console.WriteLine("1. sayiyi giriniz:");
            //sayi1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2. sayiyi giriniz:");
            //sayi2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("3. sayiyi giriniz:");
            //sayi3 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Girilen sayilar {0} , {1} , {2} ",sayi1,sayi2,sayi3);
            //if (sayi1 > sayi2 && sayi1 > sayi3)
            //{
            //    Console.WriteLine("Girilen 1. sayi :" + sayi1 + " en buyuktur");
            //    Console.WriteLine($"Girilen 1. Sayi:{sayi1} en buyuktur");

            //}
            //else if (sayi2 > sayi1 && sayi2 > sayi3)
            //{
            //    Console.WriteLine($"Girilen 2. Sayi:{sayi2} en buyuktur");
            //}
            //else
            //{
            //    Console.WriteLine($"Girilen 3. Sayi:{sayi3} en buyuktur");
            //}

            #endregion

            #region Klavyeden girilen toplam tutar değeri 100’den küçük ise %5, 100 ile 500 arasında ise %10, 500’den büyük ise %15 indirim yapıp ödenecek tutarı hesaplayıp ekrana yazdırin
            //double toplamTutar;
            //Console.WriteLine("Toplam tutarı giriniz:");
            //toplamTutar = Convert.ToDouble(Console.ReadLine());
            //if (toplamTutar < 100)
            //{
            //    toplamTutar = toplamTutar - (toplamTutar * 5) / 100;
            //    Console.WriteLine("Ödenecek tutar:" + toplamTutar);
            //}
            //else if (toplamTutar >= 100 && toplamTutar < 500)
            //{
            //    toplamTutar = toplamTutar - (toplamTutar * 10) / 100;
            //    Console.WriteLine("Ödenecek tutar:" + toplamTutar);
            //}
            //else if (toplamTutar >= 500)
            //{
            //    toplamTutar = toplamTutar - (toplamTutar * 15) / 100;
            //    Console.WriteLine("Ödenecek tutar:" + toplamTutar);
            //}



            #endregion
            #region  Aylık elektrik faturası hesaplanacaktır. Kullanıcıdan kaç kWh tükettiğini alınız. Eğer tüketim 150’den küçükse kWh’i 10 tl, eğer 150 ile 300 arasında ise 20 tl, 300 üzeri ise 40 tl olarak hesaplanmaktadır. Kişinin yaptığı tüketime göre faturasının kaç TL olacağını hesaplayıp ekrana yazdırınız.
            //int kWh, fatura;

            //Console.WriteLine("Kaç kWh Elektrik Harcandı ?");

            //kWh = int.Parse(Console.ReadLine());

            //if (kWh < 150)
            //{
            //    fatura = kWh * 10;
            //    Console.WriteLine($"Faturanız :{fatura}");
            //}
            //else if (kWh >= 150 && kWh < 300)
            //{
            //    fatura = kWh * 20;
            //    Console.WriteLine($"Faturanız :{fatura}");
            //}

            //else
            //{
            //    fatura = kWh * 40;
            //    Console.WriteLine($"Faturanız :{fatura}");
            //}
            #endregion

            #region Boy Kilo Hesaplama
            /* Klavyeden girilen boy ve cinsiyet  göre kişinin ideal kilosunu aşağıdaki
             * açıklamaya göre hesaplayıp ekrana  
             * İdeal Kilonuz=... şeklinde yazdırınız.
             Kadınlar için: Boyunuzun ilk 150 santimetresi için 45 kilo, 
             sonraki her 2.5 cm için 2.2 kilo ekler.
            Örnek olarak; boyunuz 160 cm ise, ideal kilonuz 45 + 8.8 = 53.8 kilogram olacaktır.
            Erkekler için: Boyunuzun ilk 150 santimetresi için 48 kilo, sonraki 
            her 2.5 cm için 2.7 kilo ekler.
            Örnek olarak boyunuz 180 cm ise, ideal kilonuz 48 + 32.4 = 80.4 kilogram olacaktır. 
            */
            #region Sanem Cözüm For ile 
            //Console.WriteLine("Lütfen boyunuzu (cm cinsinden) girin:");
            //double boy = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Lütfen cinsiyetinizi girin (K/E):");
            //char cinsiyet = char.ToUpper(Convert.ToChar(Console.ReadLine()));

            //double idealKilo = 0;
            //double herAdimKilo = 0;

            //if (cinsiyet == 'K')
            //{
            //    herAdimKilo = 2.2;
            //    idealKilo = 45;
            //}
            //else if (cinsiyet == 'E')
            //{
            //    herAdimKilo = 2.7;
            //    idealKilo = 48;
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz cinsiyet girdisi!");
            //    return;
            //}

            //for (double i = 150; i < boy; i += 2.5)
            //{
            //    idealKilo += herAdimKilo;
            //}

            //Console.WriteLine($"İdeal Kilonuz: {idealKilo:F1} kilogram"); 
            #endregion
            #region Emir Ozturk Cozum.
            //int sayi1, sayi2;
            //sayi1 = 7;
            //sayi2 = 6;
            //double sonuc = sayi1 / (double)sayi2;
            //Console.Write("Lütfen boyunuzu giriniz:");
            //int boy = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen cinsiyetinizi giriniz (E/K):");
            //string cinsiyet = Console.ReadLine().ToLower();

            //if (cinsiyet == "e")
            //{
            //    if (boy > 150)
            //    {
            //        int sabitKilo = 48;
            //        double fazlalikBoy = (boy - 150) / 2.5;
            //        double idealKilo = sabitKilo + fazlalikBoy * 2.7;
            //        Console.WriteLine("İdeal kilonuz:" + idealKilo);

            //    }
            //    else
            //    {
            //        Console.WriteLine("İdeal kilonuz 48");
            //    }
            //}
            //else
            //{
            //    if (boy > 150)
            //    {
            //        int sabitKilo = 45;
            //        double fazlalikBoy = (boy - 150) / 2.5;
            //        double idealKilo = sabitKilo + fazlalikBoy * 2.2;
            //        Console.WriteLine("İdeal kilonuz:" + idealKilo);
            //    }
            //    else
            //    {
            //        Console.WriteLine("İdeal kilonuz 45");
            //    }
            //}
            #endregion
            #endregion

            #region Vize Final Hesaplama
            /*
             *  Bir öğrenciye ait 2 vize notunun ve 1 final  ortalamasını hesaplayan ve (vizenin %30 Finalin %70 i alinacak)
             *  ortalama 50’den küçükse ekrana “kaldı” büyükse “geçti” yazan programı yazınız.
             * 
             */

            //Console.WriteLine("vize 1:");
            //int vize1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("vize 2:");
            //int vize2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("final:");
            //int final = int.Parse(Console.ReadLine());
            //var total = (((vize1 + vize2) / 2) * 0.3) + (final * 0.7);


            //if (total > 50)
            //{
            //    Console.WriteLine("Gectiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Kaldiniz");
            //}
            //string sonuc = total > 50 ? "geçti" : "Kaldı";
            //Console.WriteLine(sonuc);
            #endregion
            var doublesayi = 5.0;
            float sayi = 5.0f;
            decimal decimalsayi2 = 5.0M;


            #region SwitchCase Konu Anlatimi 
            /*
            * Bir degeri dinleyerek 2 den cok scope dallanmasini yonetir.
            * if'ten farki indexlemesi ve dallara daha hizli erismesini saglar. Daha performanslidir.
            * Eger Aylarin kontrolu  gibi birden cok kontrol yapilacaksa switch case ifade kulanilmasi uygundur.
            * */

            //Console.WriteLine("Ayin Numarasini giriniz");
            //var giris = Console.ReadLine();
            //int ay = int.Parse(giris);
            //bool flag = false;
            //int sayi2 = 55;
            //if (ay == 1)
            //{
            //    Console.WriteLine("Ocak");
            //}
            //else if (ay == 2)
            //{
            //    Console.WriteLine("Subat");
            //}
            //else if (ay == 3)
            //{
            //    Console.WriteLine("Mart");
            //}
            //else if (ay == 4)
            //{
            //    Console.WriteLine("Nisan");
            //}
            //else if (ay == 5)
            //{
            //    Console.WriteLine("Mayis");
            //}
            //else if (ay == 6)
            //{
            //    Console.WriteLine("Haziran");
            //}
            //else if (ay == 7)
            //{
            //    Console.WriteLine("Temmuz");
            //}
            //else if (ay == 8)
            //{
            //    Console.WriteLine("Agustos");
            //}
            //else if (ay == 9)
            //{
            //    Console.WriteLine("Eylul");
            //}
            //else if (ay == 10)
            //{
            //    Console.WriteLine("Ekim");
            //}
            //else if (ay == 11)
            //{
            //    Console.WriteLine("Kasim");
            //}
            //else if (ay == 12)
            //{
            //    Console.WriteLine("Aralik");
            //}

            //switch (ay)
            //{
            //    case 1:
            //        Console.WriteLine("Ocak");

            //        break;
            //    case 2://when (flag == true) && sayi2 == 55:
            //        Console.WriteLine("Subat");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nisan");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayis");
            //        break;
            //    case 6:
            //        Console.WriteLine("Haziran");
            //        break;
            //    case 7:
            //        Console.WriteLine("Temmuz");
            //        break;
            //    case 8:
            //        Console.WriteLine("agustos");
            //        break;
            //    case 9:
            //        Console.WriteLine("Eylul");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ekim");
            //        break;
            //    case 11:
            //        Console.WriteLine("Kasim");
            //        break;
            //    case 12:
            //        Console.WriteLine("Aralik");
            //        break;
            //    default:
            //        Console.WriteLine("Girilen Deger Aralik Disidir");
            //        break;
            //}

            #region Odev
            /*
            * Hesaplama Uygulamasina Hosgeldiniz
            * 1-Toplama
            * 2-Cikarma
            * 3-Çarpma
            * 4-Bölme
            * Lutfen yapmak istediginiz ilemi seciniz:2
            * 1. Sayiyi giriniz: 5
            * 2. Sayiyi Giriniz :3
            * Sonuc = 5-2 =3
            */
            #endregion
            #region Odevin if ile Cozumu
            //[16:06] Erol Aydemir(Konuk)
            // Console.WriteLine(@"Hesaplama Uygulamasına hos geldiniz!

            //                     1- Toplama

            //                     2- Cikarma

            //                     3- Carpma

            //                     4- Bolme

            //                     ");

            // Console.WriteLine("Yapmak istediginiz islemi seciniz:");

            // int islem = Convert.ToInt32(Console.ReadLine());


            // Console.WriteLine("ilk sayiyi giriniz:");

            //double sayi1 = Convert.ToDouble(Console.ReadLine());

            // Console.WriteLine("ikinci sayiyi giriniz:");

            // double sayi2 = Convert.ToDouble(Console.ReadLine());

            // if (islem == 1)
            // {

            //     double sonuc = sayi1 + sayi2;

            //     Console.WriteLine("Isleminizin sonucu: " + sonuc);

            // }
            // else if (islem == 2)
            // {

            //     double sonuc = sayi1 - sayi2;

            //     Console.WriteLine("Isleminizin sonucu: " + sonuc);

            // }

            // else if (islem == 3)
            // {

            //     double sonuc = sayi1 * sayi2;

            //     Console.WriteLine("Isleminizin sonucu: " + sonuc);

            // }
            // else if (islem == 4)

            // {

            //     double sonuc = sayi1 / sayi2;

            //     Console.WriteLine("Isleminizin sonucu: " + sonuc);

            // }
            // else
            // {

            //     Console.WriteLine("Geçerli işlem giriniz.");

            // }
            #endregion

            #region Odevin Switch Case ile cozumu

            //Ceyda Sevilmiş Çözümü
            //Console.WriteLine("Hesaplama Uygulamasina Hosgeldiniz");
            //Console.WriteLine("1-Toplama");
            //Console.WriteLine("2-Cikarma");
            //Console.WriteLine("3-Çarpma");
            //Console.WriteLine("4-Bölme");
            //Console.WriteLine("Lutfen yapmak istediginiz islemi seciniz:");
            //int islem;
            //float sayi1, sayi2;
            //islem = int.Parse(Console.ReadLine());

            //Console.WriteLine("1. Sayiyi giriniz:");
            //sayi1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("2. Sayiyi giriniz:");
            //sayi2 = float.Parse(Console.ReadLine());

            ////Switch Case ile cevap
            //switch (islem)
            //{
            //    case 1:
            //        Console.WriteLine($"{sayi1} + {sayi2} = {sayi1 + sayi2}");
            //        break;
            //    case 2:
            //        Console.WriteLine($"{sayi1} - {sayi2} = {sayi1 - sayi2}");
            //        break;
            //    case 3:
            //        Console.WriteLine($"{sayi1} x {sayi2} = {sayi1 * sayi2}");
            //        break;
            //    case 4:
            //        Console.WriteLine($"{sayi1} / {sayi2} = {sayi1 / sayi2}");
            //        break;
            //    default:
            //        Console.WriteLine("Gecersiz islem");
            //        break;
            //}
           
            #endregion
            #endregion
        }
    }

}


