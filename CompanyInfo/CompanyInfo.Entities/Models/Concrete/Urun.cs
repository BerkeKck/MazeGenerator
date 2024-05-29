using CompanyInfo.Entities.Models.Abstract;

namespace CompanyInfo.Entities.Models.Concrete
{
    public class Urun : BaseEntity
    {
        public string UrunAdi { get; set; }
        public string? UrunKodu { get; set; }
        public string Fiyat { get; set; }
        public double? Adet { get; set; }
        #region Birim ile 1-N ilişki tanımlaması
        public int BirimID { get; set; }
        public Birim Birim { get; set; }
        //Kategoriler ile N-N ilişki tanımlmasi
        public ICollection<Kategori> Kategoriler { get; set; }
        #endregion
        #region Tedarikçi ile 1-N tamımlaması

        public int? TedarikciID { get; set; }
        public Tedarikci? Tedarikci { get; set; }
        #endregion
    }
}