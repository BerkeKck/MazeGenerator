namespace _4_Kalitim.Kutuphane
{
    public class Kitap 
    {
        public string Ad { get; set; }
        public Yazar Yazar { get; set; }
        public int SayfaSayisi { get; set; }
        public int Fiyat { get; set; }
        public KitapKategorileri Katagori { get; set; }
    }
}