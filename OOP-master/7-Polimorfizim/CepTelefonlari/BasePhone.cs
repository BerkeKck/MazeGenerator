using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Polimorfizim.CepTelefonlari
{
    public class BasePhone
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public virtual void CallSound()
        {
            Console.WriteLine("Telefon Çaldi");
        }
    }
}
