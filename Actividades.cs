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
    public partial class Actividades : Form
    {
        public Actividades()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Actividades_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string nombre = txtNombre.Text;
                string descripcion = txtDescripcion.Text;
                int cupoMaximo = Convert.ToInt32(txtCupoMaximo.Text);
                DateTime fechaInicio = dtpFechaInicio.Value;
                DateTime fechaFin = dtpFechaFin.Value;
                TimeSpan horaInicio = TimeSpan.Parse(horaInicioPick.Text);
                TimeSpan horaFin = TimeSpan.Parse(horaFinPick.Text);
                decimal costo = Convert.ToDecimal(txtCosto.Text);
                int profesorId = Convert.ToInt32(txtProfesorID.Text);
                string equipamiento = txtEquipamiento.Text;
                string diasSemana = txtDia.Text;

                Actividad nuevaActividad = new Actividad
                {
                    Nombre = nombre,
                    Descripcion = descripcion,
                    CupoMaximo = cupoMaximo,
                    FechaInicio = fechaInicio,
                    FechaFin = fechaFin,
                    HoraInicio = horaInicio,
                    HoraFin = horaFin,
                    Costo = costo,
                    ProfesorID = profesorId,
                    Equipamiento = equipamiento,
                    DiasSemana = diasSemana

                };

                Administrador admin = new Administrador();
                admin.CrearActividad(nuevaActividad);

                MessageBox.Show("Actividad creada correctamente.");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al crear la actividad: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Administrador admin = new Administrador();
                List<Actividad> actividades = admin.ObtenerActividades();

                // Lógica para mostrar la lista de actividades en tu formulario
                MostrarActividadesEnFormulario(actividades);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener las actividades: {ex.Message}");
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

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
               
                int indiceSeleccionado = dataGridView1.SelectedRows[0].Index;
            
                Actividad actividadSeleccionada = ObtenerActividadDesdeDataGridView(indiceSeleccionado);

                Administrador actividadManager = new Administrador();
                actividadManager.EliminarActividad(actividadSeleccionada.ActividadID);

                MessageBox.Show("Actividad eliminada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la actividad: {ex.Message}");
            }

        }


        private Actividad ObtenerActividadDesdeDataGridView(int indice)
        {
           
            if (indice >= 0 && indice < dataGridView1.Rows.Count)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[indice];

                int actividadId = int.Parse(filaSeleccionada.Cells["ActividadID"].Value.ToString());
                string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string descripcion = filaSeleccionada.Cells["Descripcion"].Value.ToString();
                TimeSpan horaInicio = TimeSpan.Parse(filaSeleccionada.Cells["HoraInicio"].Value.ToString());
                TimeSpan horaFin = TimeSpan.Parse(filaSeleccionada.Cells["HoraFin"].Value.ToString());
                DateTime fechaInicio = DateTime.Parse(filaSeleccionada.Cells["FechaInicio"].Value.ToString());
                DateTime fechaFin = DateTime.Parse(filaSeleccionada.Cells["FechaFin"].Value.ToString());
                decimal costo = decimal.Parse(filaSeleccionada.Cells["Costo"].Value.ToString());
                int profesorId = int.Parse(filaSeleccionada.Cells["ProfesorID"].Value.ToString());
                string equipamiento = filaSeleccionada.Cells["Equipamiento"].Value.ToString();
                string diasSemana = filaSeleccionada.Cells["DiasSemana"].Value.ToString();
                int cupoMaximo = int.Parse(filaSeleccionada.Cells["CupoMaximo"].Value.ToString());


                Actividad actividadSeleccionada = new Actividad
                {
                    ActividadID = actividadId,
                    Nombre = nombre,
                    Descripcion = descripcion,
                    HoraInicio = horaInicio,
                    HoraFin = horaFin,
                    FechaInicio = fechaInicio,
                    FechaFin = fechaFin,
                    Costo = costo,
                    ProfesorID = profesorId,
                    Equipamiento = equipamiento,
                    DiasSemana = diasSemana,
                    CupoMaximo = cupoMaximo


                };

                return actividadSeleccionada;
            }
            else
            {
               
                throw new ArgumentOutOfRangeException("Índice fuera de los límites");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
             
                int indiceSeleccionado = dataGridView1.SelectedRows[0].Index;
                Actividad actividadSeleccionada = ObtenerActividadDesdeDataGridView(indiceSeleccionado);


                actividadSeleccionada.Nombre = txtNombre.Text;
                actividadSeleccionada.Descripcion = txtDescripcion.Text;
                actividadSeleccionada.HoraInicio = TimeSpan.Parse(horaInicioPick.Text);
                actividadSeleccionada.HoraFin = TimeSpan.Parse(horaFinPick.Text);
                actividadSeleccionada.FechaInicio = dtpFechaInicio.Value;
                actividadSeleccionada.FechaFin = this.dtpFechaFin.Value;
                actividadSeleccionada.Costo = Convert.ToDecimal(txtCosto.Text);
                actividadSeleccionada.ProfesorID = Convert.ToInt32(txtProfesorID.Text);
                actividadSeleccionada.Equipamiento = txtEquipamiento.Text;
                actividadSeleccionada.DiasSemana = txtDia.Text;
                actividadSeleccionada.CupoMaximo = Convert.ToInt32(txtCupoMaximo.Text);


                Administrador actividadManager = new Administrador();
                actividadManager.ActualizarActividad(actividadSeleccionada);

                MessageBox.Show("Actividad actualizada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la actividad: {ex.Message}");
            }

        }
    }
}
