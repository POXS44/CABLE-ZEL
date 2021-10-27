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
    public partial class frmContrato : Form
    {
        CN_Contratos contratosCN = new CN_Contratos();
        
  
        private bool Editar = false;
        public frmContrato()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frmContrato_Load(object sender, EventArgs e)
        {
            MostrarContratos();
            LoadUserData();
        }


        private void LoadUserData()
        {
           txtUsuario.Text = UserLoginCache.Usuario;
   
        }

        private void MostrarContratos() {

            CN_Contratos objeto = new CN_Contratos();
            dgvContratos.DataSource = objeto.MostrarCon();
        
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Insertar
            if (Editar == false) { 
            try
            {
                contratosCN.InsertarCon(dtpFechacontrato.Text, txtDescripcion.Text, cmbEstado.Text, txtCantidadequipos.Text, cmbBarrio.Text,
                cmbTipocontrato.Text, txtNumcedula.Text, txtUsuario.Text, txtEntidad.Text);
                MessageBox.Show("se inserto correctamente");
                MostrarContratos();
                limpiarForm();
            }
            catch (Exception ex) {
                MessageBox.Show("No se puedo insertar los datos por : "+ex);
            }
                        }

            if (Editar == true) {
                try
                {
                    contratosCN.EditarCon(txtNum_contrato.Text, dtpFechacontrato.Text, txtDescripcion.Text, cmbEstado.Text, txtCantidadequipos.Text, cmbBarrio.Text,
                    cmbTipocontrato.Text, txtNumcedula.Text, txtUsuario.Text, txtEntidad.Text);

                    MessageBox.Show("se edito correctamente");
                    MostrarContratos();
                    limpiarForm();
                    txtUsuario.Clear();
                    LoadUserData();
                    Editar = false;
                }
                catch (Exception ex) {

                    MessageBox.Show("No se puedo Editar los datos por : " + ex);
                }
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvContratos.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNum_contrato.Text= dgvContratos.CurrentRow.Cells["Num_contrato"].Value.ToString();
                dtpFechacontrato.Text = dgvContratos.CurrentRow.Cells["Fecha_contrato"].Value.ToString();
                txtDescripcion.Text = dgvContratos.CurrentRow.Cells["Descripcion"].Value.ToString();
                cmbEstado.Text = dgvContratos.CurrentRow.Cells["estado"].Value.ToString();
                txtCantidadequipos.Text = dgvContratos.CurrentRow.Cells["cant_televisores"].Value.ToString();
                cmbBarrio.Text = dgvContratos.CurrentRow.Cells["Cod_barrio"].Value.ToString();
                cmbTipocontrato.Text = dgvContratos.CurrentRow.Cells["Id_tipo_contrato"].Value.ToString();
                txtNumcedula.Text = dgvContratos.CurrentRow.Cells["Num_cedula"].Value.ToString();
                txtUsuario.Text = dgvContratos.CurrentRow.Cells["Usuario"].Value.ToString();
                txtEntidad.Text = dgvContratos.CurrentRow.Cells["Nombre_entidad"].Value.ToString();
                
            }
            else
                MessageBox.Show("Seleccione una fila por favor ");
        }

        private void limpiarForm()
        {
            txtNum_contrato.Clear();
            txtDescripcion.Clear();
            txtCantidadequipos.Clear();
            txtNumcedula.Clear();
           
            txtEntidad.Clear();
            

        }
    }
}
