using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_KalitimTekrar
{
    public partial class ProductCrud : BaseForm
    {
        public ProductCrud()
        {

            InitializeComponent();
        }

        private void ProductCrud_Load(object sender, EventArgs e)
        {
            _adapter = new System.Data.SqlClient.SqlDataAdapter("Select * from Categories", _conn);
            _adapter.Fill(northwindDs, "Categories");
            kategoriCmb.DataSource = northwindDs.Tables["Categories"];
            kategoriCmb.DisplayMember = "CategoryName";
            kategoriCmb.ValueMember = "CategoryId";
        }

        private void kategoriCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(kategoriCmb.Text);
            MessageBox.Show(kategoriCmb.SelectedValue.ToString());


        }
    }
}
