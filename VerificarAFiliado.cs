using Login.Datos;
using MySql.Data.MySqlClient;
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
    public partial class VerificarAFiliado : Form
    {
        public VerificarAFiliado()
        {
            InitializeComponent();
        }

        private void btnBuscarAfil_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador();
            Afiliado afiliado = new Afiliado();

            try
            {
                afiliado = admin.BuscarAfiliadoPorDni(int.Parse(txtBuscarAfil.Text));

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
                WHERE
                    p.idRol = 1 AND
                    p.Dni = @Dni
                ORDER BY
                    t.FechaPago DESC
                LIMIT 1;";

                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@Dni", (txtBuscarAfil.Text));

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DateTime fechaVencimiento = Convert.ToDateTime(reader["FechaVencimiento"]);
                            TimeSpan diferenciaDias = fechaVencimiento - DateTime.Today;

                            if (diferenciaDias.Days <= 0)
                            {
                                lblEstado.Text = "RECHAZADO";
                                lblEstado.ForeColor = Color.Red;
                            }
                            else
                            {
                                lblEstado.Text = "HABILITADO";
                                lblEstado.ForeColor = Color.Green;
                            }
                        }
                        else
                        {
                            // No se encontró ningún pago para el afiliado
                            lblEstado.Text = "NO HAY\nPAGOS";
                            lblEstado.ForeColor = Color.Gray;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
