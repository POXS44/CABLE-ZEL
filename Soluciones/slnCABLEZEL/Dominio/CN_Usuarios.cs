using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataAccess;


namespace Dominio
{
   public class CN_Usuarios
    {
        private CD_Usuarios usuariosCD = new CD_Usuarios();

        public DataTable MostrarUsu()
        {

            DataTable tabla = new DataTable();
            tabla = usuariosCD.Mostrar();
            return tabla;
        }

        public void InsertarUsu(string Usuario, string Nombre, string Apellido, string Contraseña, string Rol,string Email)
        {

            usuariosCD.Insertar(Usuario, Nombre, Apellido, Contraseña, Rol,Email);
        }

        public void EditarUsu(string Usuario, string Nombre, string Apellido, string Contraseña, string Rol, string Email)
        {
            usuariosCD.Editar(Usuario, Nombre, Apellido, Contraseña, Rol, Email);  
        }

        public void EliminarUsu(string Usuario)
        {

            usuariosCD.Eliminar(Usuario);
        }

    }
}
