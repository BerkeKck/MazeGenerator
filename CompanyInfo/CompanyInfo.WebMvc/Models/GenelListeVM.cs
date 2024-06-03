using CompanyInfo.Entities.Models.Concrete;

namespace CompanyInfo.WebMvc.Models
{
    public class GenelListeVM
    {
        public List<Uri> MyProperty { get; set; }

        public List<Kategori> kategoriler { get; set; } 

        public List<Tedarikci> tedarikciler { get; set; }   
    }
}
