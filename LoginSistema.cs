using Login.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Sistema_Club_Deportivo
{
    public partial class LoginSistema : Form
    {
        public LoginSistema()
        {
            InitializeComponent();
        }

        private void txtLoginUser_Enter(object sender, EventArgs e)
        {
            if (txtLoginUser.Text == "Ingrese su USUARIO")
            {
                txtLoginUser.Text = "";
            }
        }

        private void txtLoginUser_Leave(object sender, EventArgs e)
        {
            if (txtLoginUser.Text == "")
            {
                txtLoginUser.Text = "Ingrese su USUARIO";
            }
        }

        private void txtPassUser_Enter(object sender, EventArgs e)
        {
            if (txtPassUser.Text == "Ingrese su CONTRASEÑA")
            {
                txtPassUser.Text = "";
                txtPassUser.UseSystemPasswordChar = true;
            }
        }

        private void txtPassUser_Leave(object sender, EventArgs e)
        {
            if (txtPassUser.Text == "")
            {
                txtPassUser.Text = "Ingrese su CONTRASEÑA";
                txtPassUser.UseSystemPasswordChar = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            Administrador dato = new Administrador(); // variable que contiene todas las caracteristicas de la clase
            tablaLogin = dato.Log_Adm(txtLoginUser.Text, txtPassUser.Text);

            if (tablaLogin.Rows.Count > 0)
            {
                // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE
                MessageBox.Show("Ingreso exitoso. Bienvenido al sistema", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); ;
                this.Hide();
                VentanaPrincipal principal = new VentanaPrincipal();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Hand); ;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
