using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace Lab02DSE
{
    public class Conexion
    {
        public SqlConnection cadena()
        {
            SqlConnection cn = new SqlConnection
                (ConfigurationManager.ConnectionStrings["FernandaA"].ConnectionString);
            if(cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            else
            {
                cn.Open();
            }
            return cn;
        }
            
    }
}
