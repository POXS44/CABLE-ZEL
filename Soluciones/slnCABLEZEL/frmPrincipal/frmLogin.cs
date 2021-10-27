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
using Dominio;
using frmPrincipal;

namespace frmLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "") {
                txtUsuario.Text = "USUARIO";
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.UseSystemPasswordChar = false;

            }
        }

   

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "USUARIO") {
                if (txtContraseña.Text != "CONTRASEÑA")
                {
                    UserModel user = new UserModel();
                    var validarLogin = user.LoginUser(txtUsuario.Text, txtContraseña.Text);
                    if (validarLogin == true)
                    {
                        frmPrincipal.frmPrincipal mainMenu = new frmPrincipal.frmPrincipal();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                        
                    }
                   
                    else
                    {
                        msgError("Usuario o Contraseña Incorrecta. \n Por favor intente nuevamente.");
                        txtUsuario.Text="Usuario";
                        txtUsuario.Focus();
                    }
                }
                else msgError("No se mula y ingrese su Contraseña");
            }
            else msgError("No se mula y ingrese su nombre de Usuario");
        }

        private void msgError (string msg)
        {
            lblErrorMessage.Text ="   "+ msg;
            lblErrorMessage.Visible = true;
        }

        //metodo para cerrar sesion
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtContraseña.Text = "Contraseña";
            txtContraseña.UseSystemPasswordChar = false;
           txtUsuario.Text = "Usuario";
            lblErrorMessage.Visible = false;
            this.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblErrorMessage_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoverPassword = new frmRecuperarContraseña();
            recoverPassword.ShowDialog();
        }
    }
}