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
using System.Data.SqlClient;
using Common.Cache;

namespace frmPrincipal
{
    public partial class frmClientes : Form
    {

        CN_Clientes objetoCN = new CN_Clientes();
        private bool Editar = false;

        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Insertar
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarPRod(txtCedula.Text, txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text,
                   txtTelefono.Text, txtDireccion.Text, cmbBarrio.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarProdctos();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //Editar
            if (Editar == true)
            {

                try
                {
                    objetoCN.EditarCli(txtCedula.Text, txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text,
                    txtTelefono.Text, txtDireccion.Text, cmbBarrio.Text);
                    MessageBox.Show("se edito correctamente");
                    MostrarProdctos();
                    Editar = false;
                    limpiarForm();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se puedo Editar los datos por : " + ex);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtCedula.Text = dataGridView1.CurrentRow.Cells["Num_cedula"].Value.ToString();
                txtPrimerNombre.Text = dataGridView1.CurrentRow.Cells["Primer_nombre"].Value.ToString();
                txtSegundoNombre.Text = dataGridView1.CurrentRow.Cells["Segundo_nombre"].Value.ToString();
                txtPrimerApellido.Text = dataGridView1.CurrentRow.Cells["Primer_Apellido"].Value.ToString();
                txtSegundoApellido.Text = dataGridView1.CurrentRow.Cells["Segundo_Apellido"].Value.ToString();
                txtTelefono.Text = dataGridView1.CurrentRow.Cells["Num_Telefono"].Value.ToString();
                txtDireccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                cmbBarrio.Text = dataGridView1.CurrentRow.Cells["Cod_barrio"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void MostrarProdctos()
        {
            CN_Clientes objeto = new CN_Clientes();
            dataGridView1.DataSource = objeto.MostrarProd();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void limpiarForm()
        {
            txtCedula.Clear();
            txtPrimerNombre.Clear();
            txtSegundoNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        { 
            MostrarProdctos();
           

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    
}
