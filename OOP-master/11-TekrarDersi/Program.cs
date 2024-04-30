using System.Data.SqlClient;

namespace _11_TekrarDersi
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
           KargocularService service = new KargocularService();
            #region Karocular Listesi
            //var liste = service.KargoculariGetir();
            //foreach (var kargocu in liste)
            //{
            //    Console.WriteLine("**********************");
            //    Console.WriteLine("Id=>" +kargocu.ShipperID);
            //    Console.WriteLine("Firma=>" + kargocu.CompanyName);
            //    Console.WriteLine("Telefon=>" + kargocu.Phone);

            //} 
            #endregion

            #region Kargocularin Tasidigi Siparislerin Listesi

           var liste= service.SiparisGetir(1, 1996);
            foreach (var siparis in liste)
            {
                Console.WriteLine(siparis.OrderId + " " +siparis.Orderdate+ " " + siparis.Shipcity + " " + siparis.ShipCountry);
            }
            #endregion
            Console.WriteLine("Hello, World!");
        }
    }
}
