using Login.Datos;
using MySql.Data.MySqlClient;
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
    public partial class Afiliados : Form
    {
        public Afiliados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoAf_Click(object sender, EventArgs e)
        {
            NuevoAfiliado nuevoAfiliado = new NuevoAfiliado();
            nuevoAfiliado.Show();
        }



        private void CargarDatos()
        {
            try
            {
                using (MySqlConnection conexion = Conexion.getInstancia().CrearConexion())
                {
                    conexion.Open();

                    // Consulta SQL para obtener los datos
                    string consulta = "SELECT * FROM persona";
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    DataTable tablaIngresos = new DataTable();
                    adaptador.Fill(tablaIngresos);
                    dgdAfiliados.DataSource = tablaIngresos;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTodosLosAf_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnAfilSocio_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexion = Conexion.getInstancia().CrearConexion())
                {
                    conexion.Open();

                    // Consulta SQL para obtener los datos
                    string consulta = " SELECT a.*, p.*, c.*     FROM afiliado AS a     JOIN persona AS p ON a.IdPersona = p.Id join carnet AS c ON  a.Id=c.idAfiliado" ;
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    DataTable tablaIngresos = new DataTable();
                    adaptador.Fill(tablaIngresos);
                    dgdAfiliados.DataSource = tablaIngresos;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCuotasAVenc_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrarAf_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgdAfiliados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditarAf_Click(object sender, EventArgs e)
        {
            EdicionAfiliado edicionAfiliado = new EdicionAfiliado();
            edicionAfiliado.Show();

        }
    }
}
