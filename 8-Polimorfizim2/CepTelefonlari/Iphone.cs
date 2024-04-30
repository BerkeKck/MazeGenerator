using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace _8_Polimorfizim2.CepTelefonlari
{
    public class Iphone:BasePhone
    {
        public override void CallSound()
        {
            using (SoundPlayer player = new SoundPlayer(@"..\..\..\Sounds\Iphone.wav"))
            {
                player.Play();
            }

        }
    }
}
