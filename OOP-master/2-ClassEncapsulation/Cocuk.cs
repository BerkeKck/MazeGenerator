using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ClassEncapsulation
{
    public class Cocuk
    {
        private string _name;
        #region Ozellikler




        //public int MyProperty { get; set; }
        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}


        



        //propfull code snipt ile cikan bir kod blogudur.
        // bir adet private filed ve bir adet de public Property kodu olusturur.
        // bizlerde olusturulan private filed alanina kontrollu veri ekleme ve 
        //kontrollu veri disariya verme islemlerini gerçekleştiririz
        private string _tcno;
        private string Email;
        public string Email2 { 
            get { return Email; }

            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Email Alani Boş Olamaz");


                }
                else if (!value.Contains("@"))
                {
                    throw new Exception("Email düzgün formatta degil");

                }
                Email = value;
            } 
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new Exception("Email Alani Boş Olamaz");


            }
            else if (!email.Contains("@"))
            {
                throw new Exception("Email düzgün formatta degil");

            }

        }
        public int AyakkabiNumarasi 
        {
            get { return _ayakkabiNumarasi; }
            set 
            { 
                if (value < 15 || value >50)
                {
                    throw new Exception("Cocuk Ayakkabi numarasi 15 den kucuk 50 den buyuk olamaz");
                }
                else
                {
                    _ayakkabiNumarasi = value;
                }
            
            } 
        
        }
        private int _ayakkabiNumarasi;
        public string TCNO
        {
            get { return _tcno.Substring(7); }
            set { 

                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("TcNo Boş Olamaz");
                }
                else if (value.Length != 11)
                {

                    throw new Exception("TcNo 11 Karakter Olmalidir");
                }
                else
                {
                    foreach (var ch in value)
                    {
                        if (!Char.IsDigit(ch))
                        {
                            throw new Exception("TcNo numarasi sayisal  Olmalidir");
                        }
                    }

                    _tcno = value;
                }
            
            }
        }

        public string Ad {
            get {
                return _name;
            }
                
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name= value;
                }
            } 
        }
        public string Soyad { get; set; }

        public int Boyu { get;  } // ReadOnly Property denir
        public int Kilo { get; private set; } // Class harici ReadOnly
        public bool Cinsiyeti { private get; set; } // Class harici WriteOnly

        public int Yas { set { } }  // Write Only Property denir
        public string KrediKartiBilgisiAta { set { } }// Write Only Property denir
        #endregion
        
        
        private int _biriktirdigiPara;
        private bool _guvenilirmi; // Buradaki private field alanlarina ancak class icerisinden deger atanip,okuma yapilabilir.

        //şartli geri bildirim yaptigimiz bir Encapsulation örnegi 
        // Şartli property

        #region Yetenekler
        public int BiriktirdigiPara
        {
            get
            {
                if (_guvenilirmi)
                {
                    return _biriktirdigiPara;
                }
                return 0;
            }
            set
            {
                if (value > 0)
                {
                    _biriktirdigiPara = value;
                }
            }
        }
        public void HarclikAl(int harclik)
        {
            if (harclik < 5)
            {
                throw new Exception("Baba beni mi kandiriyorsun");
            }
            else if (harclik < 50)
            {
                throw new Exception("Baba sadaka mi veriyorsun");

            }
            _biriktirdigiPara += harclik;
        }
        public void Harca(int miktar)
        {
            if (_biriktirdigiPara <= miktar)
            {
                throw new Exception("Bu kadar param yok");
            }
            _biriktirdigiPara -= miktar;
        }

        public int KacParanVar(string kimsin)
        {
            if (kimsin == "Baban")
            {
                return _biriktirdigiPara / 10;
            }
            return _biriktirdigiPara;
        } 
        #endregion

    }
}
