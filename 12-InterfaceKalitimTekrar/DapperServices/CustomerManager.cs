using _12_InterfaceKalitimTekrar.Abstract;
using _12_InterfaceKalitimTekrar.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceKalitimTekrar.DapperServices
{
    public class CustomerManager : DapperBaseManager, ICustomerService
    {
        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<AylikMusteriRaporu> GetAylikMusteri(int yil)
        {
            string sql = $@"SELECT c.CompanyName,Month(o.OrderDate) Ay ,count(*) Adet
                            from Customers c
                            inner join Orders  o on o.CustomerID=c.CustomerID
                            where year(OrderDate) = {yil}
                            group by c.CompanyName,Month(o.OrderDate)";
           var liste=  Connection.Query<AylikMusteriRaporu>(sql);

            return liste.ToList();
        }

        public Customer GetCustomer(string id)
        {
            throw new NotImplementedException();
        }
    }
}
