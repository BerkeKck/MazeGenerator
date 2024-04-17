using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_IfElseLab
{
    public partial class TernaryIf : Form
    {
        //Formun ilk acilis aninda 8 haneli rastgele bir sayı lblRastgeleKarakterler adli label'a yazdirilacak ve kullanicidan butona bastigi anda textbox'taki yazıyla label'daki yazının karsilastirmasi yapilacak.
        //Eger karsilastirma olumsuz ise lblKalanHakkimiz'deki deger bir azaltılacak. 
        //Eger kullanici 5 defa hatali giris yaparsa button'un aktiflik ozelligi kapatilacak...
        //Her hatali giriste yeni bir rastgele sayi turetilmelidir...

        //   button2.Enabled = false;

        Random random = new Random(); // Random Nesnesinden bir instance aliyor
        int denemeSayisi = 5;
        public TernaryIf()
        {
            InitializeComponent();
        }

        private void TernaryIf_Load(object sender, EventArgs e)
        {//Ternary If: Tek satirda bir karar mekanizmasi ile yolumuza devam etmek istiyorsak ,
         //soru isareti operatoru  ile bu pratikligi saglar. Asagidaki kod satirinin
         //kisaltilmisi Ternary If'tir
         // Kullanimi :
         // KontrolEdilecekdeger (karsilastirmaOperatoru) ? True:False 
            string deger = "";
            //if (10 < 0)
            //{
            //    deger = "Kucuktur";
            //}
            //else
            //{
            //    deger = "Buyuktur";
            //}

            deger = 10 < 0 ? "Kucuktur" : "Buyuktur";
           int rastgeleSayi= random.Next(10000000,99999999);
            lblRastgeleKarakterler.Text=rastgeleSayi.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (lblRastgeleKarakterler.Text == textBox1.Text)
            {
                MessageBox.Show("Tebrikler Basardiniz");
            }
            else
            {
                denemeSayisi = denemeSayisi - 1;
                if (denemeSayisi < 0)
                {
                    btnGiris.Enabled = false;
                    textBox1.Enabled = false;
                    MessageBox.Show("Deneme Hakkiniz Bitmistir");
                }
                else
                {
                    lblHak.Text = "Kalan Hakkiniz " + denemeSayisi.ToString();
                    int rastgeleSayi = random.Next(10000000, 99999999);
                    lblRastgeleKarakterler.Text = rastgeleSayi.ToString();
                }
               
            }
        }
    }
}
