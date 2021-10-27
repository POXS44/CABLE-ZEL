using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
   public class CD_Barrio
    {

        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select *from Barrio";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void Insertar(string Nombre_barrio )
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Barrio values ('" + Nombre_barrio + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Editar(int Cod_barrio , string Nombre_barrio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Editar_Barrio";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod_barrio", Cod_barrio);
            comando.Parameters.AddWithValue("@nombre_barrio", Nombre_barrio);
                
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
    }
}
