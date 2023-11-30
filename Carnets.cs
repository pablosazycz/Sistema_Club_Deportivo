using Login.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Club_Deportivo
{
    public partial class Carnets : Form
    {
        public Carnets()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoAf_Click(object sender, EventArgs e)
        {
            BuscarCarnet buscarCarnet = new BuscarCarnet();
            buscarCarnet.Show();
        }

        private void Carnets_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexion = Conexion.getInstancia().CrearConexion())
                {
                    conexion.Open();

                    string consulta = @"
               SELECT 
                    p.nombre AS Nombre,
                    p.apellido AS Apellido,
                    p.tipoDoc AS 'Tipo Doc',
                    p.dni AS Documento,
                    c.nroCarnet AS 'Nro de Carnet',
                    c.expira AS Vencimiento,
                    p.eliminado as Eliminado
                FROM
                    carnet c
                        JOIN
                    afiliado af ON c.idAfiliado = af.id
                        JOIN
                    persona p ON af.idPersona = p.id";

                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    DataTable tablaIngresos = new DataTable();
                    adaptador.Fill(tablaIngresos);

                  

                    dataGridView1.DataSource = tablaIngresos;
                    dataGridView1.RowPostPaint += DataGridView1_RowPostPaint;

                   
                    dataGridView1.Columns["Eliminado"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void DataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Obtener el valor de la columna "Eliminado" para la fila actual
            bool eliminado = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells["Eliminado"].Value);

            // Cambiar el color de fondo si "Eliminado" es verdadero
            if (eliminado)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.IndianRed;
            }
            else
            {
                // Asegurarse de restablecer el color de fondo si "Eliminado" es falso
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor;
            }
        }



    }
}

