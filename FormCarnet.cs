using Sistema_Club_Deportivo.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Club_Deportivo
{
    public partial class FormCarnet : Form
    {
        public FormCarnet(Afiliado afiliado, DateTime fechaVencimiento, long numeroCarnet)
        {
            InitializeComponent();

           carnetNombre.Text = "Nombre: " + afiliado.Persona.Nombre;
           carnetApellido.Text = "Apellido: " + afiliado.Persona.Apellido;
           carnetVto.Text = "Vencimiento: " + fechaVencimiento;
           carnetNroSocio.Text = "Nro. Socio: " + numeroCarnet;


        }

        private void FormCarnet_Load(object sender, EventArgs e)
        {

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
