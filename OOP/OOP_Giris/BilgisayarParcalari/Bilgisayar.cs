using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Giris.BilgisayarParcalari
{

    /*
     * 
     * Bu yapı yazılım dilinde enum, enumaration ya da enum sabitleri olarak adlandırılır. Değişkenlerin alabileceği değerlerin sabit (belli) olduğu durumlarda programı daha okunabilir hale getirmek için kullanılır. Programda birçok değişkene tek tek sayısal değer vermek yerine "enum" kullanılabilir. Özet olarak "enum" yapısı sayıları anlamlı şekilde isimlendirerek kullanabilmeye izin verir.
     * 
     * Enumlar Default degeri integer'dir. Ama : koyarak 
     * tam sayi degiskenleri atanabilir
     * 
     * 
     * 
     */

    public enum BilgisayarTipi:byte
    {
        Ogrenci=1,
        Oyun=2,
        İş=3,
        Grafiker=4

    }

    public class Bilgisayar
    {
        public AnaKart Anakart { get; set; }
        public CPU Cpu { get; set; }
        public Ram Ram { get; set; }
        public Kasa Kasa { get; set; }
        public float Fiyat { get; set; }
        public BilgisayarTipi BilgisayarTipi { get; set; }
    }
}
