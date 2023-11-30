using Login.Datos;
using MySqlX.XDevAPI.Relational;
using Sistema_Club_Deportivo.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Club_Deportivo
{
    public partial class NuevoNoAfiliado : Form
    {
        private int estadoActual = 1;
        private const int CantidadTotalEstados = 3;

        public NuevoNoAfiliado()
        {
            InitializeComponent();
            MostrarContenido();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ActualizarEstadoBoton();
        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        int idNoAfiliado = -1;
        int personaId = -1;
        int Dni = -1;
        private void btnAgregarAfiliado_Click(object sender, EventArgs e)
        {
            if (Controlblanco() == false)

            {
                btnSiguienteP1.Enabled = true;

                try
                {

                    Persona persona = new Persona
                    {
                        IdRol = 2,
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        TipoDoc = cboTipoDoc.Text,
                        Dni = int.Parse(txtNroDoc.Text),
                        FechaNacimiento = txtFechaNac.Value,
                        Direccion = txtDireccion.Text,
                        Cp = int.TryParse(txtCP.Text, out int cp) ? cp : 0,
                        Localidad = txtLocalidad.Text,
                        CorreoElect = txtEmail.Text,
                        Telefono1 = int.TryParse(txtTel1.Text, out int telefono1) ? telefono1 : 0,
                        Telefono2 = int.TryParse(txtTel1.Text, out int telefono2) ? telefono2 : 0
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
                                (bool personaReactivada, int idPersona, DateTime fechaVencimiento, long nroCarnet) = administrador.ReactivarPersona(persona.Dni);

                                if (personaReactivada)
                                {

                                    MessageBox.Show("La persona ha sido reactivada.");

                                    // Crea el formulario FormCarnet y pasa la información
                                    NoAfiliado noAfiliado = administrador.BuscarNoAfiliadoPorDni(persona.Dni);

                                    //mostrar noafiliado y persona en textbox

                                    txtNombre.Text = noAfiliado.Persona.Nombre;
                                    txtApellido.Text = noAfiliado.Persona.Apellido;
                                    cboTipoDoc.Text = noAfiliado.Persona.TipoDoc;
                                    txtNroDoc.Text = noAfiliado.Persona.Dni.ToString();
                                    txtFechaNac.Text = noAfiliado.Persona.FechaNacimiento.ToString();
                                    txtDireccion.Text = noAfiliado.Persona.Direccion;
                                    txtCP.Text = noAfiliado.Persona.Cp.ToString();
                                    txtLocalidad.Text = noAfiliado.Persona.Localidad;
                                    txtEmail.Text = noAfiliado.Persona.CorreoElect;
                                    txtTel1.Text = noAfiliado.Persona.Telefono1.ToString();
                                    txtTel2.Text = noAfiliado.Persona.Telefono2.ToString();

                                    //guardar en variables los datos de noafiliado
                                    idNoAfiliado = noAfiliado.Id;
                                    DateTime fechaAfiliacion = noAfiliado.FechaAfiliacion;
                                    personaId = noAfiliado.IdPersona;
                                    Dni = noAfiliado.Persona.Dni;





                                }
                                btnSiguienteP1.Enabled = true;

                            }
                            else
                            {


                                MessageBox.Show("La persona ya existe pero está dada de baja y no fue reactivada.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("La persona ya existe y no está dada de baja.");
                            // Crea el formulario FormCarnet y pasa la información
                            NoAfiliado noAfiliado = administrador.BuscarNoAfiliadoPorDni(persona.Dni);

                            //mostrar noafiliado y persona en textbox

                            txtNombre.Text = noAfiliado.Persona.Nombre;
                            txtApellido.Text = noAfiliado.Persona.Apellido;
                            cboTipoDoc.Text = noAfiliado.Persona.TipoDoc;
                            txtNroDoc.Text = noAfiliado.Persona.Dni.ToString();
                            txtFechaNac.Text = noAfiliado.Persona.FechaNacimiento.ToString();
                            txtDireccion.Text = noAfiliado.Persona.Direccion;
                            txtCP.Text = noAfiliado.Persona.Cp.ToString();
                            txtLocalidad.Text = noAfiliado.Persona.Localidad;
                            txtEmail.Text = noAfiliado.Persona.CorreoElect;
                            txtTel1.Text = noAfiliado.Persona.Telefono1.ToString();
                            txtTel2.Text = noAfiliado.Persona.Telefono2.ToString();

                            //guardar en variables los datos de noafiliado
                            idNoAfiliado = noAfiliado.Id;
                            DateTime fechaAfiliacion = noAfiliado.FechaAfiliacion;
                            personaId = noAfiliado.IdPersona;
                            Dni = noAfiliado.Persona.Dni;
                            btnSiguienteP1.Enabled = true;
                        }
                    }
                    else
                    {
                        int idPersona = administrador.CrearPersonaObj(persona);

                        NoAfiliado noAfiliado = new NoAfiliado
                        {
                            FechaAfiliacion = DateTime.Now,

                            IdPersona = idPersona,
                            Persona = persona
                        };

                        administrador.CrearNoAfiliadoObj(noAfiliado);

                        DialogResult result = MessageBox.Show("Afiliado agregado exitosamente. Oprima Siguiente", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        noAfiliado = administrador.BuscarNoAfiliadoPorDni(persona.Dni);
                        idNoAfiliado = noAfiliado.Id;
                        personaId = noAfiliado.IdPersona;
                        Dni = noAfiliado.Persona.Dni;



                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear afiliado" + ex.ToString(), "Error");
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            cboTipoDoc.SelectedIndex = 0;
            txtNroDoc.Clear();
            txtFechaNac.ResetText(); // Para restablecer la fecha a su valor predeterminado
            txtDireccion.Clear();
            txtCP.Clear();
            txtLocalidad.Clear();
            txtEmail.Clear();
            txtTel1.Clear();
            txtTel2.Clear();

        }

        private void MostrarContenido()
        {
            // Oculta todos los paneles o controles
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;

            // Muestra el panel o control correspondiente al estado actual
            switch (estadoActual)
            {
                case 1:
                    panel1.Visible = true;
                    break;
                case 2:
                    panel2.Visible = true;
                    break;
                case 3:
                    panel3.Visible = true;
                    break;
                default:
                    break;
            }
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            estadoActual++;


            if (estadoActual > CantidadTotalEstados)
            {
                estadoActual = CantidadTotalEstados;

            }


            MostrarContenido();
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            // Decrementa el estado actual
            estadoActual--;

            // Si está en el primer estado, restablece el texto del botón "Siguiente"
            if (estadoActual <= 1)
            {
                estadoActual = 1;
                btnSiguienteP1.Text = "Siguiente";
            }

            // Actualiza el contenido del formulario
            MostrarContenido();
        }
        private void btnFinalizar_Click_1(object sender, EventArgs e)
        {
            // Si está en el último estado, cierra la ventana
            if (estadoActual == CantidadTotalEstados)
            {
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        //        ABS
        //Crossfit
        //Funcional Training
        //Musculacion
        //Spinnig
        //Yoga
        //Zumba

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            switch (cboTipoACtividad.Text)
            {
                case "Todas las Actividades":
                    try
                    {
                        Administrador admin = new Administrador();
                        List<Actividad> actividades = admin.ObtenerActividades();


                        MostrarActividadesEnFormulario(actividades);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al obtener las actividades: {ex.Message}");
                    }
                    break;
                case "ABS":
                    try
                    {
                        Administrador admin = new Administrador();
                        List<Actividad> actividades = admin.ObtenerActividadesPorNombre("ABS");


                        MostrarActividadesEnFormulario(actividades);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al obtener las actividades: {ex.Message}");
                    }
                    break;
                case "Crossfit":
                    try
                    {
                        Administrador admin = new Administrador();
                        List<Actividad> actividades = admin.ObtenerActividadesPorNombre("Crossfit");


                        MostrarActividadesEnFormulario(actividades);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al obtener las actividades: {ex.Message}");
                    }
                    break;
                case "Funcional Training":
                    try
                    {
                        Administrador admin = new Administrador();
                        List<Actividad> actividades = admin.ObtenerActividadesPorNombre("Funcional Training");

                        MostrarActividadesEnFormulario(actividades);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al obtener las actividades: {ex.Message}");
                    }
                    break;
                case "Musculacion":
                    try
                    {
                        Administrador admin = new Administrador();
                        List<Actividad> actividades = admin.ObtenerActividadesPorNombre("Musculacion");


                        MostrarActividadesEnFormulario(actividades);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al obtener las actividades: {ex.Message}");
                    }
                    break;
                case "Spinnig":
                    try
                    {
                        Administrador admin = new Administrador();
                        List<Actividad> actividades = admin.ObtenerActividadesPorNombre("Spinnig");


                        MostrarActividadesEnFormulario(actividades);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al obtener las actividades: {ex.Message}");
                    }
                    break;
                case "Yoga":
                    try
                    {
                        Administrador admin = new Administrador();
                        List<Actividad> actividades = admin.ObtenerActividadesPorNombre("Yoga");

                        MostrarActividadesEnFormulario(actividades);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al obtener las actividades: {ex.Message}");
                    }
                    break;
                case "Zumba":
                    try
                    {
                        Administrador admin = new Administrador();
                        List<Actividad> actividades = admin.ObtenerActividadesPorNombre("Zumba");


                        MostrarActividadesEnFormulario(actividades);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al obtener las actividades: {ex.Message}");
                    }
                    break;



            }
        }


        private void MostrarActividadesEnFormulario(List<Actividad> actividades)
        {
            try
            {

                dataGridView1.DataSource = actividades;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener las actividades: {ex.Message}");
            }


        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];


                Actividad actividad = new Actividad
                {
                    ActividadID = Convert.ToInt32(selectedRow.Cells["ActividadID"].Value),
                    Nombre = selectedRow.Cells["Nombre"].Value.ToString(),
                    Descripcion = selectedRow.Cells["Descripcion"].Value.ToString(),
                    CupoMaximo = Convert.ToInt32(selectedRow.Cells["CupoMaximo"].Value),
                    FechaInicio = Convert.ToDateTime(selectedRow.Cells["FechaInicio"].Value),
                    FechaFin = Convert.ToDateTime(selectedRow.Cells["FechaFin"].Value),
                    HoraInicio = TimeSpan.Parse(selectedRow.Cells["HoraInicio"].Value.ToString()),
                    HoraFin = TimeSpan.Parse(selectedRow.Cells["HoraFin"].Value.ToString()),
                    Costo = Convert.ToDecimal(selectedRow.Cells["Costo"].Value),
                    ProfesorID = Convert.ToInt32(selectedRow.Cells["ProfesorID"].Value),
                    Equipamiento = selectedRow.Cells["Equipamiento"].Value.ToString(),
                    DiasSemana = selectedRow.Cells["DiasSemana"].Value.ToString()
                };

                dataGridView2.Columns.Add("ActividadID", "ActividadID");
                dataGridView2.Columns.Add("Nombre", "Nombre");
                dataGridView2.Columns.Add("Descripcion", "Descripcion");
                dataGridView2.Columns.Add("CupoMaximo", "CupoMaximo");
                dataGridView2.Columns.Add("FechaInicio", "FechaInicio");
                dataGridView2.Columns.Add("FechaFin", "FechaFin");
                dataGridView2.Columns.Add("HoraInicio", "HoraInicio");
                dataGridView2.Columns.Add("HoraFin", "HoraFin");
                dataGridView2.Columns.Add("Costo", "Costo");
                dataGridView2.Columns.Add("ProfesorID", "ProfesorID");
                dataGridView2.Columns.Add("Equipamiento", "Equipamiento");
                dataGridView2.Columns.Add("DiasSemana", "DiasSemana");



                dataGridView2.Rows.Add(
                    actividad.ActividadID,
                    actividad.Nombre,
                    actividad.Descripcion,
                    actividad.CupoMaximo,
                    actividad.FechaInicio,
                    actividad.FechaFin,
                    actividad.HoraInicio,
                    actividad.HoraFin,
                    actividad.Costo,
                    actividad.ProfesorID,
                    actividad.Equipamiento,
                    actividad.DiasSemana
                );
                ActualizarTotalCosto();
            }
        }

        private void dgv2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                dataGridView2.Rows.RemoveAt(e.RowIndex);
            }
            ActualizarTotalCosto();
        }

        private decimal totalCosto = 0;
        private void ActualizarTotalCosto()
        {
            totalCosto = 0;

            if (dataGridView2.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    decimal costo = Convert.ToDecimal(row.Cells["Costo"].Value);
                    totalCosto += costo;
                }
            }

            // Actualiza el texto del Label con el monto total
            labelTotalCosto.Text = $"Total: {totalCosto:C}";
            ActualizarEstadoBoton();

        }

        private void ActualizarEstadoBoton()
        {

            bool hayDatos = dataGridView2.Rows.Count > 0;


            btnSiguienteP2.Enabled = hayDatos;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            totalCosto = 0;
            if (dataGridView2.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    int actividadId = Convert.ToInt32(row.Cells["ActividadID"].Value);
                    decimal costo = Convert.ToDecimal(row.Cells["Costo"].Value);
                    totalCosto += costo;
                    Administrador admin = new Administrador();
                    admin.RegistrarInscripcion(idNoAfiliado, actividadId);
                }
                dataGridView2.ClearSelection();
            }
            else
            {

                MessageBox.Show("No hay actividades para inscribirse.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void panel3_VisibleChanged(object sender, EventArgs e)
        {
            if (panel3.Visible)
            {
                Administrador administrador = new Administrador();
                NoAfiliado noAfiliado = administrador.BuscarNoAfiliadoPorDni(Dni);

                txtIdNoAfiliado.Text = noAfiliado.Id.ToString();
                txtIdPersona.Text = noAfiliado.IdPersona.ToString();
                txtPagoNombre.Text = noAfiliado.Persona.Nombre;
                txtPagoApellido.Text = noAfiliado.Persona.Apellido;
                txtMonto.Text = totalCosto.ToString();

            }
        }


        private void btnRegistrarPago_Click_1(object sender, EventArgs e)
        {
            Administrador administrador = new Administrador();
            NoAfiliado noAfiliado = administrador.BuscarNoAfiliadoPorDni(Dni);

            try
            {

                int personaId = Convert.ToInt32(txtIdPersona.Text);
                int NoafiliadoId = Convert.ToInt32(txtIdNoAfiliado.Text);
                DateTime fechaPago = DateTime.Now;
                DateTime fechaVencimiento = DateTime.Now;
                Decimal monto = Convert.ToDecimal(txtMonto.Text);
                string metodoPago = comboBox3.Text;
                string comentario = txtArea.Text;
                int cuotas = ObtenerCuotasSeleccionadas();
                int rol = noAfiliado.Persona.IdRol;

                if (rol == 1)
                {
                    fechaVencimiento = fechaPago.AddMonths(1);
                }
                else
                {
                    fechaVencimiento = fechaPago.AddMonths(3);
                }


                switch (comboBox3.Text)
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
            switch (comboBox3.Text)
            {

                case "Debito":
                    txtCodSeg.ReadOnly = false;
                    txtNroTarjeta.ReadOnly = false;
                    dateFechaVto.Enabled = true;
                    radioCuotas6.Enabled = false;
                    radioCuotas3.Enabled = false;
                    int cuotas = ObtenerCuotasSeleccionadas();

                    ActualizarMontoAPagar(Convert.ToDecimal(txtMonto.Text), cuotas);

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


            ActualizarMontoAPagar(Convert.ToDecimal(txtMonto.Text), cuotas);


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

        private void ImprimirTicket()
        {

            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += new PrintPageEventHandler(ImprimirTicketContenido);

            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.PrinterSettings.PrinterName = printDialog.PrinterSettings.PrinterName;
                printDocument.Print();
            }
        }

        private void ImprimirTicketContenido(object sender, PrintPageEventArgs e)
        {

            string ticket = GenerarTicket(totalCosto, comboBox3.Text, ObtenerNombresActividades());


            Font font = new Font("Arial", 10);
            SolidBrush brush = new SolidBrush(Color.Black);


            float yPos = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;


            foreach (var line in ticket.Split('\n'))
            {
                e.Graphics.DrawString(line, font, brush, leftMargin, topMargin + yPos);
                yPos += font.GetHeight();
            }
        }
        private string GenerarTicket(decimal monto, string metodoPago, List<string> actividadesPagadas)
        {
            StringBuilder ticketBuilder = new StringBuilder();


            ticketBuilder.AppendLine("----- GYM NO PAIN NO GAIN -----");
            ticketBuilder.AppendLine("----- Ticket de Pago -----");
            ticketBuilder.AppendLine($"Fecha: {DateTime.Now}");
            ticketBuilder.AppendLine($"Monto: {monto:C}");
            ticketBuilder.AppendLine($"Método de Pago: {metodoPago}");
            ticketBuilder.AppendLine();


            ticketBuilder.AppendLine("Actividades Pagadas:");
            foreach (var actividad in actividadesPagadas)
            {
                ticketBuilder.AppendLine($"- {actividad}");
            }
            ticketBuilder.AppendLine();
            ticketBuilder.AppendLine("----- Gracias por su compra -----");
            ticketBuilder.AppendLine();
            ticketBuilder.AppendLine("Recuerde traer el ticket el dia de su clase");



            return ticketBuilder.ToString();
        }


        private List<string> ObtenerNombresActividades()
        {
            List<string> nombresActividades = new List<string>();

            if (dataGridView2.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    string nombreActividad = row.Cells["Nombre"].Value.ToString();
                    string fechaInicio = row.Cells["FechaInicio"].Value.ToString();
                    string diasSemana = row.Cells["DiasSemana"].Value.ToString();
                    nombresActividades.Add(nombreActividad + " " + fechaInicio + " " + diasSemana);
                }
            }

            return nombresActividades;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ImprimirTicket();
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (Controlblanco() == true)
            {

                btnSiguienteP1.Enabled = false;
                btnSiguienteP1.Text = "Complete todos los campos";
            }
            else
            {


                btnSiguienteP1.Text = "Siguiente";
            }
        }


    }

}
