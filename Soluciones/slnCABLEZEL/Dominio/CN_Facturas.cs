using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataAccess;



namespace Dominio
{
    public class CN_Facturas
    {
        private CD_Facturas facturasCD = new CD_Facturas();

        public DataTable MostrarFac()
        {

            DataTable tabla = new DataTable();
            tabla = facturasCD.Mostrar();
            return tabla;
        }

        public void InsertarFac(string num_factura, string monto, string descripcion, string fecha_factura,
           string usuario, string num_contrato, string estado)
        {

            facturasCD.Insertar(Convert.ToInt32(num_factura), Convert.ToInt32(monto), descripcion,
                Convert.ToDateTime(fecha_factura), usuario, Convert.ToInt32(num_contrato), estado);
              

        }

        public void EditarFac(string num_factura, string monto, string descripcion, string fecha_factura,
           string usuario, string num_contrato,string estado)
        {


            facturasCD.Editar(Convert.ToInt32(num_factura), Convert.ToInt32(monto), descripcion,
                Convert.ToDateTime(fecha_factura), usuario, Convert.ToInt32(num_contrato),estado);
        }

    }
}
