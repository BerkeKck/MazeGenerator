using _2_ClassEncapsulation.Mobilyalar;
using _2_ClassEncapsulation.Telefonlar;
namespace _2_ClassEncapsulation
{

    /*
     *  Mobilyalar icin Masa,sandalye,yemekTakimi , YatakOdasi takimi,
     *  Bahçe takimi,ÇocukOdasi Takimi
     * 
     * 
     * Telefonlar : Sabit Telefon, Cep Telefonu ,Akilli Telefonlar 
     * 
     * Araçlar : Otomobil , Kamyon , Otobus ,Motorsiklet
     */
    internal class Program
    {
        static void Main(string[] args)
        {

            // Yemek Takimi instance alma 1. Yol
            #region Yemek Takimi
            // YemekTakimi yemekTakimi = new YemekTakimi();
            // yemekTakimi.Masa =new Masa();
            // yemekTakimi.Sandalyeler = new List<Sandalye>();
            //yemekTakimi.Sandalyeler.Add(new Sandalye() { AyakSayisi=4,KumasTipi=KumasTipi.KESME,Malzeme=Malzeme.Ahsap,Renk=Renk.Kirmizi});


            // // YemekTakimi 2. Yol NEsneleri onceden tek tek olusturup 
            // //YemekTakimi Nesnesinin property'lerine atama yapmaktir
            // Masa yemekMasasi = new Masa()
            // {

            //     Renk = Renk.Mavi,
            //     Color = new System.Drawing.Color(),
            //     Color2 = ConsoleColor.Black,
            //     KnownColor = System.Drawing.KnownColor.Blue
            // };

            // Sandalye sandalye1 = new Sandalye()
            // {
            //     AyakSayisi = 4,
            //     KumasTipi = KumasTipi.KESME,
            //     Malzeme = Malzeme.Ahsap,
            //     Renk = Renk.Kirmizi,
            // };
            // Sandalye sandalye2 = new Sandalye()
            // {
            //     AyakSayisi = 4,
            //     KumasTipi = KumasTipi.KESME,
            //     Malzeme = Malzeme.Ahsap,
            //     Renk = Renk.Kirmizi,
            // };
            // Sandalye sandalye3 = new Sandalye()
            // {
            //     AyakSayisi = 4,
            //     KumasTipi = KumasTipi.KESME,
            //     Malzeme = Malzeme.Ahsap,
            //     Renk = Renk.Kirmizi,
            // };

            // yemekTakimi.Sandalyeler.Add(sandalye1);
            // yemekTakimi.Sandalyeler.Add(sandalye2);
            // yemekTakimi.Sandalyeler.Add(sandalye3);

            // Console.WriteLine($"Yemek Odasi 1 adet masa ve {yemekTakimi.Sandalyeler.Count} adet sandalyeden olusmaktadir");
            // //RGB => RedGreenBlue

            // AkilliCepTelefonu samsung = new AkilliCepTelefonu
            // {
            //     Bluetooth =true,
            //     DahiliHazifa=128,
            //     NFC = true,
            //     ParmakIzi = true,
            //     YuzTanima = true
            // }; 
            #endregion

            Cocuk ali = new Cocuk();
            ali.Ad = "Ali";
            ali.Soyad = "Yilmaz";
            ali.AyakkabiNumarasi = 40;
            ali.Email2 = "123412";
            // Cocuk Nesnesinin metodunu kullandigimizda 
            // Bize hata firlatma ihtimali var.
            // O nedenle firlatilan hatayi try catch blogu ie yakalamak gerekir
            
            try
            {
                ali.HarclikAl(300);
                ali.TCNO = "123qweasd12";
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           
            Console.WriteLine(ali.BiriktirdigiPara);
            Console.WriteLine("Hello, World!");
        }
    }
}
