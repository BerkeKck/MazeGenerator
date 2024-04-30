using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_TekrarDersi
{
    public class KargocularService :IKargocular
    {
        //Readonly degisken ancak tanimlandigi yerde yada 
        //Constructor icerisinde new'lenir
         readonly SqlConnection sqlcon;
         string constr = @"Server=.;Database=Northwind;Trusted_Connection=True;";
         string sql;
         SqlCommand cmd;
         SqlDataReader reader;
        public KargocularService()
        {
            sqlcon = new SqlConnection(constr);
        }

        public bool Ekle(string companyName, string phone)
        {
            bool oldumu=false;
            try
            {
                sql = $"insert into shippers (companyname,phone) values ('{companyName}','{phone}')";
                cmd = new SqlCommand(sql, sqlcon);
                sqlcon.Open();
                int sonuc = cmd.ExecuteNonQuery();
                if (sonuc > 0) oldumu = true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           finally  
            { 
                sqlcon.Close(); 
            }
            return oldumu;
        }

        public Shipper Getir(int shipperId)
        {
            Shipper shipper = new Shipper();
            try
            {
                sql = $"select * from shippers where shipperId={shipperId}";
                cmd = new SqlCommand(sql, sqlcon);
                sqlcon.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    
                    shipper.ShipperID = int.Parse(reader["ShipperID"].ToString());
                    shipper.CompanyName = reader["CompanyName"].ToString();
                    shipper.Phone = reader["Phone"].ToString();
                  
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return shipper;
        }

        public Shipper Getir(string companyName)
        {
            Shipper shipper = new Shipper();
            try
            {
                sql = $"select * from shippers where shipperId={companyName}";
                cmd = new SqlCommand(sql, sqlcon);
                sqlcon.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    shipper.ShipperID = int.Parse(reader["ShipperID"].ToString());
                    shipper.CompanyName = reader["CompanyName"].ToString();
                    shipper.Phone = reader["Phone"].ToString();

                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return shipper;
        }

        public bool Guncelle(int id,string companyName, string phone)
        {
            bool oldumu = false;
            try
            {
                sql = $"update  shippers set CompanyName ='{companyName}',phone='{phone}' where ShipperId={id}";
                cmd = new SqlCommand(sql, sqlcon);
                sqlcon.Open();
                int sonuc = cmd.ExecuteNonQuery();
                if (sonuc > 0) oldumu = true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return oldumu;
        }

        public List<Shipper> KargoculariGetir()
        {
            List<Shipper> liste = new List<Shipper>();
            try
            {
                sql = $"select * from shippers";
                cmd = new SqlCommand(sql, sqlcon);
                sqlcon.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Shipper shipper = new Shipper();
                    shipper.ShipperID = int.Parse(reader["ShipperID"].ToString());
                    shipper.CompanyName = reader["CompanyName"].ToString();
                    shipper.Phone = reader["Phone"].ToString();
                    liste.Add(shipper);
                }
              
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return liste;
        }

        public bool Sil(int shipperId)
        {
            bool oldumu = false;
            try
            {
                sql = $"delete Shippers where shipperId = {shipperId})";
                cmd = new SqlCommand(sql, sqlcon);
                sqlcon.Open();
                int sonuc = cmd.ExecuteNonQuery();
                if (sonuc > 0) oldumu = true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return oldumu;
        }

        public List<Siparis> SiparisGetir(int shipperId, int? yil = null)
        {
            sql = $@"SELECT OrderId,CustomerID,EmployeeID,OrderDate,ShipCountry,ShipCity
                  FROM [Northwind].[dbo].[Orders]
                inner join Shippers on Shippers.ShipperID = Orders.ShipVia
                where ShipperID={shipperId}";
            if (yil != null)
            {
                sql = sql + $" and year(OrderDate)={yil}";

            }
            List<Siparis> liste = new List<Siparis>();
            try
            {
               
                cmd = new SqlCommand(sql, sqlcon);
                sqlcon.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Siparis shipper = new Siparis();
                    shipper.OrderId = int.Parse(reader["OrderId"].ToString());
                    shipper.CustomerId= reader["CustomerId"].ToString();
                    shipper.EmployeeID= int.Parse(reader["employeeId"].ToString());
                    shipper.Orderdate = DateTime.Parse(reader["Orderdate"].ToString());
                    shipper.Shipcity= reader["ShipCity"].ToString();
                    shipper.ShipCountry = reader["ShipCountry"].ToString();
                    liste.Add(shipper);
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return liste;
        }
    }
}
