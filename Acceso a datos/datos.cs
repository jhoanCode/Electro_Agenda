using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_a_datos
{
    public class datos
    {
       public SqlConnection conexion()
        {
            string nombre_dispositivo = "DESKTOP-OBF3EB5\\SQLEXPRESS";
            string base_de_datos = "Gestion_de_Inventario";

            SqlConnection conn = new SqlConnection($"Data Source={nombre_dispositivo}; Initial Catalog={base_de_datos}; Integrated Security = true ");
            conn.Open();

            return conn;
        }


        public SqlDataReader acceso(string sql, SqlConnection conn)
        {
            SqlCommand cmm = new SqlCommand(sql, conn);
            cmm.ExecuteNonQuery();

            SqlDataReader rg = cmm.ExecuteReader();
            return rg;
        }
    }
}
