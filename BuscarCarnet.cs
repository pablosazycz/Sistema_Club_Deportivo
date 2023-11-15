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
    public partial class BuscarCarnet : Form
    {
        public BuscarCarnet()
        {
            InitializeComponent();
        }

        int rol = 0;
        private void btnBuscarAfil_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador();
            Carnet carnet = new Carnet();
            Afiliado afiliado = new Afiliado();
            carnet = admin.BuscarCarnetPorDni(int.Parse(txtBuscarAfil.Text));
            afiliado = admin.BuscarAfiliadoPorDni(int.Parse(txtBuscarAfil.Text));

            FormCarnet formCarnet = new FormCarnet(afiliado, carnet.FechaVencimiento, carnet.NroCarnet);
            formCarnet.Show();







        }

        private void btnBuscarCarnet_Click(object sender, EventArgs e)
        {

        }
    }
}
