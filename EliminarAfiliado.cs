using Login.Datos;
using Microsoft.VisualBasic;
using Sistema_Club_Deportivo.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Club_Deportivo
{
    public partial class EliminarAfiliado : Form
    {
        public EliminarAfiliado()
        {
            InitializeComponent();
        }

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

        private void btnEditarAfiliado_Click(object sender, EventArgs e)
        {
            if (Controlblanco() == false)
            {
                MsgBoxResult resultado = Interaction.MsgBox("¿Está seguro que desea eliminar el afiliado?", MsgBoxStyle.YesNo, "Eliminar Afiliado");
                if (resultado == MsgBoxResult.Yes)
                {
                    Administrador admin = new Administrador();
                    int idAfiliado = int.Parse(txtIdAfiliado.Text);
                    int idPersona = int.Parse(txtIdPersona.Text);
                    admin.DarDeBajaAfiliado(idAfiliado);
                    admin.DarDeBajaPersona(idPersona);
                    MessageBox.Show("El afiliado ha sido eliminado correctamente", "Eliminar Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MsgBoxResult resultado = Interaction.MsgBox("Debe completar todos los campos", MsgBoxStyle.OkOnly, "Error");
            }
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

    }
}
