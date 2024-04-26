using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _5_Constructor
{
    public class Otomobil
    {
        /*
         * Custroctur => Yapici Metod Bir Siniftan instance alindiginda ilk calisan
         * 
         * Ozel bir metoddur. Bu metodun geri donus tipi yoktur.
         * 
         * Sinif ile ayni isimnde olmak zorundadir.
         * 
         * Nesne ilk olusturuldugunda dişaridan parametre almak icin yada
         * Bazi Property'lere default deger vermek icin Constructer kullanilir
         * 
         */


        //Boş yapici metod
        public Otomobil()
        {
            Renk = KnownColor.White;

            Console.WriteLine("Constructor Calisti => Renk :" +Renk);
        }

        //1. Overload edilmiş metod
        public Otomobil(string marka)
        {
            Marka = marka;
        }

        public Otomobil(string marka,string model)
        {
            Marka = marka;
            Model= model;
        }
        public Otomobil(string marka, string model,KnownColor renk)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
        }
        #region Ozellikleri
        public string Marka { get; set; }
        public string Model { get; set; }
        public KnownColor Renk { get; set; }
        #endregion

        #region Yetenekleri
        public void Start()
        {

        }
        public void Stop()
        {

        }

        public void KlimaCalistir()
        {

        } 
        #endregion
    }
}
