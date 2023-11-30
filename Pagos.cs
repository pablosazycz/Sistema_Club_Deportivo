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
    public partial class Pagos : Form
    {
        public Pagos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoAf_Click(object sender, EventArgs e)
        {

            NuevoPago nuevoPago = new NuevoPago();
            nuevoPago.Show();
        }

        private void Pagos_Load(object sender, EventArgs e)
        {
            CargaPagos();
        }

        private void CargaPagos()
        {
            try
            {
                using (MySqlConnection conexion = Conexion.getInstancia().CrearConexion())
                {
                    conexion.Open();

                    string consulta = @"
                SELECT
                    t.FechaPago,
                    t.Monto,
                    t.MetodoPago,
                    t.Comentario,
                    t.cuota,
                    t.FechaVencimiento,
                    p.Nombre,
                    p.Apellido,
                    p.correoElect,
                    p.telefono1,
                    p.telefono2
                FROM
                    pago as t
                JOIN
                    Persona AS p ON t.PersonaID = p.id
                JOIN (
                    SELECT
                        PersonaID,
                        MAX(FechaPago) AS UltimaFechaPago
                    FROM
                        pago
                    GROUP BY
                        PersonaID
                ) AS ultimaFecha ON t.PersonaID = ultimaFecha.PersonaID AND t.FechaPago = ultimaFecha.UltimaFechaPago;";

                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    DataTable tablaIngresos = new DataTable();
                    adaptador.Fill(tablaIngresos);

                    dgdPago.DataSource = tablaIngresos;

                    // Agrega el evento DataBindingComplete
                    dgdPago.DataBindingComplete += DgdPago_DataBindingComplete;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgdPago_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow fila in dgdPago.Rows)
            {
                DateTime fechaVencimiento = Convert.ToDateTime(fila.Cells["FechaVencimiento"].Value);
                Debug.WriteLine($"Fecha de vencimiento: {fechaVencimiento}");

                TimeSpan diferenciaDias = fechaVencimiento - DateTime.Today;
                Debug.WriteLine($"Diferencia de días: {diferenciaDias.Days}");

                DataGridViewCellStyle estiloCelda = new DataGridViewCellStyle();

                if (diferenciaDias.Days <= 0)
                {
                    estiloCelda.BackColor = Color.Red;
                    Console.WriteLine("Color: Rojo");
                }
                else if (diferenciaDias.Days <= 5)
                {
                    estiloCelda.BackColor = Color.Orange;
                    Console.WriteLine("Color: Naranja");
                }
                else
                {
                    estiloCelda.BackColor = Color.Green;
                    Debug.WriteLine("Color: Verde");
                }

                foreach (DataGridViewCell celda in fila.Cells)
                {
                    celda.Style.ApplyStyle(estiloCelda);
                }
            }
        }


    }
}

