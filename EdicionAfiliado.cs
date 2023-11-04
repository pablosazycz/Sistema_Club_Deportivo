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

        int dniOriginal;  //variable para guardar el dni de la bd, asi se puede editar el dni
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
                    dniOriginal = afiliado.Persona.Dni; //guarda el dni original para poder editarlo
                    txtFechaNac.Value = afiliado.Persona.FechaNacimiento;
                    txtDireccion.Text = afiliado.Persona.Direccion;
                    txtCP.Text = afiliado.Persona.Cp.ToString();
                    txtLocalidad.Text = afiliado.Persona.Localidad;
                    txtEmail.Text = afiliado.Persona.CorreoElect;
                    txtTel1.Text = afiliado.Persona.Telefono1.ToString();
                    txtTel2.Text = afiliado.Persona.Telefono2.ToString();
                    txtFechaAfi.Value = afiliado.FechaAfiliacion;
                    txtNroCarnet.Text = afiliado.Carnet.NroCarnet.ToString();
                    txtCuotas.Text = afiliado.CuotaAPagar.ToString();
                    txtSocio.Text = afiliado.Socio.ToString();

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
        private void txtNroDoc_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtNroDoc.Text, out int nuevoDni)) // Intenta analizar el nuevo DNI
            {
                dniChanged = nuevoDni; // Almacena el nuevo DNI como valor original
            }
        }
        private void btnEditarAfiliado_Click(object sender, EventArgs e)
        {
            // Obtén los valores editados del formulario
            Afiliado afiliado = new Afiliado();
            afiliado.Id = int.Parse(txtIdAfiliado.Text);
            afiliado.FechaAfiliacion = txtFechaAfi.Value;
            afiliado.Socio = int.Parse(txtSocio.Text);
            afiliado.CuotaAPagar = int.Parse(txtCuotas.Text);

            Carnet carnet = new Carnet();
            carnet.NroCarnet = long.Parse(txtNroCarnet.Text);

            // Obtén los valores editados de la persona asociada al afiliado
            Persona persona = new Persona();
            persona.Id = int.Parse(txtIdPersona.Text);
            persona.IdRol = int.Parse(txtIdRol.Text); // Puedes mantener el mismo rol
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
            admin.EditarAfiliado(afiliado); // Actualiza los datos del afiliado
            admin.EditarPersona(persona); // Actualiza los datos de la persona

            // Informa al usuario que los cambios se han guardado con éxito
            MessageBox.Show("Cambios guardados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }


    }
}
