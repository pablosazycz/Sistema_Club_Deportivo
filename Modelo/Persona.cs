using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Club_Deportivo.Modelo
{
    public class Persona
    {
        public int Id { get; set; }
        public int IdRol { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set;}
        public string TipoDoc { get; set; }
        public int Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public int Cp { get; set; }
        public string Localidad { get; set; }
        public string CorreoElect { get; set; }
        public int Telefono1 { get; set; }
        public int Telefono2 { get; set; }
    }
}
