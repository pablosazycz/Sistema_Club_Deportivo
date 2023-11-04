using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Sistema_Club_Deportivo;
using Sistema_Club_Deportivo.Modelo;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Login.Datos
{
    public class Administrador
    {
        public DataTable Log_Adm(string L_Adm, string P_Adm)
        {
            MySqlDataReader resultado; // variable de tipo datareader

            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                // el comando es un elemento que almacena en este caso el nombre
                // del procedimiento almacenado y la referencia a la conexion

                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);

                comando.CommandType = CommandType.StoredProcedure;

                // definimos los parametros que tiene el procedure
                comando.Parameters.Add("Adm", MySqlDbType.VarChar).Value = L_Adm;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = P_Adm;  

                // abrimos la conexion
                sqlCon.Open();
                resultado = comando.ExecuteReader(); // almacenamos el resulatdo en la variable
                tabla.Load(resultado); // cargamos la tabla con el resultado
                return tabla;
                // de esta forma esta asociado el metodo con el procedure que esta almacenado en MySQL

            }
            catch (Exception ex)
            {
                throw ex;
            }
            // como proceso final
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
        }

       
        //public int CrearPersona(int idRol, string nombre, string apellido, string tipoDoc, int dni, DateTime fechaNacimiento, string direccion, int cp, string localidad, string correoElect, int telefono1, int telefono2)
        //{
        //    MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
        //    int idPersona = -1; // Inicializamos en un valor no válido

        //    try
        //    {
        //        sqlCon.Open();

        //        MySqlCommand cmd = new MySqlCommand("CrearPersona", sqlCon);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.Add(new MySqlParameter("p_idRol", idRol));
        //        cmd.Parameters.Add(new MySqlParameter("p_nombre", nombre));
        //        cmd.Parameters.Add(new MySqlParameter("p_apellido", apellido));
        //        cmd.Parameters.Add(new MySqlParameter("p_tipoDoc", tipoDoc));
        //        cmd.Parameters.Add(new MySqlParameter("p_dni", dni));
        //        cmd.Parameters.Add(new MySqlParameter("p_fechaNacimiento", fechaNacimiento));
        //        cmd.Parameters.Add(new MySqlParameter("p_direccion", direccion));
        //        cmd.Parameters.Add(new MySqlParameter("p_cp", cp));
        //        cmd.Parameters.Add(new MySqlParameter("p_localidad", localidad));
        //        cmd.Parameters.Add(new MySqlParameter("p_correoElect", correoElect));
        //        cmd.Parameters.Add(new MySqlParameter("p_telefono1", telefono1));
        //        cmd.Parameters.Add(new MySqlParameter("p_telefono2", telefono2));

        //        cmd.Parameters.Add(new MySqlParameter("p_lastInsertId", MySqlDbType.Int32));
        //        cmd.Parameters["p_lastInsertId"].Direction = ParameterDirection.Output;

        //        cmd.ExecuteNonQuery();

        //        // Obtén el último ID insertado
        //        idPersona = Convert.ToInt32(cmd.Parameters["p_lastInsertId"].Value);

        //    }
        //    catch (Exception ex)
        //    {
        //        // Manejar errores
        //        throw;
        //    }
        //    finally
        //    {
        //        if (sqlCon.State == ConnectionState.Open)
        //        {
        //            sqlCon.Close();
        //        }
        //    }

        //    return idPersona;
        //}

        //public void CrearAfiliado(int idPersona, DateTime fechaAfiliacion, int esSocio, int cuotaAPagar)
        //{
        //    MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
        //    int idAfiliado = -1; // Inicializa en un valor no válido
        //    try
        //    {
        //        sqlCon.Open();

        //        MySqlCommand cmd = new MySqlCommand("CrearAfiliado", sqlCon);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.Add(new MySqlParameter("p_idPersona", idPersona)); // Asocia el afiliado con la persona
        //        cmd.Parameters.Add(new MySqlParameter("p_fechaAfiliacion", fechaAfiliacion));
        //        cmd.Parameters.Add(new MySqlParameter("p_socio", esSocio));
        //        //cmd.Parameters.Add(new MySqlParameter("p_nroCarnet", nroCarnet));
        //        cmd.Parameters.Add(new MySqlParameter("p_cuotaAPagar", cuotaAPagar));
        //        cmd.Parameters.Add(new MySqlParameter("p_idAfiliado", MySqlDbType.Int32));
        //        cmd.Parameters["p_idAfiliado"].Direction = ParameterDirection.Output;
        //        cmd.ExecuteNonQuery();

        //        idAfiliado = Convert.ToInt32(cmd.Parameters["p_idAfiliado"].Value);
        //    }
        //    catch (Exception ex)
        //    {
        //        // Manejar errores
        //        throw;
        //    }
        //    finally
        //    {
        //        if (sqlCon.State == ConnectionState.Open)
        //        {
        //            sqlCon.Close();
        //        }
        //    }
        //}
        
       public int CrearPersonaObj(Persona persona)
        {
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            int idPersona = -1; // Inicializamos en un valor no válido

            try
            {
                sqlCon.Open();

                MySqlCommand cmd = new MySqlCommand("CrearPersona", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("p_idRol", persona.IdRol));
                cmd.Parameters.Add(new MySqlParameter("p_nombre", persona.Nombre));
                cmd.Parameters.Add(new MySqlParameter("p_apellido", persona.Apellido));
                cmd.Parameters.Add(new MySqlParameter("p_tipoDoc", persona.TipoDoc));
                cmd.Parameters.Add(new MySqlParameter("p_dni", persona.Dni));
                cmd.Parameters.Add(new MySqlParameter("p_fechaNacimiento", persona.FechaNacimiento));
                cmd.Parameters.Add(new MySqlParameter("p_direccion", persona.Direccion));
                cmd.Parameters.Add(new MySqlParameter("p_cp", persona.Cp));
                cmd.Parameters.Add(new MySqlParameter("p_localidad", persona.Localidad));
                cmd.Parameters.Add(new MySqlParameter("p_correoElect", persona.CorreoElect));
                cmd.Parameters.Add(new MySqlParameter("p_telefono1", persona.Telefono1));
                cmd.Parameters.Add(new MySqlParameter("p_telefono2", persona.Telefono2));

                cmd.Parameters.Add(new MySqlParameter("p_lastInsertId", MySqlDbType.Int32));
                cmd.Parameters["p_lastInsertId"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                // Obtén el último ID insertado
                idPersona = Convert.ToInt32(cmd.Parameters["p_lastInsertId"].Value);
                persona.Id = idPersona;
            }
            catch (Exception ex)
            {
                // Manejar errores
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            return idPersona;
        }

       public int CrearAfiliadoObj(Afiliado afiliado)
        {
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            int idAfiliado = -1; // Inicializa en un valor no válido
            try
            {
                sqlCon.Open();

                MySqlCommand cmd = new MySqlCommand("CrearAfiliado", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("p_idPersona", afiliado.IdPersona)); // Asocia el afiliado con la persona
                cmd.Parameters.Add(new MySqlParameter("p_fechaAfiliacion", afiliado.FechaAfiliacion));
                cmd.Parameters.Add(new MySqlParameter("p_socio", afiliado.Socio));
                //cmd.Parameters.Add(new MySqlParameter("p_nroCarnet", nroCarnet));
                cmd.Parameters.Add(new MySqlParameter("p_cuotaAPagar", afiliado.CuotaAPagar));
                cmd.Parameters.Add(new MySqlParameter("p_idAfiliado", MySqlDbType.Int32));
                cmd.Parameters["p_idAfiliado"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                idAfiliado = Convert.ToInt32(cmd.Parameters["p_idAfiliado"].Value);
                afiliado.Id = idAfiliado;
                return idAfiliado;
            }
            catch (Exception ex)
            {
                // Manejar errores
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }   
        }
    

        public void CrearCarnetAutomatico(out DateTime fechaVencimiento, out long nroCarnet)
        {
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            fechaVencimiento = DateTime.MinValue; // Inicializa la fecha de vencimiento
            nroCarnet = 0;
            try
            {
                sqlCon.Open();

                MySqlCommand cmd = new MySqlCommand("CrearCarnetAutomatico", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                // Parámetro de salida para obtener el último ID de afiliado
                cmd.Parameters.Add(new MySqlParameter("p_lastInsertIdAfiliado", MySqlDbType.Int32));
                cmd.Parameters["p_lastInsertIdAfiliado"].Direction = ParameterDirection.Output;
                
                cmd.ExecuteNonQuery();


                MySqlCommand cmdSelect = new MySqlCommand("SELECT expira, nroCarnet FROM Carnet ORDER BY nroCarnet DESC LIMIT 1", sqlCon);
                using (MySqlDataReader reader = cmdSelect.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        fechaVencimiento = reader.GetDateTime(0); // Obtiene la fecha de expiración
                        nroCarnet = reader.GetInt64(1); // Obtiene el número de carnet
                    }
                }


                Console.WriteLine("Carnet generado automáticamente con éxito.");
            }
            catch (Exception ex)
            {
                // Maneja errores
                Console.WriteLine("Error al generar el carnet: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        public Afiliado BuscarAfiliadoPorDni (int dniPersona)
        {
            Afiliado afiliado = null; // Inicializa a null
            Persona persona = null; // Inicializa a null
            Carnet carnet = null; // Inicializa a null
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                MySqlCommand cmd = new MySqlCommand("BuscarAfiliadoPorDni", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("p_dniPersona", dniPersona));
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (afiliado == null)
                    {
                        afiliado = new Afiliado();
                    }

                    if (persona == null)
                    {
                        persona = new Persona();
                    }

                    if (carnet == null)
                    {
                        carnet = new Carnet();
                    }

                    // Llena los datos de la persona
                    persona.Id = reader.GetInt32(5);
                    persona.IdRol = reader.GetInt32(6);
                    persona.Nombre = reader.GetString(7);
                    persona.Apellido = reader.GetString(8);
                    persona.TipoDoc = reader.GetString(9);
                    persona.Dni = reader.GetInt32(10);
                    persona.FechaNacimiento = reader.GetDateTime(11);
                    persona.Direccion = reader.GetString(12);
                    persona.Cp = reader.GetInt32(13);
                    persona.Localidad = reader.GetString(14);
                    persona.CorreoElect = reader.GetString(15);
                    persona.Telefono1 = reader.GetInt32(16);
                    persona.Telefono2 = reader.GetInt32(17);
              

                    // Llena los datos del afiliado
                    afiliado.Id = reader.GetInt32(0);
                    afiliado.FechaAfiliacion = reader.GetDateTime(1);
                    afiliado.Socio = reader.GetInt32(2);
                    //afiliado.NroCarnet = reader.GetInt32(3);
                    afiliado.CuotaAPagar = reader.GetInt32(3);
                    afiliado.IdPersona = reader.GetInt32(4);


                    // Establece el objeto Persona en el objeto Afiliado
                    afiliado.Persona = persona;
                    
                    carnet.NroCarnet = reader.GetInt64(18);
                    //carnet.FechaVencimiento = reader.GetDateTime(19);
                    afiliado.Carnet = carnet;
                }

                return afiliado;
            
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); }
            }   
        }

        public void EditarAfiliado(Afiliado afiliado)
        {
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();

            try
            {
                sqlCon.Open();

                MySqlCommand cmd = new MySqlCommand("EditarAfiliado", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agrega parámetros para actualizar los campos específicos del afiliado
                cmd.Parameters.Add(new MySqlParameter("p_idAfiliado", afiliado.Id));
                cmd.Parameters.Add(new MySqlParameter("p_fechaAfiliacion", afiliado.FechaAfiliacion));
                cmd.Parameters.Add(new MySqlParameter("p_socio", afiliado.Socio));
                //cmd.Parameters.Add(new MySqlParameter("p_nroCarnet", afiliado.NroCarnet));
                cmd.Parameters.Add(new MySqlParameter("p_cuotaAPagar", afiliado.CuotaAPagar));

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Maneja excepciones si es necesario.
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        public void EditarPersona(Persona persona){
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();


                MySqlCommand cmd = new MySqlCommand("EditarPersona", sqlCon);
                
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("p_idPersona", persona.Id));
                    cmd.Parameters.Add(new MySqlParameter("p_idRol", persona.IdRol));
                    cmd.Parameters.Add(new MySqlParameter("p_nombre", persona.Nombre));
                    cmd.Parameters.Add(new MySqlParameter("p_apellido", persona.Apellido));
                    cmd.Parameters.Add(new MySqlParameter("p_tipoDoc", persona.TipoDoc));
                    cmd.Parameters.Add(new MySqlParameter("p_dni", persona.Dni));
                    cmd.Parameters.Add(new MySqlParameter("p_fechaNacimiento", persona.FechaNacimiento));
                    cmd.Parameters.Add(new MySqlParameter("p_direccion", persona.Direccion));
                    cmd.Parameters.Add(new MySqlParameter("p_cp", persona.Cp));
                    cmd.Parameters.Add(new MySqlParameter("p_localidad", persona.Localidad));
                    cmd.Parameters.Add(new MySqlParameter("p_correoElect", persona.CorreoElect));
                    cmd.Parameters.Add(new MySqlParameter("p_telefono1", persona.Telefono1));
                    cmd.Parameters.Add(new MySqlParameter("p_telefono2", persona.Telefono2));

                    cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); }
            }
        }


    }
}
