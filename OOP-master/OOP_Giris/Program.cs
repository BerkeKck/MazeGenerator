using OOP_Giris.BilgisayarParcalari;

namespace OOP_Giris
{
    /*
     * Bilgisayar parcalari
     * AnaKart ,Cpu,Ram ,SSD,HDD,EkranKarti,NEtworkKarti,
     * Kasa , PowerSupplier ,Ekran ,Klavye ,Mouse 
     * Printer ,Scanner ,Hoperlor,WebCam
     * 
     * 
     * 
     */
    public class Ogrenci
    {
        public int Id; // Field
        public string Ad;// Field
        public string Soyad;// Field
        private  string TcNo;// Field
        public DateTime DogumTarihi;// Field

        //Property => Ozellik demektir.
        // Kontrollu veri alimi icin gerekli set metoduna sahiptir
        public string TcKimlik
        {
            get
            {
                return TcNo.Substring(7);
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("TcKimlik alani boş olamaz");
                    return;
                }

                foreach (Char ch in value)
                {
                    if (!Char.IsDigit(ch))
                    {
                        Console.WriteLine("Girilen ifade icerisinde sayisal olmayan degerler var");
                        return;
                    }
                }
                if (value[0].ToString() == "0")
                {
                    Console.WriteLine("Tc No 0 ile başlayamaz");
                    return;
                }

                if (value.Length == 11)
                {
                    TcNo = value;
                }
                else
                {
                    Console.WriteLine("Eksik yada fazla karakter. 11 Karakter olmalidir");
                    return ;
                }
            } //Boş Property . Yani Koşulsuz özellik 

        }
        public string Gsm { get; set; } // Boş Prop => kontrolsuz 
        // Ogrenci Class'ina ait metodlar
        public void SetTcNo(string tcNo)
        {
            if (tcNo.Length != 11)
            {
                Console.WriteLine("Eksik yada fazla karakter. 11 Karakter olmalidir");

            }
            else if(tcNo.Length ==11) 
            {
                    TcNo = tcNo;
            }
        }
        public string GetTcNo()
        {

            //Tc No'nun Son 4 hanesi geri donecek
            return TcNo.Substring(7);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            #region Giris
            //Ogrenci ogrenci = new Ogrenci();
            //ogrenci.Id = 1;
            //ogrenci.Ad = "Ali";
            //ogrenci.Soyad = "Yilmaz";
            //ogrenci.SetTcNo("12345678901");
            //ogrenci.TcKimlik = "ıasdfkhasdfhk"; 
            #endregion


            #region Instance Alma

            //1.Yontem
            AnaKart anaKart = new AnaKart();
            anaKart.RamTipi = RamTipi.DDR3;
            anaKart.Marka = "Asus";
            anaKart.Model = "XYZ";
            anaKart.Fiyat = 120.3f;
            anaKart.Wifi = true;
             

            //2. Yol
            CPU cpu = new();

            //3. Yol : Object Initialize ile instance alma

            Ram ram = new Ram()
            {
                Marka = "Kingston",
                Model = "DDR5",
                Kapasite = 8,
                Fiyat = 111.45f
            };

            PowerSupplier powerSupplier = new PowerSupplier()
            {
                Marka="XYZ",
                Model="ABC",
                Fiyat=78
            };
            Kasa kasa = new Kasa()
            {
                Marka="Asus",
                Model="ABC",
                PowerSupplier= powerSupplier,
                Fiyat=90
            };

            // Buradaki Tanimlamada Bilgisayar Nesnesinin ihtiyac duydugu alanlar
            // Daha onceden intance aldigimiz neslerden atamasi yapilir
            Bilgisayar bilgisayar = new Bilgisayar()
            {
                Anakart = anaKart,
                BilgisayarTipi= BilgisayarTipi.Ogrenci,
                Cpu = cpu,
                Ram = ram,
                Kasa = kasa,
                Fiyat = 1000
            };


            //2. Yol 
            Bilgisayar bilgisayar1 = new Bilgisayar()
            {
                Anakart = new AnaKart()
                {
                    Marka = "Gigabyte",
                    Model = "QWE",
                    Fiyat = 130
                },
                Cpu = new CPU
                {
                    Marka = "intel",
                    Model = "i9",
                    CoreSayisi = 12,
                    Fiyat = 300
                },
                Kasa = new Kasa
                {
                    Marka = "ASUS",
                    Model = "ZXC",
                    Fiyat = 80,
                    PowerSupplier = new PowerSupplier { Marka = "XYZ" }
                }
            };
            #endregion
            #region object veri tipi
            object obj = new object();
            obj = DateTime.Now;
            obj = 12;
            obj = "Deneme 123";

            #endregion
            Console.WriteLine();
        }
    }
}
