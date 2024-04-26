using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Constructor
{
    public class SqlBaglanti
    {
        static SqlConnection baglanti;
        private  SqlBaglanti()
        {
                
        }

        public static SqlConnection BaglatiVer()
        {
            if (baglanti == null)
            {
                baglanti = new SqlConnection();
            }
            
                return baglanti;
           
        }
    }
}
