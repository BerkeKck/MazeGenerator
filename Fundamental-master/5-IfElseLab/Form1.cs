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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
          * MANTIKSAL OPERATORLER
          * Birden fazla durumun ayni anda kontrol edilmesi senaryosunda kullanilan operatorlerdir...
          * && (VE) (Kontrol blogu icerisinde yer alan tum kosullarin saglanmasi durumuna isaret eder...
          * Kosullardan biri dahi saglanmazsa blogunuz harekete gecmez...)
          * || (VEYA) (Kontrol blogu icerisinde yer alan kosullardan herhangi birinin saglanmasi durumuna isaret eder... Boylece bir kosul bile saglansa blogunuza yazdiginiz kodlar harekete gecer...) Kısayol => ALTGR + Tire
          * 
          * Yukarıdaki operatorlere "kısa devre operatoru (shortcut operator)" adi verilir.. 
          * Kosullari kontrole en soldan baslar, herhangi bir uygunsuzluk durumunda diger kosullara asla bakmaz!.. 
          
         * Asagidaki operatorlerde ise, kosullar uysun ya da uymasin hepsi kontrol edilir...
          * == Kıyaslama Operatoru. Eşit olup olmama durumuna bakar
          * & => VE
          * | => VEYA
          * != Degildir
          */
        private void btnGiris_Click(object sender, EventArgs e)
        {
            //username : admin password = 123 olarak kontrol edilecek

            string userName = textBox1.Text;
            string password = textBox2.Text;

            if (userName == "admin" && password == "123")
            {
                MessageBox.Show("Hoşgeldin Admin");
            }
            else
            {
                MessageBox.Show("UserName Yada Şifre Hatalidir");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // girilen textbox1 deki not
            // 0-29 arasinda "FF"
            // 30-49 arasinda "DD"
            // 50-69 arasinda "BB"
            // 70-100 arasinda "AA"
            // olacak sekilde kullaniciya bilgi veriniz
            int not = int.Parse(textBox1.Text);
            if (not < 30)
            {
                MessageBox.Show("Notunuz FF");
            }
            else if (not < 50 && not >= 30)
            {
                MessageBox.Show("Notunuz DD");
            }
            else if (not < 70 && not >= 50)
            {
                MessageBox.Show("Notunuz BB");
            }
            else if (not >= 70)
            {
                MessageBox.Show("Notunuz AA");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Disaridan urun adi girilecek, kasiyer bize urunun hangi reyonda oldugunu soyleyecek...
            //Domates, Biber, Patlican => Sebze Reyonu
            //Diş Macunu, Parfüm, Şampuan => Kozmetik Reyonu
            //Cep Telefonu, Bilgisayar, Ses Sistemi => Teknoloji Reyonu
            //Başka bir ürün girilirse "Bu ürün bizde yok!" uyarisi verilsin!
            //[16:31] Erhan Gül(Konuk)
            string product = textBox1.Text;

            if (product == "domates" || product == "biber" || product == "patlican")

            {

                MessageBox.Show("sebze");

            }

            else if (product == "parfüm" || product == "şampuan")

            {

                MessageBox.Show("kozmetik reyonu");

            }

            else if (product == "cep telefonu" || product == "bilgisayar" || product == "ses sistemi")

            {

                MessageBox.Show("teknoloji reyonu");

            }

            else

            {

                MessageBox.Show("bu ürün bizde yok");

            }

        }
    }
}

