using CompanyInfo.Entities.Models.Abstract;

namespace CompanyInfo.Entities.Models.Concrete
{
    public class Birim:BaseEntity
    {
        public String  BirimAdi { get; set; }
        public ICollection<Urun>   Urunler { get; set; }
    }
}