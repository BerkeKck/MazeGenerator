using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ClassEncapsulation.Telefonlar
{

    public enum IsletimSistemi
    {
        Android, // Google
        IOS, // Apple
        HarmonyOS // Huwaei 
    }

    /*
     * 
     * Bluetooth	Var
        Arttırılabilir Hafıza	Yok
        Ağırlık	232 Gram
        Yüz Tanıma	Var
        Ön (Selfie) Kamera Aralığı	14 - 19,9 MP
        Ekran Boyutu	7,8 inç
        Suya / Toza Dayanıklılık	Var
        Dokunmatik Ekran	Var
        Kamera Çözünürlüğü	50 MP +40 MP +12 MP
        Ekran Boyut Aralığı	6 inç ve Üzeri
        Ekran Tipi	OLED
        Pil Gücü	5000 mAh
        GPS (Küresel Konumlama Sistemi)	Var
        Parmak İzi Okuyucu	Var
        NFC (Yakın Alan İletişimi)	Var
        Ön (Selfie) Kamera	16 MP
        Dahili Hafıza	512 GB
        Pil Gücü Aralığı	5000 mAh ve Üzeri
        Kamera Çözünürlüğü Aralığı	20 MP ve Üzeri
      */
    public class AkilliCepTelefonu
    {

        #region öZELLİKLERİ
        public bool Bluetooth { get; set; }
        public bool YuzTanima { get; set; }
        public bool NFC { get; set; }
        public bool ParmakIzi { get; set; }

        public int DahiliHazifa { get; set; } 
        #endregion



        #region Yeteknekleri
        public bool SelfiCek()
        {
            return true;
        }
        public bool OnKameradanFotografCek()
        {
            return true;
        }
        public bool NfcAc()
        {
            return true;
        }
        public bool TelefonAc()
        {
            return true;
        }
        public bool TelefonKapat()
        {
            return true;
        } 
        #endregion

    }
}
