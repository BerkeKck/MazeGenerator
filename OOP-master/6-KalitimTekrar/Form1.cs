using System.Data;
using System.Data.SqlClient;

namespace _6_KalitimTekrar
{
    public partial class Form1 : Form
    {
        SqlConnection _conn; //SqlServer'a baglanmak icin Gerekli
        SqlCommand _command; // Baglati uzerinden sorgu calistirmak icin gerekli
        SqlDataReader _reader; // Command nesnesi uzerinde okuma yapmak icin gerekli
        string _sql, constr = "Server=.;Database=Northwind;Trusted_Connection=True;";

        SqlDataAdapter _adapter;
        DataSet northwindDs = new DataSet();


        List<Shipper> Shippers = new List<Shipper>();
        //Connection String Nedir:
        // HErhangi bir database e baglanmak istedigimizde bu veri tabani ile ilgili bilgiler iceren 
        // ve ";" ile ayrilmis bir soz dizimidir

        // Ornek 
        // constr = "server=.;"



        //Yapici Metod
        public Form1()
        {
            _conn = new SqlConnection(constr);

            InitializeComponent();
        }


        //Event
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _conn.Open();
                //MessageBox.Show("Baglati baþarili");
                _sql = "Select * from Shippers";
                _command = new SqlCommand(_sql, _conn);
                _reader = _command.ExecuteReader();
                while (_reader.Read())
                {
                    listBox1.Items.Add(_reader["ShipperID"] + " " + _reader["CompanyName"] + " " + _reader["Phone"] + " ");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                _conn?.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _conn.Open();
                //MessageBox.Show("Baglati baþarili");
                _sql = "Select * from Shippers";
                _command = new SqlCommand(_sql, _conn);
                _reader = _command.ExecuteReader();
                while (_reader.Read())
                {
                    Shipper shipper = new Shipper();
                    shipper.ShipperID = int.Parse(_reader[0].ToString());
                    shipper.CompanyName = _reader[1].ToString();
                    shipper.Phone = _reader[2].ToString();
                    Shippers.Add(shipper);


                }

                dataGridView1.DataSource = Shippers;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                _conn?.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _adapter = new SqlDataAdapter("select * from shippers", _conn);
            //_adapter.Fill(northwindDs);
            //dataGridView1.DataSource = northwindDs.Tables[0];


            #region DataAdapTor kullanimi 2. Yol
            //2. Kullanimi 
            //_adapter.Fill(northwindDs,"Shippers");
            //dataGridView1.DataSource = northwindDs.Tables["Shippers"];

            #endregion

            #region Birden Fazla Tabloyu cekmek
            listBox1.Items.Clear();

            _adapter.Fill(northwindDs, "Shippers");
            listBox1.Items.Add("Shippers");

            _adapter.SelectCommand.CommandText = "Select * from products";
            _adapter.Fill(northwindDs, "Products");
            listBox1.Items.Add("Products");

            _adapter.SelectCommand.CommandText = "Select * from Customers";
            _adapter.Fill(northwindDs, "Customers");
            listBox1.Items.Add("Customers");

            dataGridView1.DataSource = northwindDs.Tables["Customers"];

            #endregion
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(listBox1.SelectedItem.ToString());
            dataGridView1.DataSource = northwindDs.Tables[listBox1.SelectedItem.ToString()];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
