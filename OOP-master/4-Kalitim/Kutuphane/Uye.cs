﻿using _4_Kalitim.Personeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Kalitim.Kutuphane
{

    public enum UyeTipi
    {
        Ogrenci,
        Akademisyen,
        Arastirmaci,
        SiradanVatandas
    }

    public class Uye:Kisi
    {
        public UyeTipi UyeTipi { get; set; }
    }
}
