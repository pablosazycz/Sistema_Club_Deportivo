using Login.Datos;
using MySqlX.XDevAPI.Relational;
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
    public partial class EdicionAfiliado : Form
    {
        public EdicionAfiliado()
        {
            InitializeComponent();
        }

        int dniOriginal; 
        private void btnBuscarAfil_Click(object sender, EventArgs e)
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
                Afiliado afiliado = admin.BuscarAfiliadoPorDni(dniBuscar);

                if (afiliado != null)
                {
                    txtIdRol.Text = afiliado.Persona.IdRol.ToString();
                    txtIdAfiliado.Text = afiliado.Id.ToString();
                    txtIdPersona.Text = afiliado.Persona.Id.ToString();
                    txtApellido.Text = afiliado.Persona.Apellido;
                    txtNombre.Text = afiliado.Persona.Nombre;
                    txtTipoDoc.Text = afiliado.Persona.TipoDoc;
                    txtNroDoc.Text = afiliado.Persona.Dni.ToString();
                    dniOriginal = afiliado.Persona.Dni;
                    txtFechaNac.Value = afiliado.Persona.FechaNacimiento;
                    txtDireccion.Text = afiliado.Persona.Direccion;
                    txtCP.Text = afiliado.Persona.Cp.ToString();
                    txtLocalidad.Text = afiliado.Persona.Localidad;
                    txtEmail.Text = afiliado.Persona.CorreoElect;
                    txtTel1.Text = afiliado.Persona.Telefono1.ToString();
                    txtTel2.Text = afiliado.Persona.Telefono2.ToString();
                    txtFechaAfi.Value = afiliado.FechaAfiliacion;



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
        Boolean error = false;
        private Boolean Controlblanco()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtApellido.Text) ||
                string.IsNullOrEmpty(txtNroDoc.Text) ||
                string.IsNullOrEmpty(txtFechaNac.Text) ||
                string.IsNullOrEmpty(txtDireccion.Text) ||
                string.IsNullOrEmpty(txtCP.Text) ||
                string.IsNullOrEmpty(txtLocalidad.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtTel1.Text) ||
                string.IsNullOrEmpty(txtTel2.Text))
            {

                error = true;
            }
            else
            {
                error = false;
            }

            return error;

        }



        int dniChanged;
        private void txtNroDoc_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtNroDoc.Text, out int nuevoDni))
            {
                dniChanged = nuevoDni;
            }
        }
        private void btnEditarAfiliado_Click(object sender, EventArgs e)
        {
            if (Controlblanco() == false)
            {

                Afiliado afiliado = new Afiliado();
                afiliado.Id = int.Parse(txtIdAfiliado.Text);
                afiliado.FechaAfiliacion = txtFechaAfi.Value;


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
                admin.EditarAfiliado(afiliado);
                admin.EditarPersona(persona);

                MessageBox.Show("Cambios guardados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
