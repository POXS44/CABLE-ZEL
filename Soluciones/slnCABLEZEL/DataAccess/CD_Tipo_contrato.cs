using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
   public class CD_Tipo_contrato
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select *from Tipo_contrato";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void Insertar(string Tipo, float Costo )
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Tipo_contrato values ('" + Tipo+ "','" + Costo + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Editar(int Id_tipo_contrato ,string Tipo, float Costo )
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarTipo_contrato";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_tipo_contrato", Id_tipo_contrato);
            comando.Parameters.AddWithValue("@tipo", Tipo);
            comando.Parameters.AddWithValue("@costo", Costo);
        
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

    }
}
