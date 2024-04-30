using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_TekrarDersi
{
    //OrderId,CustomerID,EmployeeID,OrderDate,ShipCountry,ShipCity
    public class Siparis
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public int EmployeeID { get; set; }
        public DateTime Orderdate { get; set; }
        public string ShipCountry { get; set; }
        public string Shipcity { get; set; }
    }
}
