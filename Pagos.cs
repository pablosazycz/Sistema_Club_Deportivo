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
    public partial class Pagos : Form
    {
        public Pagos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoAf_Click(object sender, EventArgs e)
        {

            NuevoPago nuevoPago = new NuevoPago();
            nuevoPago.Show();
        }
    }
}
