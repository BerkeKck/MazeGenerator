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

   
    

    

   

    public partial class SayiTahmin : Form
    {
        // Program Calistiginda 1-50 arasinda bir sayi bilgisayar tutacak.
        // Ekrandan 5 kere tahmin hakki istenecek.
        // lblMesaj Text'ine Eger tutulan sayidan daha buyuk bir deger girdi ise 
        // Daha kucuk bir sayi giriniz mesaji ,
        // Tersi durumda ise daha buyuk sayi giriniz mesaji yazdirilacak.
        // Ekranda tahmin hakkini gosteren bir lable'da olsun
        Random random = new Random();
        int tutulanSayi, tahminHakki = 5;
        public SayiTahmin()
        {
            InitializeComponent();
        }

        private void SayiTahmin_Load(object sender, EventArgs e)
        {
            // Next Metodundaki birinci parametre dahil , ikinci parametredeki
            // sayinin bir eksigine kadar rastgele sayi uretir.
            tutulanSayi = random.Next(1, 51);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Normal sekilde integer yanliş formatta girilmiş ise 
            //Asagidaki kod hata verecektir.
            //int sayi = int.Parse(textBox1.Text);
            
            if (tahminHakki > 0)
            {


                int cevrilenSayi;
                

                bool oldumu = int.TryParse(textBox1.Text, out cevrilenSayi);
                // Eger Cevirme islemi true yani olumlu ise
                if (oldumu)
                {
                    if (tutulanSayi == cevrilenSayi)
                    {
                        lblMesaj.Text = $"Tebrikler {6 - tahminHakki} . denemede buldunuz !!";
                        tahminHakki = 5;
                        textBox1.Text = "";
                    }
                    else if (tutulanSayi > cevrilenSayi)
                    {
                        #region ++ Ve  --
                        //tahminHakki = tahminHakki - 1; 
                        //tahminHakki = tahminHakki - 1; 
                        //tahminHakki++; //tahminHakki = tahminHakki +1;

                        //tahminHakki *= 3;
                        //tahminHakki = cevrilenSayi++;
                        //tahminHakki = ++cevrilenSayi; 
                        #endregion

                        lblMesaj.Text = $" Daha buyuk  bir sayi  giriniz";
                        lblMesaj.BackColor = Color.Red;

                    }
                    else
                    {

                        lblMesaj.Text = $" Daha küçük  bir sayi  giriniz";
                        lblMesaj.BackColor = Color.Green;
                    }
                }
                else
                {
                    MessageBox.Show("Duzgun Formatta deger giriniz");
                }
                lblTahmin.Text = $"Kalan Tahmin Hakkiniz {tahminHakki}";

            }
            else
            {
                lblMesaj.Text = "Tahmin Hakkiniz Bitmistir.";
                textBox1.Text = "";
            }
            tahminHakki--;
            //Asagida carpilan iki sayinin sonucunun string degeri elde edilir
            //MessageBox.Show((sayi * sayi).ToString());
        }
    }
}
