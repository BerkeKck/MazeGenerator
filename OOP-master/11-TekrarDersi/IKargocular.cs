using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_TekrarDersi
{
    public interface IKargocular
    {
        public List<Shipper> KargoculariGetir();
        public bool Ekle(string companyName, string phone);

        public bool Guncelle(int id,string companyName, string phone);
        public bool Sil(int shipperId);
        public Shipper Getir(int shipperId);
        public Shipper Getir(string companyName);
        public List<Siparis> SiparisGetir(int shipperId,int? yil=null);
    }
}
