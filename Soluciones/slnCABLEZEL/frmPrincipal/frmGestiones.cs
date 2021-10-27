using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Common.Cache;

namespace frmPrincipal
{
    public partial class frmGestiones : Form
    {
        CN_Tipo_contrato Tipo_contrato_CN = new CN_Tipo_contrato();
        CN_Barrio Barrio_CN = new CN_Barrio();
        private bool Editar = false;
        private bool EditarB = false;
        public frmGestiones()
        {
            InitializeComponent();
        }

        private void frmGestiones_Load(object sender, EventArgs e)
        {
            MostrarTipo();
            MostrarBarrio();
            
        }
        // funcion para mostrar los barrios en el dgbBarrio
        private void MostrarBarrio()
        {
            CN_Barrio Barrio = new CN_Barrio();
            dgbBarrio.DataSource = Barrio.MostrarBarrio();
        }

        //Funcion para mostrar los tipos de contratos en el datagridview
        private void MostrarTipo()
        {
            CN_Tipo_contrato Tipo_contrato = new CN_Tipo_contrato();
            dtgTipo.DataSource = Tipo_contrato.MostrarTipo();
        }


        // guardar y editar tipo contrato
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //Insertar
            if (Editar == false)
            {
                try
                {
                    Tipo_contrato_CN.InsertarTipo(txtTipo_contrato.Text,txtCosto.Text);
                    MessageBox.Show("Se inserto Correctamente");
                    MostrarTipo();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puedo insertar los datos por : " + ex);

                }
            }

            //Editar
            if (Editar == true)
            {

                try
                {
                    Tipo_contrato_CN.EditarTipo(txtId.Text, txtTipo_contrato.Text, txtCosto.Text);
                    MessageBox.Show("Se edito Correctamente");
                    MostrarTipo();
                    limpiarForm();
                    Editar = false;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se puedo Editar los datos por : " + ex);
                }

            }
        }
        //editar tipo contrato
        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (dtgTipo.SelectedRows.Count > 0)
            {
                Editar = true;
                txtId.Text = dtgTipo.CurrentRow.Cells["Id_tipo_contrato"].Value.ToString();
                txtTipo_contrato.Text = dtgTipo.CurrentRow.Cells["Tipo"].Value.ToString();
                txtCosto.Text = dtgTipo.CurrentRow.Cells["Costo"].Value.ToString();

            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        //limpiar contrato
        private void limpiarForm()
        {
            txtId.Clear();
            txtTipo_contrato.Clear();
            txtCosto.Clear();

        }

        private void limpiarFormB()
        {
            txtCod_barrio.Clear();
            txtBarrio.Clear();
           

        }

        private void btnGuardarb_Click(object sender, EventArgs e)
        {

            //Insertar
            if (EditarB == false)
            {
                try
                {
                    Barrio_CN.InsertarBarrio( txtBarrio.Text);
                    MessageBox.Show("Se inserto Correctamente");
                    MostrarBarrio();
                    limpiarFormB();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puedo insertar los datos por : " + ex);

                }
            }

            //Editar
            if (EditarB == true)
            {

                try
                {
                    Barrio_CN.EditarBarrio(txtCod_barrio.Text, txtBarrio.Text);
                    MessageBox.Show("Se edito Correctamente");
                    MostrarBarrio();
                    limpiarFormB();
                    EditarB = false;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se puedo Editar los datos por : " + ex);
                }

            }
        }

        private void btnEditarb_Click(object sender, EventArgs e)
        {
            if (dgbBarrio.SelectedRows.Count > 0)
            {
                EditarB = true;
                txtCod_barrio.Text = dgbBarrio.CurrentRow.Cells["Cod_barrio"].Value.ToString();
                txtBarrio.Text = dgbBarrio.CurrentRow.Cells["Nombre_barrio"].Value.ToString();
                

            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}

