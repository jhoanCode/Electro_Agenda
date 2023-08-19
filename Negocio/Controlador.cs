using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_a_datos;
using Guna.UI2.WinForms.Suite;

namespace Negocio
{
    public class Controlador
    {

        public void insertar(string nombre , string nn , string date , string direc , string gene , string esta , string mo , string tel) {

            datos connn = new datos();

            SqlConnection conn = connn.conexion();


            string sql = $"insert into Agenda(Nombre,Apellido,Fecha_de_nacimiento,Dirección,Genero,Estado_civil,Móvil,Telefono) values ('{nombre}','{nn}','{date}','{direc}','{gene}','{esta}','{mo}','{tel}')";


            SqlCommand cmm = new SqlCommand(sql, conn);
            cmm.ExecuteNonQuery();

            conn.Close();

        }


        public void modificar(string nombre, string nn, string date, string direc, string gene, string esta, string mo, string tel , string num)
        {

            datos connn = new datos();

            SqlConnection conn = connn.conexion();



            string sql = $"UPDATE Agenda SET Nombre= '{nombre}' , Apellido= '{nn}', Fecha_de_nacimiento = '{date}' , Dirección = '{direc}' , Genero = '{gene}' , Estado_civil = '{esta}' , Móvil = '{mo}' , Telefono = '{tel}' where Id =  {num}  ";

            SqlCommand cmm = new SqlCommand(sql, conn);
            cmm.ExecuteNonQuery();

            conn.Close();
        }

        public void eliminar(string entrada)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OBF3EB5\\SQLEXPRESS01; Initial Catalog=prueva; Integrated Security = true ");
            conn.Open();



            string sql = $"DELETE FROM Agenda where Id = {entrada}";


            SqlCommand cmm = new SqlCommand(sql, conn);
            cmm.ExecuteNonQuery();

            SqlDataReader rg = cmm.ExecuteReader();
            rg.Read();

            conn.Close();
        }
        public SqlDataReader buscar(string entrada)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OBF3EB5\\SQLEXPRESS; Initial Catalog=Gestion_de_Inventario; Integrated Security = true ");
            conn.Open();

            datos salida = new datos();

            string sql = $"SELECT * FROM Productos where Id = {entrada}";


            SqlDataReader rg = salida.acceso(sql, conn);

            return rg;


     
        }



        public int buscar_correo(string entrada , string contra)
        {
            int validacion = 0 ;
            string nombre_dispositivo = "DESKTOP-OBF3EB5\\SQLEXPRESS";
            string base_de_datos = "Gestion_de_Inventario";

            SqlConnection conn = new SqlConnection($"Data Source={nombre_dispositivo}; Initial Catalog={base_de_datos}; Integrated Security = true ");
            conn.Open();

            datos salida = new datos();

            string sql = $"SELECT * FROM Usuario where Correo = '{entrada}';";



            SqlDataReader rg = salida.acceso(sql, conn);

            if (entrada != contra)
            {

  

            if (rg != null && rg.Read())
            {
                string compara = rg["Contraseña"].ToString();
                if (compara == contra)
                {
                    validacion = 2 ;
                }
                else
                {
                    validacion = 1;
                }

            }
            else
            {
                validacion = 0 ;

            }

            }
            else
            {
                validacion = 0;
            }

            return validacion;




        }


        public void insertar_usuario(string nombre, string apellido, string edad, string sexo, string correo_electronico, string contrase)
        {

            datos connn = new datos();

            SqlConnection conn = connn.conexion();


            string sql = $"insert into cuentas(nombre,apellido,edad,sexo,correo_electronico,contraseña) values ('{nombre}','{apellido}','{edad}','{sexo}','{correo_electronico}','{contrase}')";


            SqlCommand cmm = new SqlCommand(sql, conn);
            cmm.ExecuteNonQuery();

            conn.Close();

        }


        public void agregar_productos(string nombre, string descripcionn, string valor, string objeto, DateTime fecha_registro)
        {

            datos connn = new datos();

            SqlConnection conn = connn.conexion();


            string sql = $"INSERT INTO productos(nombre, descripcion, precio, cantidad) VALUES('{nombre}', '{descripcionn}', {int.Parse(valor)},{int.Parse(objeto)})";
            ;


            SqlCommand cmm = new SqlCommand(sql, conn);
            cmm.ExecuteNonQuery();

            conn.Close();

        }
        public void modificar_producto(string nombre, string descripcionn, string valor, string objeto , string id)
        {

            datos connn = new datos();

            SqlConnection conn = connn.conexion();



            string sql = $"UPDATE Productos SET nombre= '{nombre}' , descripcion= '{descripcionn}', precio = '{valor}' , cantidad = '{objeto}'  where Id =  {id}";

            SqlCommand cmm = new SqlCommand(sql, conn);
            cmm.ExecuteNonQuery();

            conn.Close();

        }
    }
}
