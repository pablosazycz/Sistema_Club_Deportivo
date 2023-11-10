using Login.Datos;
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
    public partial class NuevoPago : Form
    {
        public NuevoPago()
        {
            InitializeComponent();
        }

        private void NuevoPago_Load(object sender, EventArgs e)
        {




        }



        private void btnBuscarAfil_Click(object sender, EventArgs e)
        {
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
                        txtIdAfiliado.Text = afiliado.Id.ToString();
                        txtIdPersona.Text = afiliado.Persona.Id.ToString();
                        txtApellido.Text = afiliado.Persona.Apellido;
                        txtNombre.Text = afiliado.Persona.Nombre;

                    }
                    else
                    {
                        MessageBox.Show("El DNI ingresado no es válido. Debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRegistrarPago_Click_1(object sender, EventArgs e)
        {
            try
            {
                int afiliadoId = Convert.ToInt32(txtIdAfiliado.Text);
                DateTime fechaPago = DateTime.Now;
                Decimal monto = Convert.ToInt32(txtMonto.Text);
                string metodoPago = comboBox1.Text;
                string comentario = txtArea.Text;


                if ((comboBox1.Text == "Debito" || comboBox1.Text == "Credito"))
                {
                    try
                    {
                        
                        InformacionFinanciera informacionFinanciera = new InformacionFinanciera
                        {
                            AfiliadoID = afiliadoId,
                            NumeroTarjetaCredito = txtNroTarjeta.Text,
                            FechaExpiracion = dateFechaVto.Value,
                            CodigoSeguridad = Convert.ToInt32(txtCodSeg.Text)
                        };

                        Pago pago = new Pago
                        {
                            idAfiliado = afiliadoId,
                            FechaPago = fechaPago,
                            MetodoPago = metodoPago,
                            Monto = monto,
                            Comentario = comentario
                        };

                        Administrador admin = new Administrador();
                        admin.RegistrarPago(pago);
                        admin.RegistrarInfoFinanciera(informacionFinanciera);

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                else
                {
                     
                    try
                    {

                        Pago pago = new Pago
                        {
                            idAfiliado = afiliadoId,
                            FechaPago = fechaPago,
                            MetodoPago = metodoPago,
                            Monto = monto,
                            Comentario = comentario
                        };

                        Administrador admin = new Administrador();
                        admin.RegistrarPago(pago);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }

                MessageBox.Show("Pago realizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text == "Debito" || comboBox1.Text == "Credito")
            {

                case true:
                    txtCodSeg.ReadOnly = false;
                    txtNroTarjeta.ReadOnly = false;
                    dateFechaVto.Enabled = true;
                    break;
                case false:
                    txtCodSeg.ReadOnly = true;
                    txtNroTarjeta.ReadOnly = true;
                    dateFechaVto.Enabled = false;
                    break;
            }
        }
    }
}
