using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataAccess;

namespace Dominio
{
    public class CN_Tipo_contrato
    {
        private CD_Tipo_contrato Tipo_contratoCD = new CD_Tipo_contrato();

        public DataTable MostrarTipo()
        {

            DataTable tabla = new DataTable();
            tabla = Tipo_contratoCD.Mostrar();
            return tabla;
        }

        public void InsertarTipo(string Tipo ,  string Costo)
        {
            Tipo_contratoCD.Insertar(Tipo,Convert.ToInt32(Costo));
        }
 
        public void EditarTipo(string Id_tipo_contrato , string Tipo , string Costo)
        {
            Tipo_contratoCD.Editar(Convert.ToInt32(Id_tipo_contrato), Tipo, Convert.ToInt32(Costo));
        }





    }
}
