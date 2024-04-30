using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Polimorfizim.Hayvanlar
{
    public class Hayvan
    {

        //virtual keyword kalitim verilen yerlerde bu metodu yeniden tanimlayabiliriz demek.
        // Bu metod ovveride edilebilir demektir.
        public virtual void SesCikar()
        {
            Console.WriteLine("Hirrrr");
        }

        public virtual void HareketEt()
        {

        }
    }
}
