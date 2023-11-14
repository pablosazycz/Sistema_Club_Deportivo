using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Sistema_Club_Deportivo
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
            OcultarTodosSubMenus();
        }

        private bool yaPreguntado = false;

        private void VentanaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!yaPreguntado)
            {
                DialogResult resultado = MessageBox.Show("¿Desea salir del sistema?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    yaPreguntado = true; // Marcar como que ya se hizo la pregunta
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void OcultarTodosSubMenus()
        {
            pnl1SubMenuAfiliados.Visible = false;
            pnl2SubMenuProfes.Visible = false;
            pnl3SubMenuServNutric.Visible = false;
        }

        private void OcultarSubMenu()
        {
            if (pnl1SubMenuAfiliados.Visible == true)
                pnl1SubMenuAfiliados.Visible = false;
            if (pnl2SubMenuProfes.Visible == true)
                pnl2SubMenuProfes.Visible = false;
            if (pnl3SubMenuServNutric.Visible == true)
                pnl3SubMenuServNutric.Visible = false;
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private Form FormActivo = null;
        private void abrirPanelHijo(Form formularioHijo)
        {
            if (FormActivo != null)
                FormActivo.Close();
            FormActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelHijoForm.Controls.Add(formularioHijo);
            panelHijoForm.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }


        private void btnSubPanelAfiliados_Click_1(object sender, EventArgs e)
        {
            MostrarSubMenu(pnl1SubMenuAfiliados);
        }

        private void btnSubVCarnets_Click(object sender, EventArgs e)
        {
            // agregar codigo Formulario
            OcultarSubMenu();
        }

        private void btnSubVPagos_Click(object sender, EventArgs e)
        {
            // agregar codigo Formulario
            OcultarSubMenu();
        }

        private void btnProfesores_Click_1(object sender, EventArgs e)
        {
            MostrarSubMenu(pnl2SubMenuProfes);
        }

        private void btnSubVProfes_Click(object sender, EventArgs e)
        {
            // agregar codigo Formulario
            OcultarSubMenu();
        }

        private void btnSubVRutinas_Click(object sender, EventArgs e)
        {
            // agregar codigo Formulario
            OcultarSubMenu();
        }

        private void btnSubVAsistencia_Click(object sender, EventArgs e)
        {
            // agregar codigo Formulario
            OcultarSubMenu();
        }

        private void btnNutricion_Click_1(object sender, EventArgs e)
        {
            MostrarSubMenu(pnl3SubMenuServNutric);
        }

        private void btnSubVTurDisp_Click(object sender, EventArgs e)
        {
            // agregar codigo Formulario
            OcultarSubMenu();
        }

        private void btnSubVTurAsig_Click(object sender, EventArgs e)
        {
            // agregar codigo Formulario
            OcultarSubMenu();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void VentanaPrincipal_Load_1(object sender, EventArgs e)
        {

        }

        private void panelHijoForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubVAfiliados_Click_1(object sender, EventArgs e)
        {
            abrirPanelHijo(new Afiliados());
        }

        private void btnSubVCarnets_Click_1(object sender, EventArgs e)
        {
            abrirPanelHijo(new Carnets());
        }

        private void btnSubVPagos_Click_1(object sender, EventArgs e)
        {
            abrirPanelHijo(new Pagos());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSubVTurDisp_Click_1(object sender, EventArgs e)
        {
            Actividades actividades = new Actividades();
            actividades.Show();
        }

































        /*
        private void btnSubVAfiliados_Click(object sender, EventArgs e)
        {
            //abrirPanelHijo(new Afiliados());
        }

        private void btnSubVCarnets_Click(object sender, EventArgs e)
        {
            //abrirPanelHijo(new Carnets());
        }

        private void btnSubVPagos_Click(object sender, EventArgs e)
        {
            //abrirPanelHijo(new Pagos());
        }*/










    }
}
