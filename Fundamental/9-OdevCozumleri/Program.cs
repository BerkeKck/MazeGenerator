namespace _9_OdevCozumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 0-100 arasindaki üçe  ve yediye bölünenlerin toplami
            // Eylem Binici
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
            //Console.WriteLine("Sayıların toplamı = " + toplam);
            //Console.ReadLine();


            #endregion

            #region  Klavyeden girilen  sayiya kadar olan fibanocci sayilari
            // Erol Aydemir 
            //int ilkSayi = 0, fibonacci = 0, ikinciSayi = 1, sayac = 0;
            //Console.Write("Sayı giriniz :");
            //int girilenSayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(ilkSayi);
            //Console.WriteLine(ikinciSayi);
            //while (sayac < girilenSayi - 2)
            //{
            //    fibonacci = ilkSayi + ikinciSayi;
            //    Console.WriteLine(sayac + "=>" +fibonacci);
            //    ilkSayi = ikinciSayi;
            //    ikinciSayi = fibonacci;
            //    sayac = sayac + 1;
            //}


            #endregion
            #region Klavyeden girilen sayinin basamaklarini while ile bulunuz
            // Omer Faruk 
            //Console.Write("Bir sayı giriniz:");
            //string sayi = Console.ReadLine();
            //int sayac = 0;
            //char c;
            //Console.WriteLine($"Girdiğiniz sayı {sayi.Length} basamaklıdır, basamaklar şu şekildedir:");
            //while (sayac < sayi.Length)
            //{
            //    c = sayi[sayac];
            //    Console.WriteLine(c);
            //    sayac++;
            //}


            //Ceyda Sevilmiş
            //string[] basamaklar = { "birler", "onlar", "yüzler", "binler", "on binler", "yüz binler", "miyonlar", "on milyonlar", "yüz milyonlar", "milyarlar" };
            //int sayi, basamak = 0;
            //Console.WriteLine("Basamaklarına ayrılmasını istediğiniz sayıyı giriniz: ");
            //sayi = int.Parse(Console.ReadLine());

            //while (sayi > 0)
            //{
            //    Console.WriteLine($"{basamaklar[basamak]} basamağı: {sayi % 10}");
            //    sayi /= 10;
            //    basamak++;
            //}
            #endregion
            #region do-while ile ekrandan 0 girilene kadar sayi okutan dongu
            // Veysel Oren 
            //int sayi = 0;
            //do
            //{
            //    Console.WriteLine("Bir sayi giriniz: ");
            //    sayi = int.Parse(Console.ReadLine());
            //    Console.WriteLine(sayi);
            //} while (sayi != 0);

            #endregion
            #region kullanicidan sayi istenecek. Girilen sayi toplami 100 veya  uzeri olana kadar sayi girmeye devam 

            //Eylem Binici
            //int sayi, toplam = 0;
            //do
            //{
            //    Console.WriteLine("Bir sayı giriniz: ");

            //    sayi = int.Parse(Console.ReadLine());
            //    toplam += sayi;

            //} while (toplam < 100);

            //Console.WriteLine("Toplam " + toplam + " oldu. 100 veya üzerine ulaşıldı.");
            //Console.ReadLine();

            #endregion
            #region Kullanicidan alinan iki sayi arasindaki sayilarin kare ve küp toplamlarini hesaplayin.
            #region Didem Nur Yavuz Çağlayan
            //[14:46] Didem Nur Yavuz Çağlayan(Konuk)



            //int kare = 1, kup = 1, kareTop = 0, kupTop = 0;

            //string tercih;

            //bool durum1, durum2;

            //do
            //{

            //Tekrar:

            //    Console.WriteLine("Sayi 1 giriniz");

            //    int sayi1;

            //    Console.WriteLine("Sayi 2 giriniz");

            //    int sayi2;

            //    durum1 = int.TryParse(Console.ReadLine(), out sayi1);

            //    durum2 = int.TryParse(Console.ReadLine(), out sayi2);

            //    if (durum1 == true && durum2 == true)
            //    {

            //        if (sayi1 < sayi2)
            //        {

            //            for (int i = (sayi1 + 1); i < sayi2; i++)
            //            {

            //                kare = i * i;

            //                kup = i * i * i;

            //                kareTop += kare;

            //                kupTop += kup;

            //            }

            //            Console.WriteLine("Kare \t Küp  ");

            //            Console.WriteLine(kare + "\t" + kup);

            //            Console.WriteLine("-----------------");

            //        }
            //        else if (sayi1 > sayi2)
            //        {

            //            for (int i = (sayi2 + 1); i < sayi1; i++)

            //            {

            //                kare = i * i;

            //                kup = i * i * i;

            //                kareTop += kare;

            //                kupTop += kup;

            //            }

            //            Console.WriteLine("Kare \t Küp  ");

            //            Console.WriteLine(kare + "\t" + kup);

            //            Console.WriteLine("-----------------");

            //        }

            //    }
            //    else
            //    {

            //        Console.WriteLine("Yanlış Format ! Tekrar Giriş Yapınız");

            //        goto Tekrar;

            //    }

            //    Console.WriteLine("Devam Etmek İstiyor musunuz? [E,H]");

            //    tercih = (Console.ReadLine());

            //} while (tercih == "E" || tercih == "e"); 
            #endregion

            #region Serdar Akdemir
            //string sayi1, sayi2;
            //string cevap;
            //bool devammi = true;
            //do
            //{
            //    int küpToplam = 0, kareToplam = 0;
            //    Console.WriteLine("1. Sayıyı Giriniz: ");
            //    sayi1 = Console.ReadLine();
            //    Console.WriteLine("2.Sayıyı Giriniz: ");
            //    sayi2 = Console.ReadLine();
            //    if ((int.TryParse(sayi1, out int s1)) && (int.TryParse(sayi2, out int s2)))
            //    {
            //        //s1 = Convert.ToInt32(sayi1);
            //        //s2 = Convert.ToInt32(sayi2);
            //        if (s1 >= s2)
            //        {
            //            for (int i = s2 + 1; i < s1; i++)
            //            {
            //                küpToplam += i * i * i;
            //                kareToplam += i * i;
            //            }
            //        }
            //        else if (s2 > s1)
            //        {
            //            for (int i = s2 - 1; i >= s1; i--)
            //            {
            //                küpToplam += i * i * i;
            //                kareToplam += i * i;
            //            }
            //        }

            //        Console.WriteLine(s1 + "-" + s2 + " " + kareToplam + " " + küpToplam);

            //        Console.WriteLine("Devam Etmek İster misiniz ?  [Evet/Hayır]");
            //        cevap = Console.ReadLine();
            //        if ((cevap == "Hayır") || (cevap == "hayır"))
            //            devammi = false;
            //        else
            //            devammi = true;
            //    }
            //    else
            //        Console.WriteLine("Giriş Hatalı Lütfen Sayi Giriniz...");

            //} while (devammi == true);
            #endregion
            #endregion

            #region  Bilgisayarin tutugu bir sayiyi tahmin eden oyun. 

            #region [15:01] Seyhun Koçak(Konuk)
            //Random rnd = new Random();

            //int x = rnd.Next(1, 101);

            //int counter = 1;

            //Console.WriteLine("Kaç hak istiyorsunuz? ");

            //int hak = int.Parse(Console.ReadLine());

            //int deneme = 0;

            //while (counter <= hak)

            //{

            //    Console.WriteLine($"{counter}. denemenizi yazın: ");

            //    deneme = int.Parse(Console.ReadLine());

            //    if (counter == hak)

            //    {

            //        Console.WriteLine("Deneme hakkınız bitti.");

            //        break;

            //    }

            //    if (deneme < x)

            //    {

            //        Console.WriteLine("Daha büyük sayı gir.");

            //    }

            //    else if (deneme > x)

            //    {

            //        Console.WriteLine("Daha küçük sayı gir.");

            //    }

            //    else

            //    {

            //        Console.WriteLine("tebrikler kazandınız");

            //        break;

            //    }

            //    counter++;

            //} 
            #endregion
            #region Omer Faruk
            //Random rnd = new Random();
            //bool durum = true;
            //bool durum2 = true;
            //int limit, tahmin, rasgele_sayi;
            //string cevap, e, f;
            //int puan = 0;

            //while (durum)
            //{
            //    Console.Write("Tahmin hakkınızı belirleyin:");
            //    e = Console.ReadLine();
            //    rasgele_sayi = rnd.Next(1, 101);
            //    if (!int.TryParse(e, out limit))
            //    {
            //        Console.WriteLine("Lütfen sadece tam sayı değeri girin!");
            //        continue;
            //    }


            //    for (int i = 1; i <= limit; i++)
            //    {
            //        Console.Write("Lütfen tahmininizi giriniz:");
            //        f = Console.ReadLine();
            //        if (!int.TryParse(f, out tahmin))
            //        {
            //            Console.WriteLine("Lütfen sadece tam sayı değeri girin!");
            //            continue;
            //        }

            //        switch (tahmin)
            //        {
            //            case int n when n < rasgele_sayi:
            //                Console.WriteLine("---------------------------------------------------");
            //                Console.WriteLine("Daha büyük bir sayı girin");
            //                break;
            //            case int n when n > rasgele_sayi:
            //                Console.WriteLine("---------------------------------------------------");
            //                Console.WriteLine("Daha küçük bir sayı girin");
            //                break;
            //            default:
            //                Console.WriteLine("---------------------------------------------------");
            //                Console.WriteLine("Tebrikler bildiniz!");
            //                puan++;
            //                break;
            //        }
            //        Console.WriteLine("---------------------------------------------------");
            //        Console.WriteLine($"Mevcut Puan: {puan} Kalan hakkınız:{limit - i}");
            //        Console.WriteLine("---------------------------------------------------");

            //    }

            //    durum2 = true;
            //    while (durum2)
            //    {
            //        Console.WriteLine("---------------------------------------------------");
            //        Console.WriteLine("Oyuna devam etmek istiyor musunuz? [Evet/Hayır]");
            //        Console.WriteLine("---------------------------------------------------");
            //        cevap = Console.ReadLine();

            //        if (cevap.ToLower() == "evet")
            //        { durum2 = false; }
            //        else if (cevap.ToLower() == "hayır" || cevap.ToLower() == "hayir")
            //        {
            //            durum2 = false;
            //            durum = false;
            //        }
            //        else 
            //        { 
            //            Console.WriteLine("Lütfen sadece Evet veya Hayır yazın."); 
            //        }
            //    }

            #endregion
            #region Erol Aydemir
            //    bool devam = true;
            //    while (devam)
            //    {
            //        Random random = new Random();
            //        int tutulanSayi = random.Next(1, 100);
            //        Console.Write("Kaç tahmin hakkı istersiniz?: ");
            //        int tahminHakki = int.Parse(Console.ReadLine());
            //        while (tahminHakki > 0)
            //        {
            //            tahminHakki--;
            //            Console.Write("Tahmininiz: ");
            //            int tahmin = int.Parse(Console.ReadLine());
            //            if (tahmin == tutulanSayi)
            //            {
            //                Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
            //                break;
            //            }
            //            else if (tahmin < tutulanSayi)
            //            {
            //                Console.WriteLine("Daha büyük bir sayı söyleyin. Kalan Hakkınız: " + tahminHakki);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Daha küçük bir sayı söyleyin. Kalan Hakkınız: " + tahminHakki);
            //            }

            //            if (tahminHakki == 0)
            //            {
            //                Console.WriteLine("tahmin hakkiniz bitti. Dogru cevap:" + tutulanSayi);
            //                break;
            //            }
            //        }
            //        while (true) // burasi Sonsuz Dongu
            //        {
            //            Console.Write("Yeniden oynamak ister misiniz? (Evet/Hayır): ");
            //            string cevap = Console.ReadLine();
            //            if (cevap == "Evet" || cevap == "evet" || cevap == "e")
            //            {
            //                devam = true;
            //                break;
            //            }
            //            else if (cevap == "Hayır" || cevap == "hayır" || cevap == "h")
            //            {
            //                devam = false;
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Geçerli cevap giriniz");
            //            }
            //        }
            //    }
            //    Console.WriteLine("Sonlandiriliyor...!");


            //} 
            #endregion

            Random random = new Random();
            int tutulanSayi = 1 + random.Next(100); // tutulan sayi 0 olabilir. 1-100 arasinda sayi olusumunu garantiye almak icin 
            int tahminHakki = 0;
            bool cevrildimi;
            #region 1. Yontem
            //Tekrar:
            //Console.Write("Tahmin Hakki giriniz:");

            // cevrildimi = int.TryParse(Console.ReadLine(), out tahminHakki);
            //if (!cevrildimi)
            //{
            //    Console.WriteLine("Lutfen Sayisal br deger Giriniz...");
            //    goto Tekrar;
            //} 
            #endregion
            #region 2. Yontem
            //2. yontem
            string devamEtmekIstiyormusunuz = "e";
            do
            {


                #region Tahmin Hakki Bolumu
                do
                {
                    Console.Write("Tahmin Hakki giriniz:");

                    cevrildimi = int.TryParse(Console.ReadLine(), out tahminHakki);
                } while (!cevrildimi); 
                #endregion

                bool bayrak = true;
                    int girilenSayi = 0;
                #region Sayi Tahmin Oyunu
                do
                {
                    Console.Write($"{tahminHakki} . Tahmini Giriniz:");
                    girilenSayi = int.Parse(Console.ReadLine());

                    if (girilenSayi > tutulanSayi)
                    {
                        Console.WriteLine("Daha Kucuk Bir Sayi Giriniz ");
                    }
                    else if (girilenSayi < tutulanSayi)
                    {
                        Console.WriteLine("Daha Büyük Bir Sayi Giriniz ");
                    }
                    else
                    {
                        Console.WriteLine($"Tebrikler {tahminHakki} . Denemede Bildiniz");
                        bayrak = false;
                    }

                    tahminHakki = tahminHakki - 1;
                    if (tahminHakki == 0)
                    {
                        Console.WriteLine("Tahmin Hakkiniz Bitti..");
                        bayrak = false;
                    }


                } while (bayrak);

                #endregion

                Console.Write("Devam Etmek Istiyormusunuz [E/H]");
                devamEtmekIstiyormusunuz = Console.ReadLine();
                
            } while (devamEtmekIstiyormusunuz.ToLower()=="e");
            #endregion
            #endregion
        }
    }
}

