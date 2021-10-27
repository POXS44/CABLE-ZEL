using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataAccess;

namespace Dominio
{
   public class CN_Contratos
    {
        private CD_Contratos contratosCD = new CD_Contratos();

        public DataTable MostrarCon()
        {

            DataTable tabla = new DataTable();
            tabla = contratosCD.Mostrar();
            return tabla;
        }

        public void InsertarCon(string fecha_contrato, string descripcion, string estado, string cant_televisores, string cod_barrio, 
            string tipo_contrato , string num_cedula, string usuario, string entidad) {

            contratosCD.Insertar(Convert.ToDateTime(fecha_contrato),descripcion,estado,Convert.ToInt32(cant_televisores),
                Convert.ToInt32(cod_barrio),Convert.ToInt32(tipo_contrato),num_cedula,usuario,entidad);
        
        }

        public void EditarCon( string num_contrato,string fecha_contrato, string descripcion, string estado, string cant_televisores,
            string cod_barrio, string tipo_contrato, string num_cedula, string usuario, string entidad) {


            contratosCD.Editar(Convert.ToInt32(num_contrato),Convert.ToDateTime(fecha_contrato), descripcion, estado, Convert.ToInt32(cant_televisores),
                Convert.ToInt32(cod_barrio), Convert.ToInt32(tipo_contrato), num_cedula, usuario, entidad);
        }


    }
}
