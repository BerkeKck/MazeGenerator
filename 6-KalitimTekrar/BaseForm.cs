using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_KalitimTekrar
{
    public partial class BaseForm : Form
    {
        public SqlConnection _conn; //SqlServer'a baglanmak icin Gerekli
        public SqlCommand _command; // Baglati uzerinden sorgu calistirmak icin gerekli
        public SqlDataReader _reader; // Command nesnesi uzerinde okuma yapmak icin gerekli
        public string _sql, constr = "Server=.;Database=Northwind;Trusted_Connection=True;";

        public SqlDataAdapter _adapter;
        public DataSet northwindDs = new DataSet();


        public List<Shipper> Shippers = new List<Shipper>();
        public BaseForm()
        {
            _conn = new SqlConnection(constr);
            //InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
