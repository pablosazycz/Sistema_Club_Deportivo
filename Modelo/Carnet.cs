using Org.BouncyCastle.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Club_Deportivo.Modelo
{
    public class Carnet
    {
        public int Id { get; set; }
        public int IdAfiliado { get; set; }
        public long NroCarnet { get; set; }
        public DateTime FechaVencimiento { get; set; }
        
        public Afiliado Afiliado { get; set; }
    }
}
