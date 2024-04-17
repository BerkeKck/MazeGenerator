using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_ifAtYarisi
{
    public partial class Form1 : Form
    {
       Random rnd = new Random();
        public Form1()
        {
           
            InitializeComponent();
        }
        //Yarisi Başlatma
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //Yarisi Sifirlama 
        private void button2_Click(object sender, EventArgs e)
        {
           // at1.Left = 9; at2.Left =9;at3.Left = 9;
            at1.Left = at2.Left = at3.Left = 9;
            lblDurum.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Form Load Event tetiklendi");
        }

        //Zamanlayicinin ne yapmasi gerektigi burada yazilacak
        private void timer1_Tick(object sender, EventArgs e)
        {
            at1.Left = at1.Left + rnd.Next(30, 70);
            at2.Left = at1.Left + rnd.Next(30, 70);
            at3.Left = at1.Left + rnd.Next(30, 70);
            //lblDurum.Text = "Atin X Konumu :"+at1.Left.ToString() + " Y Konumu:" + at1.Right;
            //lblDurum.Text = $"At1 X Konumu :{at1.Left.ToString()}  Y Konumu:{at1.Right} ";

            // Region Almanin Kisa Yolu : Ctrl + k + s
            #region Atlarin Durumu. Kim Onde ?
            if (at1.Left > at2.Left && at1.Left > at3.Left)
            {
                lblDurum.Text = $"At1 Önde Gidiyor . Konumu :{at1.Left.ToString()}  Y Konumu:{at1.Right} ";
            }
            else if (at2.Left > at1.Left && at2.Left > at3.Left)
            {
                lblDurum.Text = $"At2 Önde Gidiyor . Konumu :{at1.Left.ToString()}  Y Konumu:{at1.Right} ";

            }
            else
            {
                lblDurum.Text = $"At3 Önde Gidiyor . Konumu :{at1.Left.ToString()}  Y Konumu:{at1.Right} ";

            } 
            #endregion
            
            if (at1.Left + at1.Width >= lblFinis.Left)
            {
                timer1.Stop();
                MessageBox.Show("Birinci At Kazandi");
            }
            else if (at2.Left + at2.Width >= lblFinis.Left)
            {
                timer1.Stop();
                MessageBox.Show("Ikinc At Kazandi");
            }
            else if (at3.Left + at3.Width >= lblFinis.Left)
            {
                timer1.Stop();
                MessageBox.Show("Ucuncu  At Kazandi");
            }
        }
    }
}
