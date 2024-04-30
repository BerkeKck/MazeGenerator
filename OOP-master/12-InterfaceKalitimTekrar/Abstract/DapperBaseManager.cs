using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace _12_InterfaceKalitimTekrar.Abstract
{
    public abstract class DapperBaseManager 
    {
        public SqlConnection Connection  { get;  }
        private string constr = @"server=.;Database=Northwind;Trusted_Connection=true;";
        public DapperBaseManager()
        {
                Connection = new SqlConnection(constr);
        }
        public int ExecuteNonQuery(string sql)
        {
           return  Connection.Execute(sql);
        }
    }
}
