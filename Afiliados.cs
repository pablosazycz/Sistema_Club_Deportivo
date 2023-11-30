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
                    string consulta =@"
                                    SELECT 
                                        a.fechaAfiliacion as 'Fecha de Afiliacion', 
                                        p.nombre as Nombre,
                                        p.apellido as Apellido,
                                        p.tipoDoc as Tipo,
                                        p.dni as Documento,
                                        p.fechaNacimiento as 'Fecha de Nacimiento',
                                        CASE
                                            WHEN p.idRol = 1 THEN 'Socio'
                                            WHEN p.idRol = 2 THEN 'No Socio'
                                            ELSE 'Otro'
                                        END AS 'Rol'
                                    FROM afiliado AS a 
                                    JOIN persona AS p ON a.IdPersona = p.Id

                                    UNION

                                    SELECT 
                                        na.fechaAfiliacion as 'Fecha de Afiliacion', 
                                        p.nombre as Nombre,
                                        p.apellido as Apellido,
                                        p.tipoDoc as Tipo,
                                        p.dni as Documento,
                                        p.fechaNacimiento as 'Fecha de Nacimiento',
                                        CASE
                                            WHEN p.idRol = 1 THEN 'Socio'
                                            WHEN p.idRol = 2 THEN 'No Socio'
                                            ELSE 'Otro'
                                        END AS 'Rol'
                                    FROM noafiliado AS na 
                                    JOIN persona AS p ON na.IdPersona = p.Id";
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
                    string consulta = @"
                                        SELECT 
                                            a.fechaAfiliacion AS 'Fecha de Afiliacion', 
                                            p.nombre AS Nombre,
                                            p.apellido AS Apellido,
                                            p.tipoDoc AS Tipo,
                                            p.dni AS Documento,
                                            p.fechaNacimiento AS 'Fecha de Nacimiento',
                                            c.nroCarnet AS 'Num de Carnet',
                                            c.expira AS 'Vto de Carnet'
                                        FROM afiliado AS a 
                                        JOIN persona AS p ON a.IdPersona = p.Id 
                                        JOIN carnet AS c ON a.Id = c.idAfiliado";
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
                    ) AS ultimaFecha ON t.PersonaID = ultimaFecha.PersonaID AND t.FechaPago = ultimaFecha.UltimaFechaPago
                    WHERE
                    p.idRol = 1;";


                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    DataTable tablaIngresos = new DataTable();
                    adaptador.Fill(tablaIngresos);

             
                    dgdAfiliados.DataSource = tablaIngresos;

                   
                    foreach (DataGridViewRow fila in dgdAfiliados.Rows)
                    {
                        DateTime fechaVencimiento = Convert.ToDateTime(fila.Cells["FechaVencimiento"].Value);
                        TimeSpan diferenciaDias = fechaVencimiento - DateTime.Today;

                        if (diferenciaDias.Days <= 0)
                        {
                            fila.DefaultCellStyle.BackColor = Color.Red; 
                        }
                        else if (diferenciaDias.Days <= 5)
                        {
                            fila.DefaultCellStyle.BackColor = Color.Orange; 
                        }
                        else
                        {
                            fila.DefaultCellStyle.BackColor = Color.Green;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void btnBorrarAf_Click(object sender, EventArgs e)
        {
            EliminarAfiliado eliminarAfiliado = new EliminarAfiliado();
            eliminarAfiliado.Show();
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

        private void btnAfilNoSocio_Click(object sender, EventArgs e)
        {
            
                try
                {
                    using (MySqlConnection conexion = Conexion.getInstancia().CrearConexion())
                    {
                        conexion.Open();

                        // Consulta SQL para obtener los datos
                        string consulta = @"
                                        SELECT
                                         na.fechaAfiliacion as 'Fecha de Afiliacion', 
                                         p.nombre as Nombre,
                                         p.apellido as Apellido,
                                         p.tipoDoc as Tipo,
                                         p.dni as Documento,
                                         p.fechaNacimiento as 'Fecha de Nacimiento'
                                         FROM noafiliado AS na 
                                         Join persona AS p 
                                         ON na.IdPersona = p.Id ";
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
    }
}
