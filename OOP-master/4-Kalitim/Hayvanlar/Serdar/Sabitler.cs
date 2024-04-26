using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Kalitim.Hayvanlar.Serdar
{
    public enum hucreTuru
    {
        Bitki = 1,
        Hayvan = 2
    }
    public enum hucreSayisi
    {
        CokHucreli = 1,
        TekHucreli
    }
    public enum BeslenmeT
    {
        Ototroflar = 1,
        Heterotrof,
        Saprofit,
        Holozoik,
        Herbivor,
        Omnivor,
        Karnivor,
    }
    public enum UremeT
    {
        celikleUreme = 1,
        YumruVeSoganla,
        SurunucuGovde,
        Sporla,
        Eşeyli,
        Doğum,
        yumurtlama,
    }
    public enum OmurgaT
    {
        Omurgali = 1,
        omurgasiz
    }
    public enum SuTip
    {
        tuzlu = 1,
        tatli
    }
    public enum kanT
    {
        soguk = 1,
        sicak,
    }
    public enum Solunumt
    {
        Deri = 1,
        Solungac,
        Akciger,
        Trake,
    }
    public enum DisGorunum
    {
        tuy = 1,
        kıl,
        post,
        pul,
    }
    public enum YasamAlani
    {
        Kara = 1,
        Deniz,
        Ikiside,
        Belirsiz,
    }


}
