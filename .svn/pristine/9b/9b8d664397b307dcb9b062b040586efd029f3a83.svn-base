using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class Acceso
    {
        #region Atributos

        private string strconexion = Properties.Settings.Default.Conexion;
        private SqlConnection objconexion;

        #endregion

        #region Constructor

        public Acceso()
        {
            try
            {
                //Inicializa la conexion con la cadena 
                objconexion = new SqlConnection(strconexion);
                this.ABRIRCONEXION();  //se abre conexión
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRARCONEXION(); //Cierre de conexión
            }
        }

        #endregion

        #region Metodos privados

        private void ABRIRCONEXION()
        {
            if (objconexion.State == System.Data.ConnectionState.Closed)
                objconexion.Open();
        }

        private void CERRARCONEXION()
        {
            if (objconexion.State == System.Data.ConnectionState.Open)
                objconexion.Close();
        }

        #endregion

        #region Metodos publicos

        /// <summary>
        /// Método que se encarga de ejecutar las inserciones, modificaciones o eliminaciones de
        /// base de datos
        /// </summary>
        /// <param name="P_Peticion">Entidad de tipo SQL Parametros</param>
        /// <returns>1 = SATISFACTORIO | 0 = ERROR</returns>
        public int Ejecutar_Peticiones(SQLParametros P_Peticion)
        {
            try
            {
                //Este objeto se encarga de las configuraciones necesarias para conectarse a BD
                //Ademas de contener un metodo para la ejecucion de esa petición contra la BD
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = objconexion; //Identifica la conexion a la BD
                cmd.CommandType = System.Data.CommandType.Text; //Se especifica el tipo de formato de sentencia a ejecutar
                cmd.CommandText = P_Peticion.Peticion; //Aqui se asigna la peticion construida

                if (P_Peticion.LstParametros.Count > 0)  //Validar si tiene parametros, y agregarlos
                    cmd.Parameters.AddRange(P_Peticion.LstParametros.ToArray());

                this.ABRIRCONEXION();
                //cmd.Connection.Open();
                return cmd.ExecuteNonQuery(); //Método que ejecuta la peticion en base de datos
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRARCONEXION();
            }
        }

        #region Para transaccion

        /// <summary>
        /// Método que se encarga de agregar a la lista de peticiones por ejecutar la nueva petición 
        /// recibida
        /// </summary>
        /// <param name="P_Peticion">Entidad de Tipo SQLParametros</param>
        /// <param name="P_Lista">Entidad de tipo SQLCommand y es una Lista</param>
        public void AgregarPeticionEnListado(SQLParametros P_Peticion, ref List<SqlCommand> P_Lista)
        {
            //Este objeto se encarga de las configuraciones necesarias para conectarse a BD
            //Ademas de contener un metodo para la ejecucion de esa petición contra la BD
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = objconexion; //Identifica la conexion a la BD
            cmd.CommandType = System.Data.CommandType.Text; //Se especifica el tipo de formato de sentencia a ejecutar
            cmd.CommandText = P_Peticion.Peticion; //Aqui se asigna la peticion construida

            if (P_Peticion.LstParametros.Count > 0)  //Validar si tiene parametros, y agregarlos
                cmd.Parameters.AddRange(P_Peticion.LstParametros.ToArray());

            P_Lista.Add(cmd); //Aqui se agrega nuevo item a la lista de comandos por ejecutar en la transaccion
        }

        /// <summary>
        /// Método que se encarga de la ejecución de las peticiones una a una, es decir, realiza 
        /// la ejecución de la trasaccion
        /// </summary>
        /// <param name="P_Lista">Entidad Lista de tipo SQLCommand</param>
        /// <returns>1 = Satisfactorio | 0 = No es satisfactorio</returns>
        public int EjecutarTransaccion(List<SqlCommand> P_Lista)
        {
            SqlTransaction objtransaccion;
            ABRIRCONEXION();
            objtransaccion = objconexion.BeginTransaction();

            try
            {
                //Recorre la lista de peticiones y ejecuta en memoria la peticion uno a uno
                //En este momento todo esta en una simulación
                foreach (SqlCommand cmd in P_Lista)
                {
                    cmd.Transaction = objtransaccion;
                    cmd.Connection = objconexion;
                    cmd.ExecuteNonQuery(); //Aqui es donde verifica si es correcta la ejecucion de la peticion
                }
                objtransaccion.Commit(); //Este realiza los cambios de forma permanente en BD
                return 1;
            }
            catch (Exception ex)
            {
                objtransaccion.Rollback(); //En caso de error elimina cualquier cambio efectuado
                throw ex;
            }
            finally
            {
                objtransaccion.Dispose();
                CERRARCONEXION();
            }

        }

        #endregion

        /// <summary>
        /// Método que se encarga de confirmar existencia de usuario
        /// </summary>
        /// <param name="P_Peticion">Entidad de tipo SQL Parametros</param>
        /// <returns>Lista de entidades de tipo usuarios</returns>
        public List<Usuarios> VerificarUsuario(SQLParametros P_Peticion)
        {
            List<Usuarios> lstusuarios = new List<Usuarios>();

            try
            {
                //Este objeto se encarga de las configuraciones necesarias para conectarse a BD
                //Ademas de contener un metodo para la ejecucion de esa petición contra la BD
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = objconexion; //Identifica la conexion a la BD
                cmd.CommandType = System.Data.CommandType.Text; //Se especifica el tipo de formato de sentencia a ejecutar
                cmd.CommandText = P_Peticion.Peticion; //Aqui se asigna la peticion construida

                if (P_Peticion.LstParametros.Count > 0)  //Validar si tiene parametros, y agregarlos
                    cmd.Parameters.AddRange(P_Peticion.LstParametros.ToArray());

                //Objeto que es el que se encarga de ejecutar la consulta y recibir el resultado
                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);

                //Variable temporal para captura respuesta
                DataTable dt = new DataTable();
                objconsulta.Fill(dt); //Aqui se envia la peticion a ejecutar en BD y recibe la respuesta,
                                      //esta respuesta se carga en el DT

                if (dt.Rows.Count > 0) //Verifica si la consulta devolvio registros
                {
                    //Es un ciclo que toma uno a uno los elementos de la coleccion que se este recorriendo
                    foreach (DataRow fila in dt.Rows)
                    {
                        Usuarios u = new Usuarios();

                        //Aqui se obtiene los valores de celda o columna por fila leida
                        u.IdUsuario = fila.ItemArray[0].ToString();
                        u.Nombre = fila.ItemArray[1].ToString();
                        u.Contrasena = fila.ItemArray[2].ToString();
                        u.Email = fila.ItemArray[3].ToString();
                        u.Estado = Convert.ToBoolean(fila.ItemArray[4].ToString());

                        lstusuarios.Add(u);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CERRARCONEXION();
            }
            return lstusuarios;
        }

        /// <summary>
        /// Método que se encarga de ejecutar las consultas a PrestamosxCliente
        /// </summary>
        /// <param name="P_Peticion">Entidad de tipo SQL Parametros</param>
        /// <returns>Lista de entidades de tipo cliente</returns>
        public List<Prestamos> ConsultarPrestamosPorCliente(SQLParametros P_Peticion)
        {
            //Variable temporal que conservara respuesta de BD
            List<Prestamos> lstresultados = new List<Prestamos>();

            try
            {
                //Este objeto se encarga de las configuraciones necesarias para conectarse a BD
                //Ademas de contener un metodo para la ejecucion de esa petición contra la BD
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = objconexion; //Identifica la conexion a la BD
                cmd.CommandType = System.Data.CommandType.Text; //Se especifica el tipo de formato de sentencia a ejecutar
                cmd.CommandText = P_Peticion.Peticion; //Aqui se asigna la peticion construida

                if (P_Peticion.LstParametros.Count > 0)  //Validar si tiene parametros, y agregarlos
                    cmd.Parameters.AddRange(P_Peticion.LstParametros.ToArray());

                //Objeto que es el que se encarga de ejecutar la consulta y recibir el resultado
                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);

                //Variable temporal para captura respuesta
                DataTable dt = new DataTable();
                objconsulta.Fill(dt); //Aqui se envia la peticion a ejecutar en BD y recibe la respuesta,
                                      //esta respuesta se carga en el DT

                if (dt.Rows.Count > 0) //Verifica si la consulta devolvio registros
                {
                    //Es un ciclo que toma uno a uno los elementos de la coleccion que se este recorriendo
                    foreach (DataRow fila in dt.Rows)
                    {

                        //Aqui se obtiene los valores de celda o columna por fila leida
                        Prestamos Prestamo = new Prestamos
                        {
                            IdPrestamo = Convert.ToInt32(fila.ItemArray[0].ToString()),
                            Estado = fila.ItemArray[1].ToString(),
                            Monto = Convert.ToDecimal(fila.ItemArray[2].ToString()),
                            TasaInteres = Convert.ToDecimal(fila.ItemArray[3].ToString()),
                            Plazo = fila.ItemArray[4].ToString(),
                            FrecuenciaPago = fila.ItemArray[5].ToString(),
                            FechaPago = fila.ItemArray[6].ToString(),
                            FechaSolicitud = Convert.ToDateTime(fila.ItemArray[7].ToString())
                        };

                        lstresultados.Add(Prestamo);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRARCONEXION();
            }

            return lstresultados;
        }

        /// <summary>
        /// Método que se encarga de ejecutar las consultas a tabla prestamos
        /// </summary>
        /// <param name="P_Peticion">Entidad de tipo SQL Parametros</param>
        /// <returns>Lista de entidades de tipo prestamo</returns>
        public List<Prestamos> ConsultarPrestamosPorEstado(SQLParametros P_Peticion)
        {
            List<Prestamos> lstprestamos = new List<Prestamos>();

            try
            {
                //Este objeto se encarga de las configuraciones necesarias para conectarse a BD
                //Ademas de contener un metodo para la ejecucion de esa petición contra la BD
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = objconexion; //Identifica la conexion a la BD
                cmd.CommandType = System.Data.CommandType.Text; //Se especifica el tipo de formato de sentencia a ejecutar
                cmd.CommandText = P_Peticion.Peticion; //Aqui se asigna la peticion construida

                if (P_Peticion.LstParametros.Count > 0)  //Validar si tiene parametros, y agregarlos
                    cmd.Parameters.AddRange(P_Peticion.LstParametros.ToArray());

                //Objeto que es el que se encarga de ejecutar la consulta y recibir el resultado
                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);

                //Variable temporal para captura respuesta
                DataTable dt = new DataTable();
                objconsulta.Fill(dt); //Aqui se envia la peticion a ejecutar en BD y recibe la respuesta,
                                      //esta respuesta se carga en el DT

                if (dt.Rows.Count > 0) //Verifica si la consulta devolvio registros
                {
                    //Es un ciclo que toma uno a uno los elementos de la coleccion que se este recorriendo
                    foreach (DataRow fila in dt.Rows)
                    {
                        Prestamos p = new Prestamos();

                        //Aqui se obtiene los valores de celda o columna por fila leida
                        p.IdPrestamo = Convert.ToInt32(fila.ItemArray[0].ToString());
                        p.Estado = fila.ItemArray[1].ToString();
                        p.Monto = Convert.ToDecimal(fila.ItemArray[2].ToString());
                        p.TasaInteres = Convert.ToDecimal(fila.ItemArray[3].ToString());
                        p.Plazo = fila.ItemArray[4].ToString();
                        p.FrecuenciaPago = fila.ItemArray[5].ToString();
                        p.FechaPago = fila.ItemArray[6].ToString();

                        lstprestamos.Add(p);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CERRARCONEXION();
            }
            return lstprestamos;
        }

        /// <summary>
        /// Método que se encarga de ejecutar las consultas a tabla Usuarios
        /// </summary>
        /// <param name="P_Peticion">Entidad de tipo SQL Parametros</param>
        /// <returns>Lista de entidades de tipo usuarios</returns>
        public List<Usuarios> ConsultarUsuarios(SQLParametros P_Peticion)
        {
            List<Usuarios> lstUsuarios = new List<Usuarios>();

            try
            {
                //Este objeto se encarga de las configuraciones necesarias para conectarse a BD
                //Ademas de contener un metodo para la ejecucion de esa petición contra la BD
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = objconexion; //Identifica la conexion a la BD
                cmd.CommandType = System.Data.CommandType.Text; //Se especifica el tipo de formato de sentencia a ejecutar
                cmd.CommandText = P_Peticion.Peticion; //Aqui se asigna la peticion construida

                //Objeto que es el que se encarga de ejecutar la consulta y recibir el resultado
                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);

                //Variable temporal para captura respuesta
                DataTable dt = new DataTable();
                objconsulta.Fill(dt); //Aqui se envia la peticion a ejecutar en BD y recibe la respuesta,
                                      //esta respuesta se carga en el DT

                if (dt.Rows.Count > 0) //Verifica si la consulta devolvio registros
                {
                    //Es un ciclo que toma uno a uno los elementos de la coleccion que se este recorriendo
                    foreach (DataRow fila in dt.Rows)
                    {
                        Usuarios u = new Usuarios();

                        //Aqui se obtiene los valores de celda o columna por fila leida
                        u.IdUsuario = fila.ItemArray[0].ToString();
                        u.Nombre = fila.ItemArray[1].ToString();
                        u.Contrasena = fila.ItemArray[2].ToString();
                        u.Email = fila.ItemArray[3].ToString();
                        u.Estado = Convert.ToBoolean(fila.ItemArray[4].ToString());

                        lstUsuarios.Add(u);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CERRARCONEXION();
            }
            return lstUsuarios;
        }

        /// <summary>
        /// Método que se encarga de ejecutar las consultas a tabla Clientes
        /// </summary>
        /// <param name="P_Peticion">Entidad de tipo SQL Parametros</param>
        /// <returns>Lista de entidades de tipo clientes</returns>
        public List<Clientes> ConsultarClientes(SQLParametros P_Peticion)
        {
            List<Clientes> lstClientes = new List<Clientes>();

            try
            {
                //Este objeto se encarga de las configuraciones necesarias para conectarse a BD
                //Ademas de contener un metodo para la ejecucion de esa petición contra la BD
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = objconexion; //Identifica la conexion a la BD
                cmd.CommandType = System.Data.CommandType.Text; //Se especifica el tipo de formato de sentencia a ejecutar
                cmd.CommandText = P_Peticion.Peticion; //Aqui se asigna la peticion construida

                //Objeto que es el que se encarga de ejecutar la consulta y recibir el resultado
                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);

                //Variable temporal para captura respuesta
                DataTable dt = new DataTable();
                objconsulta.Fill(dt); //Aqui se envia la peticion a ejecutar en BD y recibe la respuesta,
                                      //esta respuesta se carga en el DT

                if (dt.Rows.Count > 0) //Verifica si la consulta devolvio registros
                {
                    //Es un ciclo que toma uno a uno los elementos de la coleccion que se este recorriendo
                    foreach (DataRow fila in dt.Rows)
                    {
                        Clientes c = new Clientes();

                        //Aqui se obtiene los valores de celda o columna por fila leida
                        c.Cedula = Convert.ToInt32(fila.ItemArray[0].ToString());
                        c.Nombre = fila.ItemArray[1].ToString();
                        c.Apellidos = fila.ItemArray[2].ToString();
                        c.EstadoCivil = Convert.ToChar(fila.ItemArray[3].ToString());
                        c.EstadoCliente = Convert.ToBoolean(fila.ItemArray[4].ToString());
                        c.Telefono = Convert.ToInt32(fila.ItemArray[5].ToString());

                        lstClientes.Add(c);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CERRARCONEXION();
            }
            return lstClientes;
        }

        /// <summary>
        /// Método que se encarga de ejecutar las consultas a tabla Clientes
        /// </summary>
        /// <param name="P_Peticion">Entidad de tipo SQL Parametros</param>
        /// <returns>Lista de entidades de tipo clientes</returns>
        public List<Prestamos> ConsultarUltimoPrestamo(SQLParametros P_Peticion)
        {
            List<Prestamos> lstPrestamos = new List<Prestamos>();

            try
            {
                //Este objeto se encarga de las configuraciones necesarias para conectarse a BD
                //Ademas de contener un metodo para la ejecucion de esa petición contra la BD
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = objconexion; //Identifica la conexion a la BD
                cmd.CommandType = System.Data.CommandType.Text; //Se especifica el tipo de formato de sentencia a ejecutar
                cmd.CommandText = P_Peticion.Peticion; //Aqui se asigna la peticion construida

                //Objeto que es el que se encarga de ejecutar la consulta y recibir el resultado
                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);

                //Variable temporal para captura respuesta
                DataTable dt = new DataTable();
                objconsulta.Fill(dt); //Aqui se envia la peticion a ejecutar en BD y recibe la respuesta,
                                      //esta respuesta se carga en el DT

                if (dt.Rows.Count > 0) //Verifica si la consulta devolvio registros
                {
                    //Es un ciclo que toma uno a uno los elementos de la coleccion que se este recorriendo
                    foreach (DataRow fila in dt.Rows)
                    {
                        Prestamos prestamo = new Prestamos();

                        //Aqui se obtiene los valores de celda o columna por fila leida
                        prestamo.IdPrestamo = Convert.ToInt32(fila.ItemArray[0].ToString());

                        lstPrestamos.Add(prestamo);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CERRARCONEXION();
            }
            return lstPrestamos;
        }

        /// <summary>
        /// Método que se encarga de confirmar la direccion de email de un usuario
        /// </summary>
        /// <param name="P_Peticion">Entidad de tipo SQL Parametros</param>
        /// <returns>Lista de entidades de tipo usuarios</returns>
        public List<Usuarios> VerificarEmailUsuario(SQLParametros P_Peticion)
        {
            List<Usuarios> lstusuarios = new List<Usuarios>();

            try
            {
                //Este objeto se encarga de las configuraciones necesarias para conectarse a BD
                //Ademas de contener un metodo para la ejecucion de esa petición contra la BD
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = objconexion; //Identifica la conexion a la BD
                cmd.CommandType = System.Data.CommandType.Text; //Se especifica el tipo de formato de sentencia a ejecutar
                cmd.CommandText = P_Peticion.Peticion; //Aqui se asigna la peticion construida

                if (P_Peticion.LstParametros.Count > 0)  //Validar si tiene parametros, y agregarlos
                    cmd.Parameters.AddRange(P_Peticion.LstParametros.ToArray());

                //Objeto que es el que se encarga de ejecutar la consulta y recibir el resultado
                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);

                //Variable temporal para captura respuesta
                DataTable dt = new DataTable();
                objconsulta.Fill(dt); //Aqui se envia la peticion a ejecutar en BD y recibe la respuesta,
                                      //esta respuesta se carga en el DT

                if (dt.Rows.Count > 0) //Verifica si la consulta devolvio registros
                {
                    //Es un ciclo que toma uno a uno los elementos de la coleccion que se este recorriendo
                    foreach (DataRow fila in dt.Rows)
                    {
                        Usuarios u = new Usuarios();

                        //Aqui se obtiene los valores de celda o columna por fila leida
                        u.Email = fila.ItemArray[0].ToString();
                        u.Contrasena = fila.ItemArray[1].ToString();
                        lstusuarios.Add(u);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CERRARCONEXION();
            }
            return lstusuarios;
        }
        #endregion
    }
}
