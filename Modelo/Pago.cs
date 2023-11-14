using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Club_Deportivo.Modelo
{
    public class Pago
    {
        public int id { get; set; }
        public int idAfiliado { get; set; }
        public DateTime FechaPago { get; set; }
        public Decimal Monto { get; set; }
        public string MetodoPago { get; set; } 
        public string Comentario { get;set; }
        public int Cuota { get; set; }
    }
}
