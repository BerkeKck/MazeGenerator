﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Polimorfizim.Hayvanlar
{
    public  class Leopar :Kedi
    {

        public override void HareketEt()
        {
            Console.WriteLine("Agaca tirman");
        }
    }
}
