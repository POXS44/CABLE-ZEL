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
    public partial class frmFacturas : Form
    {

        CN_Facturas facturasCN = new CN_Facturas();

        private bool Editar = false;
        public frmFacturas()
        {
            InitializeComponent();
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            if (UserLoginCache.Rol == Roles.Facturador) { btnEditar.Enabled = false; }

                MostrarFac();
            LoadUserData();
        }

        private void MostrarFac()
        {
            CN_Facturas facturas = new CN_Facturas();
            dgbFacturas.DataSource = facturas.MostrarFac();
        }


        private void LoadUserData()
        {
            txtUsuario.Text = UserLoginCache.Usuario;

        }
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            //Insertar
            if (Editar == false)
            {
                try
                {
                    facturasCN.InsertarFac(txtNum_factura.Text,cmbEstado.Text,txtMonto.Text,txtDescripcion.Text,
                        dtpFechafactura.Text,txtUsuario.Text,txtNum_contrato.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarFac();
                    txtUsuario.Clear();
                    LoadUserData();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puedo insertar los datos por : " + ex);
                }
            }

            if (Editar == true)
            {
                try
                {
                    facturasCN.EditarFac(txtNum_factura.Text,  cmbEstado.Text, txtMonto.Text, txtDescripcion.Text,
                        dtpFechafactura.Text, txtUsuario.Text, txtNum_contrato.Text);

                    MessageBox.Show("se edito correctamente");
                    MostrarFac();
                    limpiarForm();
                  
                    Editar = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se puedo Editar los datos por : " + ex);
                }
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgbFacturas.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNum_factura.Text = dgbFacturas.CurrentRow.Cells["Num_factura"].Value.ToString();
            
                txtMonto.Text = dgbFacturas.CurrentRow.Cells["Monto_a_pagar"].Value.ToString();
                txtDescripcion.Text = dgbFacturas.CurrentRow.Cells["Descripcion"].Value.ToString();
                dtpFechafactura.Text = dgbFacturas.CurrentRow.Cells["Fecha_factura"].Value.ToString();
                txtUsuario.Text = dgbFacturas.CurrentRow.Cells["Usuario"].Value.ToString();
                txtNum_contrato.Text = dgbFacturas.CurrentRow.Cells["Num_contrato"].Value.ToString();
                cmbEstado.Text = dgbFacturas.CurrentRow.Cells["Estado"].Value.ToString();

            }
            else
                MessageBox.Show("Seleccione una fila por favor ");
        }

        private void limpiarForm()
        {
            txtNum_factura.Clear();
            txtMonto.Clear();
            txtDescripcion.Clear();
            txtUsuario.Clear();
            txtNum_contrato.Clear();
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechafactura_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
