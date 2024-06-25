using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_IfElseLab
{
    public partial class FormLab : Form
    {
        // Ekrandan 0-24 bir sayi aliniz 
        // 4-11 arasi ise => Sabah 
        // 11-14 arasi ise => oglen
        // 14-19 Ikindi
        // 19-22 arasi aksam
        // 22-4 arasi gece
        public FormLab()
        {
            InitializeComponent();
        }

        private void FormLab_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 4-11 arasi ise => Sabah 
            // 11-14 arasi ise => oglen
            // 14-19 Ikindi
            // 19-22 arasi aksam
            // 22-4 arasi gece
            int sayi;
            bool durum = int.TryParse(textBox1.Text, out sayi);
            //Eger girilen textbox icerisindeki deger integer'a cevrildimi kontrolu 
            if (durum) // true 
            {
                if ((sayi <= 24 && sayi >= 0))
                {
                    if (sayi >= 4 && sayi < 11)
                    {
                        lblMesaj.Text = "Sabah";
                    }
                    else if (sayi >= 11 && sayi < 14)
                    {

                        lblMesaj.Text = "Oglen";
                    }
                    else if (sayi >= 14 && sayi < 19)
                    {

                        lblMesaj.Text = "Ikindi";
                    }
                    else if (sayi >= 19 && sayi < 22)
                    {

                        lblMesaj.Text = "Aksam";
                    }
                    else
                    {

                        lblMesaj.Text = "Gece";

                    }
                }
                else
                {
                    lblMesaj.Text = "Aralik Dışı deger";
                }
            }
            else
            {
                lblMesaj.Text = "Lütfen sayi Giriniz";
                textBox1.Text = "";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 4-11 arasi ise => Sabah 
            // 11-14 arasi ise => oglen
            // 14-19 Ikindi
            // 19-22 arasi aksam
            // 22-4 arasi gece
            int sayi;
            bool durum = int.TryParse(textBox1.Text, out sayi);
            //Eger girilen textbox icerisindeki deger integer'a cevrildimi kontrolu 
            //case int n when (saat >= 4 && saat <= 11):
            //    Console.WriteLine("Sabah"); break;
            if (durum) // true 
            {
                switch (sayi)
                {
                    case int n when (n >= 4 && n < 11):
                        lblMesaj.Text = $"{n} Sabah";
                        break;

                    case int n when (n >= 11 && n < 14):
                        lblMesaj.Text = $"{n} Oglen";
                        break;
                    case int n when (n >= 14 && n < 19):
                        lblMesaj.Text = $"{n} Oglen";
                        break;
                    case int n when (n >= 19 && n < 22):
                        lblMesaj.Text = $"{n} Aksam";
                        break;
                }
            }
            else
            {

            }
        }
    }
}
