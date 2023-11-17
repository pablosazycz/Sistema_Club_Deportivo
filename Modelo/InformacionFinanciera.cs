using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Club_Deportivo.Modelo
{
    public class InformacionFinanciera
    {
        public int AfiliadoID { get; set; }
        public string NumeroTarjetaCredito { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public int CodigoSeguridad { get; set; }

        public Afiliado Afiliado { get; set; }

    }
}
