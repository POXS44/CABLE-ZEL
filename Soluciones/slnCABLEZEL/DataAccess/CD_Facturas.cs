using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class CD_Facturas
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
            comando.CommandText = "select *from Detalle_factura";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public void Insertar(int Num_factura, float Monto_a_pagar, string Descripcion, DateTime Fecha_Factura
          , string Usuario, int Num_contrato, string Estado)
        {


            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Detalle_factura values ('" + Num_factura + "'," +
                "," + Monto_a_pagar + "," + Descripcion + "," + Fecha_Factura + ",'" + Usuario + "','" + Num_contrato + "','"+Estado+"')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();


        }

        public void Editar(int Num_factura,  float Monto_a_pagar, string Descripcion, DateTime Fecha_Factura
          , string Usuario, int Num_contrato,string Estado)
        {


            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarFacturas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@num_factura", Num_factura);
            comando.Parameters.AddWithValue("@monto_a_pagar", Monto_a_pagar);
            comando.Parameters.AddWithValue("@descripcion", Descripcion);
            comando.Parameters.AddWithValue("@fecha_factura", Fecha_Factura);
            comando.Parameters.AddWithValue("@usuario", Usuario);
            comando.Parameters.AddWithValue("@num_contrato", Num_contrato);
            comando.Parameters.AddWithValue("@estado", Estado);
   
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();



        }


    }
}
