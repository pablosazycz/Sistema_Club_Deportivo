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
    public partial class TurnosActividades : Form
    {
        public TurnosActividades()
        {
            InitializeComponent();
        }

        private void TurnosActividades_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexion = Conexion.getInstancia().CrearConexion())
                {
                    conexion.Open();

                    string consulta = @"
               SELECT p.nombre as Nombre,
                    p.apellido as Apellido,
                    p.tipoDoc as Doc,
                    p.dni as NroDoc,
                    act.Nombre as Actividad,
                    act.Descripcion as Descripcion,
                    act.FechaInicio as Comienzo,
                    act.FechaFin as Fin,
                    act.HoraInicio as 'Hora Inicio',
                    act.HoraFin as 'Hora Fin',
                    act.DiasSemana as Dias,
                    act.CupoMaximo as Cupo

                FROM clubdeportivobdtest.inscripcionactividad i
                    join noafiliado na
                    on i.NoAfiliadoID= na.Id
                    join persona p
                    on na.idPersona=p.id
                    join actividades act
                    on i.ActividadID= act.ActividadID
                    ";

                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    DataTable tablaIngresos = new DataTable();
                    adaptador.Fill(tablaIngresos);



                    dataGridView1.DataSource = tablaIngresos;




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


    }
}
