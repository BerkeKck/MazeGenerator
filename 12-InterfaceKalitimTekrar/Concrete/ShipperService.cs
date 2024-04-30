using _12_InterfaceKalitimTekrar.Abstract;
using _12_InterfaceKalitimTekrar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceKalitimTekrar.Concrete
{
    public class ShipperService : BaseService,IShipperService
    {
       

        #region Get
        public Shipper? GetShipper(int id)
        {

            Shipper shipper = new Shipper();
            Sql = $"Select * from Shippers where shipperId={id}";
            try
            {
                Command = new System.Data.SqlClient.SqlCommand(Sql, SqlConnection);
                if (SqlConnection.State != System.Data.ConnectionState.Open)
                {
                    SqlConnection.Open();
                }
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    shipper.ShipperId = Reader.GetInt32(0);
                    shipper.CompanyName = Reader.GetString(1);
                    shipper.Phone = Reader.GetString(2);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata:" + ex.Message);
            }
            finally
            {
                if (SqlConnection.State != System.Data.ConnectionState.Closed)
                {
                    SqlConnection.Close();
                }
            }
            return shipper;
        }

        public List<Shipper> GetShipperList()
        {
            List<Shipper> shippers = new List<Shipper>();
            Sql = $"Select * from Shippers  ";
            try
            {
                Command = new System.Data.SqlClient.SqlCommand(Sql, SqlConnection);
                if (SqlConnection.State != System.Data.ConnectionState.Open)
                {
                    SqlConnection.Open();
                }
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Shipper shipper = new Shipper();
                    shipper.ShipperId = Reader.GetInt32(0);
                    shipper.CompanyName = Reader.GetString(1);
                    shipper.Phone = Reader.GetString(2);
                    shippers.Add(shipper);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata:" + ex.Message);
            }
            finally
            {
                if (SqlConnection.State != System.Data.ConnectionState.Closed)
                {
                    SqlConnection.Close();
                }
            }
            return shippers;
        }

        public List<ShipperOrders> GetShipperOrdersList(int shipperID,int? year)
        {
            List<ShipperOrders> shippers = new List<ShipperOrders>();
            Sql = $@" SELECT OrderId,CustomerID,EmployeeID,OrderDate,ShipCountry,ShipCity
                FROM   [Northwind].[dbo].[Orders] 
                inner join Shippers on Shippers.ShipperID = Orders.ShipVia    
                where ShipperID={shipperID} ";
            if (year != null|| year>1995)
            {
                Sql = Sql + $" and year(OrderDate)={year}";
            }
            try
            {
                Command = new System.Data.SqlClient.SqlCommand(Sql, SqlConnection);
                if (SqlConnection.State != System.Data.ConnectionState.Open)
                {
                    SqlConnection.Open();
                }
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    ShipperOrders shipper = new ShipperOrders();
                    shipper.OrderId = Reader.GetInt32(0);
                    shipper.CustomerID = Reader.GetString(1);
                    shipper.EmployeeID = Reader.GetInt32(2);
                    shipper.OrderDate=Reader.GetDateTime(3);
                    shipper.ShipCity = Reader.GetString(4);
                    shipper.ShipCountry = Reader.GetString(5);
                    shippers.Add(shipper);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata:" + ex.Message);
            }
            finally
            {
                if (SqlConnection.State != System.Data.ConnectionState.Closed)
                {
                    SqlConnection.Close();
                }
            }
            return shippers;
        }
        #endregion


    }
}
