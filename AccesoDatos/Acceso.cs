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
        public List<Contactos> ConsultarContactos(SQLParametros P_Peticion)
        {
            List<Contactos> lstContactos = new List<Contactos>();

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
                        Contactos c = new Contactos();

                        //Aqui se obtiene los valores de celda o columna por fila leida
                        
                        c.Nombre = fila.ItemArray[0].ToString();
                        c.Telefono = Convert.ToInt32(fila.ItemArray[1].ToString());
                        c.PalabraClave = fila.ItemArray[2].ToString();
                        c.Correo = fila.ItemArray[3].ToString();
                        c.TipoContacto = fila.ItemArray[4].ToString();
                        c.Servicios = fila.ItemArray[5].ToString();
                        c.EstadoContacto = Convert.ToBoolean(fila.ItemArray[6].ToString());
                        

                        lstContactos.Add(c);
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
            return lstContactos;
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
