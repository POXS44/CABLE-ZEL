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
    public partial class frmUsuarios : Form
    {

        CN_Usuarios usuariosCN = new CN_Usuarios();
        private string idUsuario = null;
        private bool Editar = false;

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsu();
            if (UserLoginCache.Rol == Roles.Facturador) { btnEditar.Enabled = false; }
        }

        private void MostrarUsu()
        {
            CN_Usuarios usuarios = new CN_Usuarios();
            dataGridViewUsu.DataSource = usuarios.MostrarUsu();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //Insertar
        if (Editar == false)
        {     
            try
            {
                usuariosCN.InsertarUsu(txtUsuario.Text, txtNombre.Text, txtApellido.Text, txtContraseña.Text, cmbRol.Text,txtEmail.Text);
                MessageBox.Show("Se inserto Correctamente");
                MostrarUsu();
                    limpiarForm();
            }
            catch (Exception ex) {
                MessageBox.Show("No se puedo insertar los datos por : "+ex);

            }
            }

            //Editar
            if (Editar == true) {

                try {
                    usuariosCN.EditarUsu(txtUsuario.Text, txtNombre.Text, txtApellido.Text, txtContraseña.Text, cmbRol.Text,txtEmail.Text);
                    MessageBox.Show("Se edito Correctamente");
                    MostrarUsu();
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

            if (dataGridViewUsu.SelectedRows.Count > 0)
            {
                Editar = true;
                txtUsuario.Text = dataGridViewUsu.CurrentRow.Cells["Usuario"].Value.ToString();
                txtNombre.Text = dataGridViewUsu.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dataGridViewUsu.CurrentRow.Cells["Apellido"].Value.ToString();
                txtContraseña.Text = dataGridViewUsu.CurrentRow.Cells["Contraseña"].Value.ToString();
                cmbRol.Text = dataGridViewUsu.CurrentRow.Cells["Rol"].Value.ToString();
                txtEmail.Text = dataGridViewUsu.CurrentRow.Cells["Email"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void limpiarForm() {
            txtUsuario.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtContraseña.Clear();
            txtEmail.Clear();
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewUsu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsu.SelectedRows.Count > 0)
            {
                idUsuario = dataGridViewUsu.CurrentRow.Cells["Usuario"].Value.ToString();
                usuariosCN.EliminarUsu(idUsuario);
                MessageBox.Show("Eliminado Correctamente");
                MostrarUsu();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
