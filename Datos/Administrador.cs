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

        //public int CrearPersonaObj(Persona persona)
        //{
        //    MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
        //    int idPersona = -1; // Inicializa en un valor no válido

        //    try
        //    {
        //        sqlCon.Open();

        //        // Verificar si la persona ya existe
        //        bool personaExistente = VerificarExistenciaPersona(persona.Dni);
        //        bool personaDadaDeBaja = false; // Obtén el estado 'eliminado' de la persona si existe

        //        if (personaExistente)
        //        {
        //            if (personaDadaDeBaja)
        //            {
        //                // La persona existe y está dada de baja, puedes optar por reactivarla si es necesario.
        //                ReactivarPersona(persona.Dni);
        //                Console.WriteLine("La persona existe y ha sido reactivada.");
        //                return 0; // Opción 0 para reactivación exitosa
        //            }
        //            else
        //            {
        //                Console.WriteLine("La persona existe y no está dada de baja.");
        //                return -1; // Opción -1 para persona existente pero no dada de baja
        //            }
        //        }
        //        else
        //        {
        //            MySqlCommand cmd = new MySqlCommand("CrearPersona", sqlCon);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.Add(new MySqlParameter("p_idRol", persona.IdRol));
        //            cmd.Parameters.Add(new MySqlParameter("p_nombre", persona.Nombre));
        //            cmd.Parameters.Add(new MySqlParameter("p_apellido", persona.Apellido));
        //            cmd.Parameters.Add(new MySqlParameter("p_tipoDoc", persona.TipoDoc));
        //            cmd.Parameters.Add(new MySqlParameter("p_dni", persona.Dni));
        //            cmd.Parameters.Add(new MySqlParameter("p_fechaNacimiento", persona.FechaNacimiento));
        //            cmd.Parameters.Add(new MySqlParameter("p_direccion", persona.Direccion));
        //            cmd.Parameters.Add(new MySqlParameter("p_cp", persona.Cp));
        //            cmd.Parameters.Add(new MySqlParameter("p_localidad", persona.Localidad));
        //            cmd.Parameters.Add(new MySqlParameter("p_correoElect", persona.CorreoElect));
        //            cmd.Parameters.Add(new MySqlParameter("p_telefono1", persona.Telefono1));
        //            cmd.Parameters.Add(new MySqlParameter("p_telefono2", persona.Telefono2));

        //            cmd.Parameters.Add(new MySqlParameter("p_lastInsertId", MySqlDbType.Int32));
        //            cmd.Parameters["p_lastInsertId"].Direction = ParameterDirection.Output;

        //            cmd.ExecuteNonQuery();

        //            // Obtén el último ID insertado
        //            idPersona = Convert.ToInt32(cmd.Parameters["p_lastInsertId"].Value);
        //            persona.Id = idPersona;

        //            Console.WriteLine("La persona ha sido creada con éxito.");
        //            return idPersona; // Retorna el ID de la persona creada
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Manejar errores
        //        Console.WriteLine("Error al crear la persona: " + ex.Message);
        //        return -2; // Opción -2 para error
        //    }
        //    finally
        //    {
        //        if (sqlCon.State == ConnectionState.Open)
        //        {
        //            sqlCon.Close();
        //        }
        //    }
        //}


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

        public Afiliado BuscarAfiliadoPorDni(int dniPersona)
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

                    // Llena los datos del afiliado
                    afiliado.Id = reader.GetInt32(0);
                    afiliado.FechaAfiliacion = reader.GetDateTime(1);
                    afiliado.Socio = reader.GetInt32(2);
                    //afiliado.NroCarnet = reader.GetInt32(3);
                    afiliado.CuotaAPagar = reader.GetInt32(3);
                    afiliado.IdPersona = reader.GetInt32(4);
                    afiliado.Eliminado = reader.GetBoolean(5);


                    // Llena los datos de la persona
                    persona.Id = reader.GetInt32(6);
                    persona.IdRol = reader.GetInt32(7);
                    persona.Nombre = reader.GetString(8);
                    persona.Apellido = reader.GetString(9);
                    persona.TipoDoc = reader.GetString(10);
                    persona.Dni = reader.GetInt32(11);
                    persona.FechaNacimiento = reader.GetDateTime(12);
                    persona.Direccion = reader.GetString(13);
                    persona.Cp = reader.GetInt32(14);
                    persona.Localidad = reader.GetString(15);
                    persona.CorreoElect = reader.GetString(16);
                    persona.Telefono1 = reader.GetInt32(17);
                    persona.Telefono2 = reader.GetInt32(18);
                    persona.Eliminado = reader.GetBoolean(19);



                    // Establece el objeto Persona en el objeto Afiliado
                    afiliado.Persona = persona;

                    carnet.NroCarnet = reader.GetInt64(20);
                    carnet.FechaVencimiento = reader.GetDateTime(22);
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

        public void EditarPersona(Persona persona)
        {
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

        public void DarDeBajaAfiliado(int idAfiliado)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();


                using (MySqlCommand cmd = new MySqlCommand("DarDeBajaAfiliado", sqlCon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_idAfiliado", idAfiliado);

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine("Error al dar de baja al afiliado: " + ex.Message);
            }
        }

        public void DarDeBajaPersona(int idPersona)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                using (MySqlCommand cmd = new MySqlCommand("DarDeBajaPersona", sqlCon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_idPersona", idPersona);

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine("Error al dar de baja a la persona: " + ex.Message);
            }
        }

        public (bool personaExiste, bool personaEliminada) VerificarExistenciaPersona(int dniPersona)
        {
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                sqlCon.Open();

                MySqlCommand cmd = new MySqlCommand("VerificarExistenciaPersona", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("p_dniPersona", dniPersona));
                cmd.Parameters.Add(new MySqlParameter("p_personaExiste", MySqlDbType.Bit));
                cmd.Parameters["p_personaExiste"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add(new MySqlParameter("p_personaEliminada", MySqlDbType.Bit));
                cmd.Parameters["p_personaEliminada"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                bool personaExiste = Convert.ToBoolean(cmd.Parameters["p_personaExiste"].Value);
                bool personaEliminada = Convert.ToBoolean(cmd.Parameters["p_personaEliminada"].Value);

                return (personaExiste, personaEliminada);
            }
        }

        public (bool personaReactivada, int idPersona, DateTime fechaVencimiento, long nroCarnet) ReactivarPersona(int dniPersona)
        {
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                sqlCon.Open();

                MySqlCommand cmd = new MySqlCommand("ReactivarPersona", sqlCon); // Supongamos que has creado un procedimiento almacenado llamado ReactivarPersona
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("p_dniPersona", dniPersona));

                // Parámetros de salida
                cmd.Parameters.Add(new MySqlParameter("p_personaReactivada", MySqlDbType.Bit));
                cmd.Parameters["p_personaReactivada"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add(new MySqlParameter("p_idAfiliado", MySqlDbType.Int32));
                cmd.Parameters["p_idAfiliado"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add(new MySqlParameter("p_fechaVencimiento", MySqlDbType.DateTime));
                cmd.Parameters["p_fechaVencimiento"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add(new MySqlParameter("p_nroCarnet", MySqlDbType.Int64));
                cmd.Parameters["p_nroCarnet"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                bool personaReactivada = Convert.ToBoolean(cmd.Parameters["p_personaReactivada"].Value);
                int idPersona = Convert.ToInt32(cmd.Parameters["p_idAfiliado"].Value);
                DateTime fechaVencimiento = Convert.ToDateTime(cmd.Parameters["p_fechaVencimiento"].Value);
                long nroCarnet = Convert.ToInt64(cmd.Parameters["p_nroCarnet"].Value);

                return (personaReactivada, idPersona, fechaVencimiento, nroCarnet);
            }
        }
public void EliminarAfiliado(int idAfiliado)
        {
                MySqlConnection sqlCon = new MySqlConnection();
                try
            {
                    sqlCon = Conexion.getInstancia().CrearConexion();
                    sqlCon.Open();
    
                    using (MySqlCommand cmd = new MySqlCommand("EliminarAfiliado", sqlCon))
                {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_idAfiliado", idAfiliado);
    
                        cmd.ExecuteNonQuery();
                    }
    
                }
                catch (Exception ex)
            {
                    // Manejo de errores
                    Console.WriteLine("Error al eliminar al afiliado: " + ex.Message);
                }
            }
    
            public void EliminarPersona(int idPersona)  
        {
                MySqlConnection sqlCon = new MySqlConnection();
                try
            {
                    sqlCon = Conexion.getInstancia().CrearConexion();
                    sqlCon.Open();
    
                    using (MySqlCommand cmd = new MySqlCommand("EliminarPersona", sqlCon))
                {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_idPersona", idPersona);
    
                        cmd.ExecuteNonQuery();
                    }
    
                }
                catch (Exception ex)
            {
                    // Manejo de errores
                    Console.WriteLine("Error al eliminar a la persona: " + ex.Message);
                }
            }
    
            public void EliminarCarnet(int idCarnet)
        {
                MySqlConnection sqlCon = new MySqlConnection();
                try
            {
                    sqlCon = Conexion.getInstancia().CrearConexion();
                    sqlCon.Open();
    
                    using (MySqlCommand cmd = new MySqlCommand("EliminarCarnet", sqlCon))
                {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_idCarnet", idCarnet);
    
                        cmd.ExecuteNonQuery();
                    }
    
                }
                catch (Exception ex)
            {
                    // Manejo de errores
                    Console.WriteLine("Error al eliminar el carnet: " + ex.Message);
                }
            }
    

    }
}
        
