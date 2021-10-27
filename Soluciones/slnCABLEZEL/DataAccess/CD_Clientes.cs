using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DataAccess
{
    public class CD_Clientes
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        SqlDataAdapter Da;
        DataTable Dt;

        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select *from Clientes";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void Insertar(string Num_cedula, string Primer_nombre, string Segundo_nombre, string Primer_Apellido, string Segundo_Apellido,
                                string Num_Telefono, string Direccion, int Cod_barrio)
        {
          
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Clientes values ('" + Num_cedula + "','" + Primer_nombre + "','" + Segundo_nombre + "','" + Primer_Apellido + "','" + Segundo_Apellido + "','" + Num_Telefono + "','" + Direccion + "'," + Cod_barrio + ")";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

      

        public void Editar(string Num_cedula, string Primer_nombre, string Segundo_nombre, string Primer_Apellido, string Segundo_Apellido,
                                string Num_Telefono, string Direccion, int Cod_barrio)
        {
           
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@num_cedula",Num_cedula);
            comando.Parameters.AddWithValue("@primer_nombre",Primer_nombre);
            comando.Parameters.AddWithValue("@segundo_nombre",Segundo_nombre);
            comando.Parameters.AddWithValue("@primer_Apellido",Primer_Apellido);
            comando.Parameters.AddWithValue("@segundo_Apellido",Segundo_Apellido);
            comando.Parameters.AddWithValue("@num_Telefono",Num_Telefono);
            comando.Parameters.AddWithValue("@direccion",Direccion);
            comando.Parameters.AddWithValue("@cod_barrio",Cod_barrio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //Metodo que permite Buscar un Cliente por el Numero de cedula

        
        
        //Metodo que permite Buscar un Cliente por el Primer nombre
        
        
        
        //Metodo que permite Buscar un Cliente por el Primer Apellido


    }
}
