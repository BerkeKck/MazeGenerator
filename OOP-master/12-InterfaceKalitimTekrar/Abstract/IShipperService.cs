using _12_InterfaceKalitimTekrar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceKalitimTekrar.Abstract
{
    public interface IShipperService
    {
        public Shipper? GetShipper(int id);
        public List<Shipper> GetShipperList();

       

        public List<ShipperOrders> GetShipperOrdersList(int shipperID,int? year=null);
    }
}
