using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Club_Deportivo.Modelo
{
    public class NoAfiliado
    {
        public int Id { get; set; }
        public DateTime FechaAfiliacion { get; set; }
        public int IdPersona { get; set; }
        public bool Eliminado { get; set; }

        public Persona Persona { get; set; }

    }
}
