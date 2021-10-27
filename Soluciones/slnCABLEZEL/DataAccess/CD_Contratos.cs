using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace DataAccess
{
    public class CD_Contratos
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar() {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select *from Contrato";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(DateTime fecha_contrato, string descripcion, string estado,int cant_televisores,int cod_barrio,int tipo_contrato
            ,string num_cedula,string usuario, string entidad) {

      
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Contrato values ('"+fecha_contrato+"','"+descripcion+"','"+estado+"'" +
                ","+cant_televisores+","+cod_barrio+","+tipo_contrato+",'"+num_cedula+"','"+usuario+"','"+entidad+"')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            
        
        }

        public void Editar(int num_contrato,DateTime fecha_contrato, string descripcion, string estado, int cant_televisores, int cod_barrio,
            int tipo_contrato, string num_cedula, string usuario, string entidad ) {

   
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarContratos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@num_contrato", num_contrato);
            comando.Parameters.AddWithValue("@fecha_contrato",fecha_contrato);
            comando.Parameters.AddWithValue("@descripcion",descripcion);
            comando.Parameters.AddWithValue("@estad",estado);
            comando.Parameters.AddWithValue("@cant_tele",cant_televisores);
            comando.Parameters.AddWithValue("@cod_barrio",cod_barrio);
            comando.Parameters.AddWithValue("@tipo_contrato",tipo_contrato);
            comando.Parameters.AddWithValue("@num_cedula",num_cedula);
            comando.Parameters.AddWithValue("@usuario",usuario);
            comando.Parameters.AddWithValue("@entidad",entidad);
          
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();



        }

    }
}
