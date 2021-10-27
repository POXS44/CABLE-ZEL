using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DataAccess;

namespace Dominio
{
    public class CN_Clientes
    {
        private CD_Clientes objetoCD = new CD_Clientes();

        public DataTable MostrarProd()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarPRod (string Num_cedula, string Primer_nombre, string Segundo_nombre, string Primer_Apellido, string Segundo_Apellido,
                                string Num_Telefono, string Direccion, string Cod_barrio){
           
            objetoCD.Insertar(Num_cedula, Primer_nombre, Segundo_nombre, Primer_Apellido, Segundo_Apellido, Num_Telefono, Direccion,
                              Convert.ToInt32(Cod_barrio));
        }

        public void EditarCli(string Num_cedula, string Primer_nombre, string Segundo_nombre, string Primer_Apellido, string Segundo_Apellido,
                                string Num_Telefono, string Direccion, string Cod_barrio) {

            objetoCD.Editar(Num_cedula, Primer_nombre, Segundo_nombre, Primer_Apellido, Segundo_Apellido, Num_Telefono, Direccion,
                              Convert.ToInt32(Cod_barrio));
            
        }



}
}
