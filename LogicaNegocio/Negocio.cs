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
        /// Método es para insertar un usuario con los valores recibidos desde presentación
        /// </summary>
        /// <param name="P_Cliente">Entidad cliente</param>
        /// <returns>1 = CORRECTO | 0 = ERROR</returns>
        public static int AgregarCliente(Clientes P_Cliente)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();

                //Ajustar peticion para utilización con parametros
                objpeticion.Peticion = @"EXEC PA_AgregarCliente @cedula, @nombre, @apellidos, @estadocivil, @estadocliente, @telefono";

                //Crear los parametros
                SqlParameter parametroCedula = new SqlParameter();
                parametroCedula.ParameterName = "@cedula";
                parametroCedula.SqlDbType = System.Data.SqlDbType.Int;
                parametroCedula.Value = P_Cliente.Cedula;

                SqlParameter parametroNomUsuario = new SqlParameter();
                parametroNomUsuario.ParameterName = "@nombre";
                parametroNomUsuario.Size = 15;
                parametroNomUsuario.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroNomUsuario.Value = P_Cliente.Nombre;

                SqlParameter parametroApellidos = new SqlParameter();
                parametroApellidos.ParameterName = "@apellidos";
                parametroApellidos.Size = 30;
                parametroApellidos.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroApellidos.Value = P_Cliente.Apellidos;

                SqlParameter parametroEstadoCivil = new SqlParameter();
                parametroEstadoCivil.ParameterName = "@estadocivil";
                parametroEstadoCivil.Size = 1;
                parametroEstadoCivil.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroEstadoCivil.Value = P_Cliente.EstadoCivil;

                SqlParameter parametroEstado = new SqlParameter();
                parametroEstado.ParameterName = "@estadocliente";
                parametroEstado.SqlDbType = System.Data.SqlDbType.Bit;
                parametroEstado.Value = P_Cliente.EstadoCliente;

                SqlParameter parametroTelefono = new SqlParameter();
                parametroTelefono.ParameterName = "@telefono";
                parametroTelefono.SqlDbType = System.Data.SqlDbType.Int;
                parametroTelefono.Value = P_Cliente.Telefono;

                //Agrega a la lista de parametros los parametros creados
                objpeticion.LstParametros.Add(parametroCedula);
                objpeticion.LstParametros.Add(parametroNomUsuario);
                objpeticion.LstParametros.Add(parametroApellidos);
                objpeticion.LstParametros.Add(parametroEstadoCivil);
                objpeticion.LstParametros.Add(parametroEstado);
                objpeticion.LstParametros.Add(parametroTelefono);

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método es para modificar un cliente con los valores recibidos desde presentación
        /// </summary>
        /// <param name="P_Cliente">Entidad cliente</param>
        /// <returns>1 = CORRECTO | 0 = ERROR</returns>
        public static int ModificarCliente(Clientes P_Cliente)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();

                //Ajustar peticion para utilización con parametros
                objpeticion.Peticion = @"EXEC PA_ModificarCliente @cedula, @nombre, @apellidos, @estadocivil, @estadocliente, @telefono";

                //Crear los parametros
                SqlParameter parametroCedula = new SqlParameter();
                parametroCedula.ParameterName = "@cedula";
                parametroCedula.SqlDbType = System.Data.SqlDbType.Int;
                parametroCedula.Value = P_Cliente.Cedula;

                SqlParameter parametroNomUsuario = new SqlParameter();
                parametroNomUsuario.ParameterName = "@nombre";
                parametroNomUsuario.Size = 15;
                parametroNomUsuario.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroNomUsuario.Value = P_Cliente.Nombre;

                SqlParameter parametroApellidos = new SqlParameter();
                parametroApellidos.ParameterName = "@apellidos";
                parametroApellidos.Size = 30;
                parametroApellidos.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroApellidos.Value = P_Cliente.Apellidos;

                SqlParameter parametroEstadoCivil = new SqlParameter();
                parametroEstadoCivil.ParameterName = "@estadocivil";
                parametroEstadoCivil.Size = 1;
                parametroEstadoCivil.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroEstadoCivil.Value = P_Cliente.EstadoCivil;

                SqlParameter parametroEstado = new SqlParameter();
                parametroEstado.ParameterName = "@estadocliente";
                parametroEstado.SqlDbType = System.Data.SqlDbType.Bit;
                parametroEstado.Value = P_Cliente.EstadoCliente;

                SqlParameter parametroTelefono = new SqlParameter();
                parametroTelefono.ParameterName = "@telefono";
                parametroTelefono.SqlDbType = System.Data.SqlDbType.Int;
                parametroTelefono.Value = P_Cliente.Telefono;

                //Agrega a la lista de parametros los parametros creados
                objpeticion.LstParametros.Add(parametroCedula);
                objpeticion.LstParametros.Add(parametroNomUsuario);
                objpeticion.LstParametros.Add(parametroApellidos);
                objpeticion.LstParametros.Add(parametroEstadoCivil);
                objpeticion.LstParametros.Add(parametroEstado);
                objpeticion.LstParametros.Add(parametroTelefono);

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método es para eliminar un cliente con los valores recibidos desde presentación
        /// </summary>
        /// <param name="P_Cliente">Entidad cliente</param>
        /// <returns>1 = CORRECTO | 0 = ERROR</returns>
        public static int EliminarCliente(Clientes P_Cliente)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();

                //Ajustar peticion para utilización con parametros
                objpeticion.Peticion = @"EXEC PA_EliminarCliente @cedula";

                //Crear los parametros
                SqlParameter parametroCedula = new SqlParameter();
                parametroCedula.ParameterName = "@cedula";
                parametroCedula.SqlDbType = System.Data.SqlDbType.Int;
                parametroCedula.Value = P_Cliente.Cedula;

                //Agrega a la lista de parametros los parametros creados
                objpeticion.LstParametros.Add(parametroCedula);


                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método es para insertar un prestamo y vincularlo con un cliente con los valores recibidos desde presentación
        /// </summary>
        /// <param name="P_Prestamo">Entidad prestamo</param>
        /// <returns>1 = CORRECTO | 0 = ERROR</returns>
        public static void AgregarPrestamo(Prestamos P_Prestamo)
        {
            try
            {
                //Se crea una lista de comandos para guardar las peticiones 
                List<SqlCommand> lstpeticiones = new List<SqlCommand>();

                SQLParametros objpeticion = new SQLParametros();

                //Ajustar peticion para utilización con parametros
                objpeticion.Peticion = @"EXEC PA_AgregarPrestamo @monto, @tasainteres, @plazo, @frecuenciadepago, @fechapago";

                //Crear los parametros
                SqlParameter parametroMonto = new SqlParameter();
                parametroMonto.ParameterName = "@monto";
                parametroMonto.SqlDbType = System.Data.SqlDbType.Decimal;
                parametroMonto.Value = P_Prestamo.Monto;

                SqlParameter parametroTasa = new SqlParameter();
                parametroTasa.ParameterName = "@tasainteres";
                parametroTasa.SqlDbType = System.Data.SqlDbType.Decimal;
                parametroTasa.Value = P_Prestamo.TasaInteres;

                SqlParameter parametroPlazo = new SqlParameter();
                parametroPlazo.ParameterName = "@plazo";
                parametroPlazo.Size = 20;
                parametroPlazo.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroPlazo.Value = P_Prestamo.Plazo;

                SqlParameter parametroFrecuencia = new SqlParameter();
                parametroFrecuencia.ParameterName = "@frecuenciadepago";
                parametroFrecuencia.Size = 20;
                parametroFrecuencia.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroFrecuencia.Value = P_Prestamo.FrecuenciaPago;

                SqlParameter parametroFechaPago = new SqlParameter();
                parametroFechaPago.ParameterName = "@fechapago";
                parametroFechaPago.Size = 20;
                parametroFechaPago.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroFechaPago.Value = P_Prestamo.FechaPago;

                //Agrega a la lista de parametros los parametros creados
                objpeticion.LstParametros.Add(parametroMonto);
                objpeticion.LstParametros.Add(parametroTasa);
                objpeticion.LstParametros.Add(parametroPlazo);
                objpeticion.LstParametros.Add(parametroFrecuencia);
                objpeticion.LstParametros.Add(parametroFechaPago);

                Acceso objacceso = new Acceso();
                //objacceso.AgregarPeticionEnListado(objpeticion, ref lstpeticiones);
                objacceso.Ejecutar_Peticiones(objpeticion);

                //Segunda petición 

                //Int donde se guarda el id del ultimo prestamo agregado
                int IdUltimoPrestamo = ConsultarUltimoPrestamo();

                objpeticion = new SQLParametros();

                //Ajustar peticion para utilización con parametros
                objpeticion.Peticion = @"EXEC PA_VincularPrestamoConCliente @idprestamo, @cedula, @fecha";

                //Crear los parametros
                SqlParameter parametroIdPrestamo = new SqlParameter();
                parametroIdPrestamo.ParameterName = "@idprestamo";
                parametroIdPrestamo.SqlDbType = System.Data.SqlDbType.Int;
                parametroIdPrestamo.Value = IdUltimoPrestamo;

                SqlParameter parametroCedula = new SqlParameter();
                parametroCedula.ParameterName = "@cedula";
                parametroCedula.SqlDbType = System.Data.SqlDbType.Int;
                parametroCedula.Value = P_Prestamo.Cedula;

                SqlParameter parametroFecha = new SqlParameter();
                parametroFecha.ParameterName = "@fecha";
                parametroFecha.SqlDbType = System.Data.SqlDbType.DateTime;
                parametroFecha.Value = P_Prestamo.FechaSolicitud;

                //Agrega a la lista de parametros los parametros creados
                objpeticion.LstParametros.Add(parametroIdPrestamo);
                objpeticion.LstParametros.Add(parametroCedula);
                objpeticion.LstParametros.Add(parametroFecha);

                objacceso = new Acceso();
                //objacceso.AgregarPeticionEnListado(objpeticion, ref lstpeticiones);
                objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método es para actualizar estado de unm prestamo
        /// </summary>
        /// <param name="P_Prestamo">Entidad prestamo</param>
        /// <returns>1 = CORRECTO | 0 = ERROR</returns>
        public static void ActualizarPrestamo(Prestamos P_Prestamo)
        {
            try
            {
                //Se crea una lista de comandos para guardar las peticiones 
                List<SqlCommand> lstpeticiones = new List<SqlCommand>();

                SQLParametros objpeticion = new SQLParametros();

                //Ajustar peticion para utilización con parametros
                objpeticion.Peticion = @"EXEC PA_ActualizarPrestamo @idprestamo, @estado";

                //Crear los parametros
                SqlParameter parametroIdPrestamo = new SqlParameter();
                parametroIdPrestamo.ParameterName = "@idprestamo";
                parametroIdPrestamo.SqlDbType = System.Data.SqlDbType.Int;
                parametroIdPrestamo.Value = P_Prestamo.IdPrestamo;

                SqlParameter parametroEstado = new SqlParameter();
                parametroEstado.ParameterName = "@estado";
                parametroEstado.Size = 20;
                parametroEstado.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroEstado.Value = P_Prestamo.Estado;

                //Agrega a la lista de parametros los parametros creados
                objpeticion.LstParametros.Add(parametroIdPrestamo);
                objpeticion.LstParametros.Add(parametroEstado);

                Acceso objacceso = new Acceso();
                //objacceso.AgregarPeticionEnListado(objpeticion, ref lstpeticiones);
                objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método para confirmar el id del ultimo paquete agregado
        /// </summary>
        /// <param name="P_Prestamo">Entidad prestamo</param>
        /// <returns>1 = CORRECTO | 0 = ERROR</returns>
        public static int ConsultarUltimoPrestamo()
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();

                //Peticion a ejecutar
                objpeticion.Peticion = @"EXEC PA_ConsultarUltimoPrestamoAgregado";

                Acceso objacceso = new Acceso();
                List<Prestamos> prestamo = objacceso.ConsultarUltimoPrestamo(objpeticion);

                Prestamos UltimoPrestamo = new Prestamos();
                foreach (Prestamos p in prestamo)
                {
                    UltimoPrestamo.IdPrestamo = p.IdPrestamo;
                }

                return UltimoPrestamo.IdPrestamo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método es para Consultar los prestamos por cliente
        /// </summary>
        /// <param name="P_Prestamo">Entidad prestamo</param>
        /// <returns>1 = CORRECTO | 0 = ERROR</returns>
        public static List<Prestamos> ConsultarPrestamosPorCliente(Prestamos P_Prestamo)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"EXEC PA_ListarPrestamosxIdCLiente @cedula";

                //Crear los parametros
                SqlParameter parametroCedula = new SqlParameter();
                parametroCedula.ParameterName = "@cedula";
                parametroCedula.SqlDbType = System.Data.SqlDbType.Int;
                parametroCedula.Value = P_Prestamo.Cedula;


                //Agrega a la lista de parametros los parametros creados
                objpeticion.LstParametros.Add(parametroCedula);

                Acceso objacceso = new Acceso();
                return objacceso.ConsultarPrestamosPorCliente(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método es para Consultar los prestamos por estado
        /// </summary>
        /// <param name="P_Prestamo">Entidad prestamo</param>
        /// <returns>1 = CORRECTO | 0 = ERROR</returns>
        public static List<Prestamos> ConsultarPrestamosPorEstado(Prestamos P_Prestamo)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"EXEC PA_ListarPrestamosxEstado @estado";

                //Crear los parametros
                SqlParameter parametroEstado = new SqlParameter();
                parametroEstado.ParameterName = "@estado";
                parametroEstado.Size = 20;
                parametroEstado.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroEstado.Value = P_Prestamo.Estado;


                //Agrega a la lista de parametros los parametros creados
                objpeticion.LstParametros.Add(parametroEstado);

                Acceso objacceso = new Acceso();
                return objacceso.ConsultarPrestamosPorEstado(objpeticion);
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
        /// Método es para Consultar los clientes registrados
        /// </summary>
        /// <param name="P_Cliente">Entidad cliente</param>
        /// <returns>1 = CORRECTO | 0 = ERROR</returns>
        public static List<Clientes> ConsultarClientes()
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"EXEC PA_ListarClientes";

                Acceso objacceso = new Acceso();
                return objacceso.ConsultarClientes(objpeticion);
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
