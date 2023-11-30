using Login.Datos;
using Microsoft.VisualBasic;
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
    public partial class EdicionNoAfiliado : Form
    {
        public EdicionNoAfiliado()
        {
            InitializeComponent();
        }


        int dniOriginal;
        private void btnBuscarAfil_Click_1(object sender, EventArgs e)
        {
            string criterioBusqueda = txtBuscarAfil.Text;

            if (string.IsNullOrWhiteSpace(criterioBusqueda))
            {
                MessageBox.Show("Debe ingresar un criterio de búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (radioDocBuscar.Checked)
            {
                int dniBuscar = int.Parse(criterioBusqueda);
                Administrador admin = new Administrador();
                NoAfiliado noAfiliado = admin.BuscarNoAfiliadoPorDni(dniBuscar);

                if (noAfiliado != null)
                {
                    txtIdRol.Text = noAfiliado.Persona.IdRol.ToString();
                    txtIdNoAfiliado.Text = noAfiliado.Id.ToString();
                    txtIdPersona.Text = noAfiliado.Persona.Id.ToString();
                    txtApellido.Text = noAfiliado.Persona.Apellido;
                    txtNombre.Text = noAfiliado.Persona.Nombre;
                    txtTipoDoc.Text = noAfiliado.Persona.TipoDoc;
                    txtNroDoc.Text = noAfiliado.Persona.Dni.ToString();
                    dniOriginal = noAfiliado.Persona.Dni;
                    txtFechaNac.Value = noAfiliado.Persona.FechaNacimiento;
                    txtDireccion.Text = noAfiliado.Persona.Direccion;
                    txtCP.Text = noAfiliado.Persona.Cp.ToString();
                    txtLocalidad.Text = noAfiliado.Persona.Localidad;
                    txtEmail.Text = noAfiliado.Persona.CorreoElect;
                    txtTel1.Text = noAfiliado.Persona.Telefono1.ToString();
                    txtTel2.Text = noAfiliado.Persona.Telefono2.ToString();
                    txtFechaAfi.Value = noAfiliado.FechaAfiliacion;

                }
                else
                {
                    MessageBox.Show("El DNI ingresado no es válido. Debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            //else if (radioSocioBusca.Checked)
            //{
            //    //ejecutar busqueda por numero de socio
            //}
            //else
            //{
            //    MessageBox.Show("Debe seleccionar un criterio de busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}




        }

        int dniChanged;
        private void txtNroDoc_TextChanged_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtNroDoc.Text, out int nuevoDni))
            {
                dniChanged = nuevoDni;
            }
        }
        private void btnEditarNoAfiliado_Click_1(object sender, EventArgs e)
        {

            NoAfiliado noAfiliado = new NoAfiliado();
            noAfiliado.Id = int.Parse(txtIdNoAfiliado.Text);
            noAfiliado.FechaAfiliacion = txtFechaAfi.Value;


            Carnet carnet = new Carnet();

            Persona persona = new Persona();
            persona.Id = int.Parse(txtIdPersona.Text);
            persona.IdRol = int.Parse(txtIdRol.Text);
            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;
            persona.TipoDoc = txtTipoDoc.Text;
            persona.Dni = int.Parse(txtNroDoc.Text);
            persona.FechaNacimiento = txtFechaNac.Value;
            persona.Direccion = txtDireccion.Text;
            persona.Cp = int.Parse(txtCP.Text);
            persona.Localidad = txtLocalidad.Text;
            persona.CorreoElect = txtEmail.Text;
            persona.Telefono1 = int.Parse(txtTel1.Text);
            persona.Telefono2 = int.Parse(txtTel2.Text);

            // Guarda los cambios en la base de datos
            Administrador admin = new Administrador();
            admin.EditarNoAfiliado(noAfiliado);
            admin.EditarPersona(persona);

            MessageBox.Show("Cambios guardados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void txtBuscarAfil_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNoafiliado_Click(object sender, EventArgs e)
        {
            MsgBoxResult result = Interaction.MsgBox("¿Está seguro que desea Cambiar el no afiliado a Afiliado?", MsgBoxStyle.YesNo, "Atención");
            if (result == MsgBoxResult.Yes)
            {

                if (int.TryParse(txtIdPersona.Text, out int idPersona))
                {
                    Administrador administrador = new Administrador();
                    administrador.InsertarAfiliado(idPersona);

                    administrador.EliminarNoAfiliado(idPersona);
                    administrador.CambioIdRol(idPersona);

                    MessageBox.Show("Afiliado agregado correctamente.");
                }
                else
                {
                    MessageBox.Show("El Id de la persona no es válido.");
                }
            }
        }



    }
}

