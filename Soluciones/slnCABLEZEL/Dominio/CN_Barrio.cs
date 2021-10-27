using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataAccess;


namespace Dominio
{
   public class CN_Barrio
    {
        private CD_Barrio BarrioCD = new CD_Barrio();

        public DataTable MostrarBarrio()
        {

            DataTable tabla = new DataTable();
            tabla = BarrioCD.Mostrar();
            return tabla;
        }

        public void InsertarBarrio(string Nombre_barrio)
        {
            BarrioCD.Insertar(Nombre_barrio);
        }

        public void EditarBarrio(string Cod_barrio, string Nombre_barrio)
        {
            BarrioCD.Editar(Convert.ToInt32(Cod_barrio), Nombre_barrio);
        }

    }
}
