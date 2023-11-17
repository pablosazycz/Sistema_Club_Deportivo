using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Club_Deportivo.Modelo
{
    public class InscripcionActividad
    {
        public int InscripcionID { get; set; }
        public int NoAfiliadoID { get; set; }
        public int ActividadID { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int PagoID { get; set; }
      
    }

}
