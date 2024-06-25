using _12_InterfaceKalitimTekrar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceKalitimTekrar.Abstract
{
    public interface ICustomerService
    {

        public Customer GetCustomer(string id);
        public List<Customer> GetAll();

        public List<AylikMusteriRaporu> GetAylikMusteri(int yil);
    }
}
