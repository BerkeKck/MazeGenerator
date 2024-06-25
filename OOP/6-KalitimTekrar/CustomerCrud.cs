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
    public partial class CustomerCrud : BaseForm
    {
        public CustomerCrud()
        {
            InitializeComponent();
        }

        private void CustomerCrud_Load(object sender, EventArgs e)
        {
            _adapter = new System.Data.SqlClient.SqlDataAdapter("Select * from customers",_conn);
            _adapter.Fill(northwindDs, "Customers");
            dataGridView1.DataSource = northwindDs.Tables["Customers"];
        }
    }
}
