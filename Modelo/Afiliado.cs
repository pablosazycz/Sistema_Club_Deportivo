using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Club_Deportivo.Modelo
{
    public class Afiliado : Persona
    {
        public int Id { get; set; }
        public DateTime FechaAfiliacion { get; set; }
        public int Socio { get; set; }
        public int NroCarnet { get; set; }
        public int CuotaAPagar { get; set; }
        public int IdPersona { get; set; }

        public Persona Persona { get; set; }

        public Carnet Carnet { get; set; }
    }
}
