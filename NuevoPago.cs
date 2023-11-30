using Login.Datos;
using Sistema_Club_Deportivo.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            errorProvider1.ContainerControl = this; // Asociar con el formulario
        }

        private void txtIdAfiliado_Validating(object sender, CancelEventArgs e)
        {
            ValidarCampo(txtIdAfiliado, e);
        }

        private void txtMonto_Validating(object sender, CancelEventArgs e)
        {
            ValidarCampo(txtMonto, e);
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            ValidarCampo(comboBox1, e);
        }

        private void txtArea_Validating(object sender, CancelEventArgs e)
        {
            ValidarCampo(txtArea, e);
        }

        private void ValidarCampo(Control control, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                errorProvider1.SetError(control, "Este campo es obligatorio.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(control, "");
            }
        }

        private void txtIdAfiliado_Validated(object sender, EventArgs e)
        {
            LimpiarError(txtIdAfiliado);
        }

        private void txtMonto_Validated(object sender, EventArgs e)
        {
            LimpiarError(txtMonto);
        }

        private void comboBox1_Validated(object sender, EventArgs e)
        {
            LimpiarError(comboBox1);
        }

        private void txtArea_Validated(object sender, EventArgs e)
        {
            LimpiarError(txtArea);
        }

        private void LimpiarError(Control control)
        {
            errorProvider1.SetError(control, "");
        }

        private bool HayErroresDeValidacion()
        {
            // Verificar si hay mensajes de error en el ErrorProvider
            foreach (Control control in this.Controls)
            {
                if (!string.IsNullOrEmpty(errorProvider1.GetError(control)))
                {
                    return true;
                }
            }
            return false;
        }

        int rol = 0;
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
                        rol = afiliado.Persona.IdRol;
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
            txtIdAfiliado_Validating(txtIdAfiliado, new CancelEventArgs());
            txtMonto_Validating(txtMonto, new CancelEventArgs());
            comboBox1_Validating(comboBox1, new CancelEventArgs());
            txtArea_Validating(txtArea, new CancelEventArgs());

            if (HayErroresDeValidacion())
            {
                // Mostrar un mensaje u otra acción según tus necesidades
                MessageBox.Show("Por favor, corrija los campos con errores antes de continuar.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {

                int personaId = Convert.ToInt32(txtIdPersona.Text);
                int afiliadoId = Convert.ToInt32(txtIdAfiliado.Text);
                DateTime fechaPago = DateTime.Now;
                DateTime fechaVencimiento = DateTime.Now;
                Decimal monto = Convert.ToInt32(txtMonto.Text);
                string metodoPago = comboBox1.Text;
                string comentario = txtArea.Text;
                int cuotas = ObtenerCuotasSeleccionadas();
                if (rol == 1)
                {
                    fechaVencimiento = fechaPago.AddMonths(1);
                }
                else
                {
                    fechaVencimiento = fechaPago.AddMonths(3);
                }


                switch (comboBox1.Text)
                {
                    case "Credito":

                        try
                        {
                            ObtenerCuotasSeleccionadas();
                            ActualizarMontoAPagar(Convert.ToDecimal(txtMonto.Text), cuotas);


                            Pago pago = new Pago
                            {
                                PersonaID = personaId,
                                FechaPago = fechaPago,
                                MetodoPago = metodoPago,
                                Monto = monto,
                                Comentario = comentario,
                                Cuota = cuotas,
                                FechaVencimiento = fechaVencimiento,

                            };

                            Administrador admin = new Administrador();
                            int idPago = admin.RegistrarPago(pago);



                            InformacionFinanciera informacionFinanciera = new InformacionFinanciera
                            {
                                PersonaId = personaId,
                                NumeroTarjetaCredito = txtNroTarjeta.Text,
                                FechaExpiracion = dateFechaVto.Value,
                                CodigoSeguridad = Convert.ToInt32(txtCodSeg.Text),
                                PagoId = idPago
                            };

                            admin.RegistrarInfoFinanciera(informacionFinanciera);
                            MessageBox.Show("Pago realizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception)
                        {

                            throw;
                        }

                        break;

                    case "Debito":
                        try
                        {

                            ObtenerCuotasSeleccionadas();
                            ActualizarMontoAPagar(Convert.ToDecimal(txtMonto.Text), cuotas);


                            Pago pago = new Pago
                            {
                                PersonaID = personaId,
                                FechaPago = fechaPago,
                                MetodoPago = metodoPago,
                                Monto = monto,
                                Comentario = comentario,
                                Cuota = cuotas,
                                FechaVencimiento = fechaVencimiento,

                            };

                            Administrador admin = new Administrador();
                            int idPago = admin.RegistrarPago(pago);



                            InformacionFinanciera informacionFinanciera = new InformacionFinanciera
                            {
                                PersonaId = personaId,
                                NumeroTarjetaCredito = txtNroTarjeta.Text,
                                FechaExpiracion = dateFechaVto.Value,
                                CodigoSeguridad = Convert.ToInt32(txtCodSeg.Text),
                                PagoId = idPago
                            };

                            admin.RegistrarInfoFinanciera(informacionFinanciera);
                            MessageBox.Show("Pago realizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                        break;

                    case "Efectivo":
                        try
                        {


                            Pago pago = new Pago
                            {
                                PersonaID = personaId,
                                FechaPago = fechaPago,
                                MetodoPago = metodoPago,
                                Monto = monto,
                                Comentario = comentario,
                                Cuota = cuotas,
                                FechaVencimiento = fechaVencimiento
                            };

                            Administrador admin = new Administrador();
                            admin.RegistrarPago(pago);
                            MessageBox.Show("Pago realizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {

                            throw;
                        }
                        break;

                    default:
                        MessageBox.Show("Debe seleccionar un método de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al registrar el pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {

                case "Debito":
                    txtCodSeg.ReadOnly = false;
                    txtNroTarjeta.ReadOnly = false;
                    dateFechaVto.Enabled = true;
                    radioCuotas6.Enabled = false;
                    radioCuotas3.Enabled = false;
                    int cuotas = ObtenerCuotasSeleccionadas();

                    ActualizarMontoAPagar(Convert.ToInt32(txtMonto.Text), cuotas);

                    break;

                case "Credito":
                    txtCodSeg.ReadOnly = false;
                    txtNroTarjeta.ReadOnly = false;
                    dateFechaVto.Enabled = true;
                    radioCuotas6.Enabled = true;
                    radioCuotas3.Enabled = true;

                    break;

                case "Efectivo":
                    txtCodSeg.ReadOnly = true;
                    txtNroTarjeta.ReadOnly = true;
                    dateFechaVto.Enabled = false;
                    radioCuotas6.Enabled = false;
                    radioCuotas3.Enabled = false;
                    break;
            }
        }

        private void radioCuotas_CheckedChanged(object sender, EventArgs e)
        {
            int cuotas = ObtenerCuotasSeleccionadas();


            ActualizarMontoAPagar(Convert.ToInt32(txtMonto.Text), cuotas);


        }
        private int ObtenerCuotasSeleccionadas()
        {
            int cuotas = 1;

            if (radioCuotas3.Checked)
            {
                cuotas = 3;
            }
            else if (radioCuotas6.Checked)
            {
                cuotas = 6;
            }

            return cuotas;
        }

        private void ActualizarMontoAPagar(decimal monto, int cuotas)
        {

            decimal montoPorCuota = monto / cuotas;


            montoAPagar.Text = montoPorCuota.ToString("F2");
        }
    }
}
