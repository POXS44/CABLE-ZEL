using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Common.Cache;

namespace frmPrincipal
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 225)
            {
                panel1.Width = 68;
            }
            else
                panel1.Width = 225;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to log out?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }



        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmClientes());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmContrato());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LoadUserData();
            //Roles pemisos

            if (UserLoginCache.Rol == Roles.Facturador) 
            { btnClientes.Enabled = false;
              btnContratos.Enabled = false;
                btnUsuarios.Enabled = false;
                btnGestiones.Enabled = false;
            }
        }

        private void LoadUserData()
        {
            lblNombre.Text = UserLoginCache.Nombre;
            lblApellido.Text = UserLoginCache.Apellido;
            lblCorreo.Text = UserLoginCache.Email;
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmUsuarios());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmClientes());
        }

        internal class BuscadorDataSet
        {
            internal object Clientes;
        }

    
        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmFacturas());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to log out?", "Warning",
         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmGestiones());
        }
    }
    
}
