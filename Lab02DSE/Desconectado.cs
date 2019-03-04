using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referenciar las librerias de consultas
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab02DSE
{
    public class Desconectado
    {
        Conexion cnn = new Conexion();
        #region "consulta 1"
        public DataTable ListaProductos()
        {
            using (SqlDataAdapter df = new SqlDataAdapter("usp_listaProd", cnn.cadena()))
            {
                df.SelectCommand.CommandType =
                    CommandType.StoredProcedure;
                using (DataTable dt = new DataTable())
                {
                    df.Fill(dt);
                    return dt;
                }
            }
        }
        //Lista de categorias

        public void ListaCategorias(ComboBox cbo)
        {
            SqlDataAdapter df=new SqlDataAdapter("Usp_ListaCate", cnn.cadena());
            df.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            df.Fill(dt);
            //mostrar los datos en un combobox
            cbo.DataSource = dt;
            //visualizar la data en el combo
            cbo.DisplayMember = "NombreCategoria";
            //comparar el campo con uno xterno
            cbo.ValueMember = "IdCategoria";
        }

        //Lista de productos por categoria

        public DataTable ListaProductosxCategoria(int x)
        {
            using (SqlDataAdapter df = new SqlDataAdapter("Usp_BuscarProductosxCategoria", cnn.cadena()))
            {
                df.SelectCommand.CommandType = CommandType.StoredProcedure;
                df.SelectCommand.Parameters.AddWithValue("@idcar", x);
                using(DataTable dt=new DataTable())
                {
                    df.Fill(dt);
                    return dt;
                }
            }
        }
        #endregion
    }
}
