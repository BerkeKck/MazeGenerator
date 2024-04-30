using _12_InterfaceKalitimTekrar.Concrete;
using _12_InterfaceKalitimTekrar.DapperServices;
using System.Data.SqlTypes;

namespace _12_InterfaceKalitimTekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShipperService shipperService = new ShipperService();
            CategoryService categoryService = new CategoryService();
            #region Shipper Listesi
            //var liste = shipperService.GetShipperList();

            //foreach (var shipper in liste)
            //{
            //    Console.WriteLine($"id:{shipper.ShipperId}\tFirma:{shipper.CompanyName}\tTelefon:{shipper.Phone} ");

            //} 
            #endregion

            #region Shipper Orders

            //var liste= shipperService.GetShipperOrdersList(1,1996);

            // foreach (var item in liste)
            // {
            //     Console.WriteLine($"id:{item.OrderId}\tFirma:{item.CustomerID}\tCalisan:{item.EmployeeID}\tSiparis Tarihi:{item.OrderDate}\tUlke:{item.ShipCountry}\tSehir:{item.ShipCity} ");
            // }

            #endregion



            #region Add Category
            //string sql = $@"insert into Categories 
            //   (CategoryName,Description) 
            //    values ('Tekstil','Giyim Kusam')

            //";
            //int sonuc = categoryService.Add(sql);
            //if(sonuc>0)
            //    Console.WriteLine("Kayit Basarili");
            #endregion
            #region Category Products


            //var liste = categoryService.GetProducts(2);
            //foreach (var item in liste)
            //{
            //    Console.WriteLine($"{item.ProductId}\t{item.ProductName}\t{item.CategoryName}\t{item.UnitPrice}\t{item.UnitInStock}");

            //}
            #endregion


            #region Dapper ile Veri Cekme

            //CategoryManager categoryManager = new CategoryManager();
            //var liste = categoryManager.GetProducts(3);
            //foreach (var item in liste)
            //{
            //    Console.WriteLine($"{item.ProductId}\t{item.ProductName}\t{item.CategoryName}\t{item.UnitPrice}\t{item.UnitInStock}");

            //}

            #region CustomerManager

            CustomerManager customerManager = new CustomerManager();
            var liste = customerManager.GetAylikMusteri(1997);

            foreach (var item in liste)
            {
                Console.WriteLine($"{item.CompanyName}\t{item.Ay}\t{item.Adet}");
            }
            #endregion
            #endregion

            //Console.WriteLine("Hello, World!");
        }
    }
}
