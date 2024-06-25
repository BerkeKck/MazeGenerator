using _5_Constructor.Personeller;
using System.Data.SqlClient;
using System.Drawing;

namespace _5_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Otomobil kartal = new Otomobil();
            //kartal.Marka = "Tofas";
            //kartal.Model = "Kartal";
            //kartal.Renk= System.Drawing.KnownColor.White;

            ////Bu sekildeki Kullanima Yapici Metodu olan Kullanim bicimi diyor
            //Otomobil serce = new Otomobil("Tofas","Serce", KnownColor.White);


            ITPersonel ali = new ITPersonel("Ali", "Yilmaz", false);
            FinansMuduru mudur = new FinansMuduru("", "", true);
            SatisPersoneli satis = new("", "", false);
            Sekreter ayse = new Sekreter("Ayse","Kaya",true);
            SqlConnection sqlcon  = SqlBaglanti.BaglatiVer();

            Console.WriteLine("Hello, World!");
        }
    }
}
