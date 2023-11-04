using MySql.Data.MySqlClient;

namespace Login.Datos
{
    public class Conexion
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion con = null;

        private Conexion()
        {
            this.baseDatos = "clubdeportivobdtest";
            this.servidor = "127.0.0.1";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "Belgrano1132";



            //this.baseDatos = "bo9aun5tok0ozxiaqesq";
            //this.servidor = "bo9aun5tok0ozxiaqesq-mysql.services.clever-cloud.com";
            //this.puerto = "3306";
            //this.usuario = "utetvbu5rxrcoq7k";
            //this.clave = "GExMB4o2OouPmAsghZUP";
        }

        // proceso de interaccion

        public MySqlConnection CrearConexion()
        {
            //Instanciamos una conexion
            MySqlConnection cadena = new MySqlConnection();

            // el bloque try controla errores
            try
            {
                cadena.ConnectionString = 
                    "datasource=" + this.servidor +
                    ";port=" + this.puerto +
                    ";username=" + this.usuario +
                    ";password=" + this.clave +
                    ";Database=" + this.baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw;
            }
            return cadena;
        }
        //para evaluar la instancia de la conectividad
        public static Conexion getInstancia()
        {
            if(con == null) // si la conexion esta cerrada
            {
                con = new Conexion(); //se crea una nueva
            }
            return con; 
        }
    }
}
