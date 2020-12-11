using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Negocio
    {
        /// <summary>
        /// Método es para insertar un usuario con los valores recibidos desde presentación
        /// </summary>
        /// <param name="P_Usuario">Entidad usuario</param>
        /// <returns>1 = CORRECTO | 0 = ERROR</returns>
        public static int AgregarUsuario(Usuarios P_Usuario)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();

                //Ajustar peticion para utilización con parametros
                objpeticion.Peticion = @"EXEC PA_AgregarUsuario @idusuario, @nombre, @contrasena, @email, @estado";

                //Crear los parametros
                SqlParameter parametroIdUsuario = new SqlParameter();
                parametroIdUsuario.ParameterName = "@idusuario";
                parametroIdUsuario.Size = 15;
                parametroIdUsuario.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroIdUsuario.Value = P_Usuario.IdUsuario;

                SqlParameter parametroNomUsuario = new SqlParameter();
                parametroNomUsuario.ParameterName = "@nombre";
                parametroNomUsuario.Size = 50;
                parametroNomUsuario.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroNomUsuario.Value = P_Usuario.Nombre;

                SqlParameter parametroPass = new SqlParameter();
                parametroPass.ParameterName = "@contrasena";
                parametroPass.Size = 15;
                parametroPass.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroPass.Value = P_Usuario.Contrasena;

                SqlParameter parametroEmail = new SqlParameter();
                parametroEmail.ParameterName = "@email";
                parametroEmail.Size = 40;
                parametroEmail.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroEmail.Value = P_Usuario.Email;

                SqlParameter parametroEstado = new SqlParameter();
                parametroEstado.ParameterName = "@estado";
                parametroEstado.SqlDbType = System.Data.SqlDbType.Bit;
                parametroEstado.Value = P_Usuario.Estado;

                //Agrega a la lista de parametros los parametros creados
                objpeticion.LstParametros.Add(parametroIdUsuario);
                objpeticion.LstParametros.Add(parametroNomUsuario);
                objpeticion.LstParametros.Add(parametroPass);
                objpeticion.LstParametros.Add(parametroEmail);
                objpeticion.LstParametros.Add(parametroEstado);

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método es para modificar un usuario con los valores recibidos desde presentación
        /// </summary>
        /// <param name="P_Usuario">Entidad usuario</param>
        /// <returns>1 = CORRECTO | 0 = ERROR</returns>
        public static int ModificarUsuario(Usuarios P_Usuario)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();

                //Ajustar peticion para utilización con parametros
                objpeticion.Peticion = @"EXEC PA_ModificarUsuario @idusuario, @nombre, @contrasena, @email, @estado";

                //Crear los parametros
                SqlParameter parametroIdUsuario = new SqlParameter();
                parametroIdUsuario.ParameterName = "@idusuario";
                parametroIdUsuario.Size = 15;
                parametroIdUsuario.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroIdUsuario.Value = P_Usuario.IdUsuario;

                SqlParameter parametroNomUsuario = new SqlParameter();
                parametroNomUsuario.ParameterName = "@nombre";
                parametroNomUsuario.Size = 50;
                parametroNomUsuario.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroNomUsuario.Value = P_Usuario.Nombre;

                SqlParameter parametroPass = new SqlParameter();
                parametroPass.ParameterName = "@contrasena";
                parametroPass.Size = 15;
                parametroPass.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroPass.Value = P_Usuario.Contrasena;

                SqlParameter parametroEmail = new SqlParameter();
                parametroEmail.ParameterName = "@email";
                parametroEmail.Size = 40;
                parametroEmail.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroEmail.Value = P_Usuario.Email;

                SqlParameter parametroEstado = new SqlParameter();
                parametroEstado.ParameterName = "@estado";
                parametroEstado.SqlDbType = System.Data.SqlDbType.Bit;
                parametroEstado.Value = P_Usuario.Estado;

                //Agrega a la lista de parametros los parametros creados
                objpeticion.LstParametros.Add(parametroIdUsuario);
                objpeticion.LstParametros.Add(parametroNomUsuario);
                objpeticion.LstParametros.Add(parametroPass);
                objpeticion.LstParametros.Add(parametroEmail);
                objpeticion.LstParametros.Add(parametroEstado);

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método es para eliminar un usuario con los valores recibidos desde presentación
        /// </summary>
        /// <param name="P_Usuario">Entidad usuario</param>
        /// <returns>1 = CORRECTO | 0 = ERROR</returns>
        public static int EliminarUsuario(Usuarios P_Usuario)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();

                //Ajustar peticion para utilización con parametros
                objpeticion.Peticion = @"EXEC PA_EliminarUsuario @idusuario";

                //Crear los parametros
                SqlParameter parametroIdUsuario = new SqlParameter();
                parametroIdUsuario.ParameterName = "@idusuario";
                parametroIdUsuario.Size = 15;
                parametroIdUsuario.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroIdUsuario.Value = P_Usuario.IdUsuario;

                //Agrega a la lista de parametros los parametros creados
                objpeticion.LstParametros.Add(parametroIdUsuario);


                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método es para insertar un Contacto con los valores recibidos desde presentación
        /// </summary>
        /// <param name="P_Contacto">Entidad Contacto</param>
        /// <returns>1 = CORRECTO | 0 = ERROR</returns>
        public static int AgregarContacto(Contactos P_Contacto)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();

                //Ajustar peticion para utilización con parametros
                objpeticion.Peticion = @"EXEC PA_AgregarContacto @nombre, @telefono, @PalabraClave, @Correo, @TipoContacto, @Servicios, @estadocontacto";

                SqlParameter parametroNomUsuario = new SqlParameter();
                parametroNomUsuario.ParameterName = "@nombre";
                parametroNomUsuario.Size = 50;
                parametroNomUsuario.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroNomUsuario.Value = P_Contacto.Nombre;

                SqlParameter parametroTelefono = new SqlParameter();
                parametroTelefono.ParameterName = "@telefono";
                parametroTelefono.SqlDbType = System.Data.SqlDbType.Int;
                parametroTelefono.Value = P_Contacto.Telefono;

                SqlParameter parametroPalabraClave = new SqlParameter();
                parametroPalabraClave.ParameterName = "@PalabraClave";
                parametroPalabraClave.Size = 50;
                parametroPalabraClave.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroPalabraClave.Value = P_Contacto.PalabraClave;

                SqlParameter parametroCorreo = new SqlParameter();
                parametroCorreo.ParameterName = "@Correo";
                parametroCorreo.Size = 80;
                parametroCorreo.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroCorreo.Value = P_Contacto.Correo;

                SqlParameter parametroTipoContacto = new SqlParameter();
                parametroTipoContacto.ParameterName = "@TipoContacto";
                parametroTipoContacto.Size = 50;
                parametroTipoContacto.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroTipoContacto.Value = P_Contacto.TipoContacto;

                SqlParameter parametroServicios = new SqlParameter();
                parametroServicios.ParameterName = "@Servicios";
                parametroServicios.Size = 50;
                parametroServicios.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroServicios.Value = P_Contacto.Servicios;

                SqlParameter parametroEstado = new SqlParameter();
                parametroEstado.ParameterName = "@estadocliente";
                parametroEstado.SqlDbType = System.Data.SqlDbType.Bit;
                parametroEstado.Value = P_Contacto.EstadoContacto;


                //Agrega a la lista de parametros los parametros creado
                objpeticion.LstParametros.Add(parametroNomUsuario);
                objpeticion.LstParametros.Add(parametroTelefono);
                objpeticion.LstParametros.Add(parametroPalabraClave);
                objpeticion.LstParametros.Add(parametroCorreo);
                objpeticion.LstParametros.Add(parametroTipoContacto);
                objpeticion.LstParametros.Add(parametroServicios);
                objpeticion.LstParametros.Add(parametroEstado);

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método es para modificar un Contacto con los valores recibidos desde presentación
        /// </summary>
        /// <param name="P_Contacto">Entidad Contacto</param>
        /// <returns>1 = CORRECTO | 0 = ERROR</returns>
        public static int ModificarContacto(Contactos P_Contacto)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();

                //Ajustar peticion para utilización con parametros
                 objpeticion.Peticion = @"EXEC PA_ModificarContacto @nombre, @telefono, @PalabraClave, @Correo, @TipoContacto, @Servicios, @estadocontacto";

                //Crear los parametros
                SqlParameter parametroNomUsuario = new SqlParameter();
                parametroNomUsuario.ParameterName = "@nombre";
                parametroNomUsuario.Size = 50;
                parametroNomUsuario.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroNomUsuario.Value = P_Contacto.Nombre;                
                
                SqlParameter parametroTelefono = new SqlParameter();
                parametroTelefono.ParameterName = "@telefono";
                parametroTelefono.SqlDbType = System.Data.SqlDbType.Int;
                parametroTelefono.Value = P_Contacto.Telefono;
                
                SqlParameter parametroPalabraClave = new SqlParameter();
                parametroPalabraClave.ParameterName = "@PalabraClave";
                parametroPalabraClave.Size = 50;
                parametroPalabraClave.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroPalabraClave.Value = P_Contacto.PalabraClave;
                
                SqlParameter parametroCorreo = new SqlParameter();
                parametroCorreo.ParameterName = "@Correo";
                parametroCorreo.Size = 80;
                parametroCorreo.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroCorreo.Value = P_Contacto.Correo;  
                
                SqlParameter parametroTipoContacto = new SqlParameter();
                parametroTipoContacto.ParameterName = "@TipoContacto";
                parametroTipoContacto.Size = 50;
                parametroTipoContacto.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroTipoContacto.Value = P_Contacto.TipoContacto;
                
                SqlParameter parametroServicios = new SqlParameter();
                parametroServicios.ParameterName = "@Servicios";
                parametroServicios.Size = 50;
                parametroServicios.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroServicios.Value = P_Contacto.Servicios;
                
                SqlParameter parametroEstado = new SqlParameter();
                parametroEstado.ParameterName = "@estadocliente";
                parametroEstado.SqlDbType = System.Data.SqlDbType.Bit;
                parametroEstado.Value = P_Contacto.EstadoContacto;


                //Agrega a la lista de parametros los parametros creado
                objpeticion.LstParametros.Add(parametroNomUsuario);
                objpeticion.LstParametros.Add(parametroTelefono);
                objpeticion.LstParametros.Add(parametroPalabraClave);
                objpeticion.LstParametros.Add(parametroCorreo);
                objpeticion.LstParametros.Add(parametroTipoContacto);
                objpeticion.LstParametros.Add(parametroServicios);
                objpeticion.LstParametros.Add(parametroEstado);


                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método es para eliminar un Contacto con los valores recibidos desde presentación
        /// </summary>
        /// <param name="P_Contacto">Entidad Contacto</param>
        /// <returns>1 = CORRECTO | 0 = ERROR</returns>
        public static int EliminarContacto(Contactos P_Contacto)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();

                //Ajustar peticion para utilización con parametros
                objpeticion.Peticion = @"EXEC PA_EliminarContacto @PalabraClave";

                //Crear los parametros
                SqlParameter parametroPalabraClave = new SqlParameter();
                parametroPalabraClave.ParameterName = "@PalabraClave";
                parametroPalabraClave.Size = 50;
                parametroPalabraClave.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroPalabraClave.Value = P_Contacto.PalabraClave;

                //Agrega a la lista de parametros los parametros creados
                objpeticion.LstParametros.Add(parametroPalabraClave);


                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Método es para Consultar los usuarios registrados
        /// </summary>
        /// <param name="P_Usuario">Entidad usuario</param>
        /// <returns>1 = CORRECTO | 0 = ERROR</returns>
        public static List<Usuarios> ConsultarUsuarios()
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"EXEC PA_ListarUsuarios";

                Acceso objacceso = new Acceso();
                return objacceso.ConsultarUsuarios(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método es para Consultar los Contacto registrados
        /// </summary>
        /// <param name="P_Contacto">Entidad Contacto</param>
        /// <returns>1 = CORRECTO | 0 = ERROR</returns>
        public static List<Contactos> ConsultarContactos()
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"EXEC PA_ListarContactos";

                Acceso objacceso = new Acceso();
                return objacceso.ConsultarContactos(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Metodo que se encarga de verificar usuario dentro de la base de datos
        /// </summary>
        /// <param name="P_usuario">Entidad de tipo usuario</param>
        /// <returns>TRUE = Existe | False = No existe</returns>
        public static List<Usuarios> VerificarUsuario(Usuarios P_Usuario)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"EXEC PA_VerificarUsuario @idusuario, @contrasena";

                //Crear los parametros
                SqlParameter parametroIdUsuario = new SqlParameter();
                parametroIdUsuario.ParameterName = "@idusuario";
                parametroIdUsuario.Size = 15;
                parametroIdUsuario.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroIdUsuario.Value = P_Usuario.IdUsuario;

                SqlParameter parametroPass = new SqlParameter();
                parametroPass.ParameterName = "@contrasena";
                parametroPass.Size = 15;
                parametroPass.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroPass.Value = P_Usuario.Contrasena;

                //Agrega a la lista de parametros los parametros creados
                objpeticion.LstParametros.Add(parametroIdUsuario);
                objpeticion.LstParametros.Add(parametroPass);

                Acceso objacceso = new Acceso();
                List<Usuarios> lstresultados = objacceso.VerificarUsuario(objpeticion);

                return lstresultados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Metodo que se encarga de verificar el email de un usuario dentro de la base de datos
        /// </summary>
        /// <param name="P_usuario">Entidad de tipo usuario</param>
        /// <returns>TRUE = Existe | False = No existe</returns>
        public static List<Usuarios> VerificarEmailUsuario(Usuarios P_Usuario)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"EXEC PA_VerificarEmailUsuario @idusuario";

                //Crear los parametros
                SqlParameter parametroIdUsuario = new SqlParameter();
                parametroIdUsuario.ParameterName = "@idusuario";
                parametroIdUsuario.Size = 15;
                parametroIdUsuario.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroIdUsuario.Value = P_Usuario.IdUsuario;

                //Agrega a la lista de parametros los parametros creados
                objpeticion.LstParametros.Add(parametroIdUsuario);

                Acceso objacceso = new Acceso();
                List<Usuarios> lstresultados = objacceso.VerificarEmailUsuario(objpeticion);

                return lstresultados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Metodo para enviar correo electronico
        /// </summary>
        /// <param name="P_Correo">Entidad tipo correo</param>
        public static void EnviarCorreoElectronico(Correo P_Correo)
        {
            MailMessage Correo = new MailMessage();
            SmtpClient Envio = new SmtpClient();
            try
            {
                Correo.From = new MailAddress(P_Correo.Remitente);
                Correo.Subject = P_Correo.Asunto;
                Correo.Body = P_Correo.MensajeCorreo;
                Correo.IsBodyHtml = true;
                Correo.Priority = MailPriority.Normal;

                foreach (string Destinatario in P_Correo.Destinatario)
                {
                    Correo.To.Add(new MailAddress(Destinatario));
                }
                Envio.Host = "smtp.gmail.com";
                Envio.Port = 587;
                Envio.EnableSsl = true;
                Envio.UseDefaultCredentials = false;
                Envio.Credentials = new NetworkCredential("adrian.progra3@gmail.com", "tazz2644");

                Envio.Send(Correo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
