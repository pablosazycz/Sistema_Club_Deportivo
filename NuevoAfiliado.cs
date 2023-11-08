using Login.Datos;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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
    public partial class NuevoAfiliado : Form
    {
        public NuevoAfiliado()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevoAfiliado_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void btnAgregarAfiliado_Click(object sender, EventArgs e)
        {
            try
            {
                // Recopilar datos desde controles de formulario
                Persona persona = new Persona
                {
                    IdRol = 1,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    TipoDoc = txtTipoDoc.Text,
                    Dni = int.Parse(txtNroDoc.Text),
                    FechaNacimiento = txtFechaNac.Value,
                    Direccion = txtDireccion.Text,
                    Cp = int.Parse(txtCP.Text),
                    Localidad = txtLocalidad.Text,
                    CorreoElect = txtEmail.Text,
                    Telefono1 = int.Parse(txtTel1.Text),
                    Telefono2 = int.Parse(txtTel2.Text)
                };

                Administrador administrador = new Administrador();
                (bool personaExistente, bool personaEliminada) = administrador.VerificarExistenciaPersona(persona.Dni);

                if (personaExistente)
                {
                    if (personaEliminada)
                    {
                        DialogResult resultado = MessageBox.Show("La persona ya existe pero está dada de baja. ¿Desea reactivarla?", "Persona Existente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            administrador.ReactivarPersona(persona.Dni);
                            MessageBox.Show("La persona ha sido reactivada.");
                        }
                        else
                        {
                            MessageBox.Show("La persona ya existe pero está dada de baja y no fue reactivada.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La persona ya existe y no está dada de baja.");
                    }
                }
                else
                {
                    int idPersona = administrador.CrearPersonaObj(persona);

                    Afiliado afiliado = new Afiliado
                    {
                        FechaAfiliacion = DateTime.Now,
                        Socio = int.Parse(txtSocio.Text),
                        CuotaAPagar = int.Parse(txtCuotas.Text),
                        IdPersona = idPersona,
                        Persona = persona
                    };

                    administrador.CrearAfiliadoObj(afiliado);

                    DialogResult result = MessageBox.Show("Afiliado agregado exitosamente. ¿Desea imprimir el carnet ahora?", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    DateTime expira;
                    long nroCarnet;
                    if (result == DialogResult.Yes)
                    {
                        administrador.CrearCarnetAutomatico(out expira, out nroCarnet);

                        // Crea el formulario FormCarnet y pasa la información
                        FormCarnet formCarnet = new FormCarnet(afiliado, expira, nroCarnet);
                        formCarnet.Show();
                    }

                    else
                    {
                        administrador.CrearCarnetAutomatico(out expira, out nroCarnet);
                        Dispose();
                    }

                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear afiliado" + ex.ToString(), "Error");
            }
        }


        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTipoDoc.Clear();
            txtNroDoc.Clear();
            txtFechaNac.ResetText(); // Para restablecer la fecha a su valor predeterminado
            txtDireccion.Clear();
            txtCP.Clear();
            txtLocalidad.Clear();
            txtEmail.Clear();
            txtTel1.Clear();
            txtTel2.Clear();
            txtNroCarnet.Clear(); // Campo relacionado al afiliado
            txtCuotas.Clear(); // Campo relacionado al afiliado
        }
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }
    }
}
