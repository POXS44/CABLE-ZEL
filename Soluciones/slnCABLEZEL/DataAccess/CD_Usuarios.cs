using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
   public class CD_Usuarios
    {

        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select *from Usuarios";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public void Insertar(string Usuario, string Nombre, string Apellido, string Contraseña, string Rol,string Email)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Usuarios values ('" + Usuario + "','" + Nombre + "','" + Apellido + "','" + Contraseña + "','" + Rol + "','"+Email+"')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Editar(string Usuario, string Nombre, string Apellido, string Contraseña, string Rol,string Email)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario",Usuario);
            comando.Parameters.AddWithValue("@nombre",Nombre);
            comando.Parameters.AddWithValue("@apellido",Apellido);
            comando.Parameters.AddWithValue("@contraseña",Contraseña);
            comando.Parameters.AddWithValue("@rol",Rol);
            comando.Parameters.AddWithValue("@email",Email);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Eliminar(string Usuario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", Usuario);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();

        }
    }
    
}
