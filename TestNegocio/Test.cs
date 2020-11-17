using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using LogicaNegocio;

namespace TestNegocio
{
    public class Test
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Menu Pruebas Negocio");
                    Console.WriteLine("1.Agregar usuario");
                    Console.WriteLine("2.Modificar usuario");
                    Console.WriteLine("3.Eliminar usuario");
                    Console.WriteLine("4.Agregar cliente");
                    Console.WriteLine("5.Modificar cliente");
                    Console.WriteLine("6.Eliminar cliente");
                    Console.WriteLine("7.Agregar prestamo");
                    Console.WriteLine("8.Consultar Usuarios");
                    Console.WriteLine("9.Consultar Clientes");
                    Console.WriteLine("10.Consultar prestamos por id de cliente");
                    Console.WriteLine("11.Consultar prestamos por estado");
                    Console.WriteLine("12.Consultar id ultimo prestamo");
                    Console.WriteLine("0.Salir");
                    Console.Write("Opcion:");
                    x = Convert.ToInt32(Console.ReadLine());

                    switch (x)
                    {
                        case 1:
                            {
                                Usuarios objusuario = new Usuarios();

                                Console.Clear();
                                Console.WriteLine("Agregar usuario");
                                Console.WriteLine("");

                                //Se carga objeto con datos
                                Console.WriteLine("Digite el id de usuario: ");
                                objusuario.IdUsuario = Console.ReadLine();

                                Console.WriteLine("Digite el nombre de usuario: ");
                                objusuario.Nombre = Console.ReadLine();

                                Console.WriteLine("Digite la contraseña: ");
                                objusuario.Contrasena = Console.ReadLine();

                                Console.WriteLine("Digite la email: ");
                                objusuario.Email = Console.ReadLine();

                                Console.WriteLine("Digite el estado: ");
                                objusuario.Estado = Convert.ToBoolean(Console.ReadLine());

                                if (Negocio.AgregarUsuario(objusuario) == 1)
                                {
                                    Console.WriteLine("Usuario agregado: ");
                                }
                                

                                Console.ReadKey();
                            }
                            break;
                        //case 2:
                        //    {
                        //        Paquetes paquete = new Paquetes();

                        //        Console.Clear();
                        //        Console.WriteLine("Busqueda de paquete");
                        //        Console.WriteLine("");

                        //        Se carga objeto con datos
                        //        Console.WriteLine("Digite el id: ");
                        //        paquete.ID_Paquete = Convert.ToInt32(Console.ReadLine());

                        //        Aqui se llama al método de LOGICA y se valida la respuesta
                        //        paquete = Negocio.BuscarPaquetexId(paquete);
                        //        Console.WriteLine(paquete.Origen + paquete.Destino + paquete.EstadoActual + paquete.MetodoPago);

                        //        Console.ReadKey();
                        //    }
                        //    break;
                        //case 3:
                        //    {
                        //        Usuarios objusuario = new Usuarios();

                        //        Console.Clear();
                        //        Console.WriteLine("Eliminacion de usuario");
                        //        Console.WriteLine("");

                        //        //Se carga objeto con datos
                        //        Console.WriteLine("Digite el ID de usuario: ");
                        //        objusuario.ID_Usuario = Convert.ToInt32(Console.ReadLine());


                        //        //Aqui se llama al método de LOGICA y se valida la respuesta
                        //        if (Negocio.EliminarUsuario(objusuario) > 0)
                        //            Console.WriteLine("Perfil fue eliminado");

                        //        Console.ReadKey();
                        //    }
                        //    break;
                        case 4:
                            {
                                Console.Clear();
                                Console.WriteLine("Listado de usuarios");
                                Console.WriteLine("");
                                List<Usuarios> lstusuarios = Negocio.ConsultarUsuarios();
                                if (lstusuarios.Count > 0)
                                {
                                    foreach (Usuarios item in lstusuarios)
                                    {
                                        Console.WriteLine("ID Usuario: " + item.IdUsuario);
                                        Console.WriteLine("Nombre: " + item.Nombre);
                                        Console.WriteLine("Contraseña: " + item.Contrasena);
                                        Console.WriteLine("Email: " + item.Email);
                                        Console.WriteLine("Estado: " + item.Estado);
                                        Console.WriteLine("***********************************************************");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No Hay registros que mostrar");
                                }
                                Console.ReadKey();
                            }
                            break;
                        //case 5:
                        //    {
                        //        Paquetes objpaquete = new Paquetes();

                        //        Console.Clear();
                        //        Console.WriteLine("Filtrar paquetes por fecha");
                        //        Console.WriteLine("");

                        //        //Se carga objeto con datos
                        //        Console.WriteLine("Fecha desde: ");
                        //        string dateinput = Console.ReadLine();
                        //        var parsedDate = DateTime.Parse(dateinput);
                        //        objpaquete.Fecha1 = parsedDate;

                        //        Console.WriteLine("Fecha hasta: ");
                        //        dateinput = Console.ReadLine();
                        //        parsedDate = DateTime.Parse(dateinput);
                        //        objpaquete.Fecha2 = parsedDate;




                        //        //Aqui se llama al método de LOGICA y se valida la respuesta
                        //        Console.WriteLine("Listado de paquetes entre las fechas ingresadas");
                        //        Console.WriteLine("");

                        //        List<Paquetes> lstpaquetes = Negocio.ConsultarPaquetesPorFecha(objpaquete);
                        //        if (lstpaquetes.Count > 0)
                        //        {
                        //            foreach (Paquetes item in lstpaquetes)
                        //            {
                        //                Console.WriteLine("Id: " + item.ID_Paquete);
                        //                Console.WriteLine("Estado: " + item.EstadoActual);
                        //                Console.WriteLine("Origen: " + item.Origen);
                        //                Console.WriteLine("Destino: " + item.Destino);
                        //                Console.WriteLine("Fecha de entrega: " + item.Estados.Fecha);
                        //                Console.WriteLine("Total flete: " + item.TotalFlete);
                        //                Console.WriteLine("***********************************************************");
                        //            }
                        //        }
                        //        else
                        //        {
                        //            Console.WriteLine("No Hay registros que mostrar");
                        //        }

                        //        Console.ReadKey();
                        //    }
                        //    break;
                        //case 6:
                        //    {
                        //        Paquetes objpaquete = new Paquetes();

                        //        Console.Clear();
                        //        Console.WriteLine("Historial de paquete");
                        //        Console.WriteLine("");

                        //        //Se carga objeto con datos
                        //        Console.WriteLine("Ingrese el numero de id del paquete: ");
                        //        objpaquete.ID_Paquete = Convert.ToInt32(Console.ReadLine());

                        //        //Aqui se llama al método de LOGICA y se valida la respuesta
                        //        Console.WriteLine("Historial del paquete:");
                        //        Console.WriteLine("");

                        //        List<Paquetes> lstpaquetes = Negocio.ConsultarHistorialdePaquetes(objpaquete);
                        //        if (lstpaquetes.Count > 0)
                        //        {
                        //            foreach (Paquetes item in lstpaquetes)
                        //            {
                        //                Console.WriteLine("Estado: " + item.Estados.Estado);
                        //                Console.WriteLine("Fecha: " + item.Estados.Fecha);
                        //                Console.WriteLine("***********************************************************");
                        //            }
                        //        }
                        //        else
                        //        {
                        //            Console.WriteLine("No Hay registros que mostrar");
                        //        }

                        //        Console.ReadKey();
                        //    }
                        //    break;
                        case 7:
                            {
                                Prestamos objprestamo = new Prestamos();

                                Console.Clear();
                                Console.WriteLine("Agregar paquete");
                                Console.WriteLine("");

                                //Se carga objeto con datos
                                Console.WriteLine("Ingrese la cedula del cliente: ");
                                objprestamo.Cedula = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Ingrese el monto del prestamo: ");
                                objprestamo.Monto = Convert.ToDecimal(Console.ReadLine());

                                Console.WriteLine("Ingrese la tasa: ");
                                objprestamo.TasaInteres = Convert.ToDecimal(Console.ReadLine());

                                Console.WriteLine("Ingrese el plazo: ");
                                objprestamo.Plazo = Console.ReadLine();

                                Console.WriteLine("Ingrese la frecuencia de pago: ");
                                objprestamo.FrecuenciaPago = Console.ReadLine();

                                Console.WriteLine("Ingrese la fecha de pago: ");
                                objprestamo.FechaPago = Console.ReadLine();

                                Negocio.AgregarPrestamo(objprestamo);

                                Console.ReadKey();
                            }
                            break;
                        //case 8:
                        //    {
                        //        {
                        //            Usuarios objusuario = new Usuarios();

                        //            Console.Clear();
                        //            Console.WriteLine("Confirmar existencia usuario");
                        //            Console.WriteLine("");

                        //            //Se carga objeto con datos
                        //            Console.WriteLine("Ingrese el numero de id del usuario: ");
                        //            objusuario.ID_Usuario = Convert.ToInt32(Console.ReadLine());

                        //            Console.WriteLine("Ingrese la contraseña: ");
                        //            objusuario.Contrasena = Console.ReadLine();

                        //            objusuario.Estado = true;

                        //            if (Negocio.VerificarUsuario(objusuario).Count > 0)
                        //            {
                        //                Console.WriteLine("Usuario existe");
                        //            }
                        //            else
                        //            {
                        //                Console.WriteLine("No Hay registros que mostrar");
                        //            }
                        //            Console.ReadKey();
                        //        }
                        //    }
                        //    break;
                        //case 9:
                        //    {
                        //        Paquetes objpaquete = new Paquetes();

                        //        Console.Clear();
                        //        Console.WriteLine("Insercion de paquete");

                        //        Console.WriteLine("");

                        //        //Se carga objeto con datos
                        //        Console.WriteLine("Digite el estado actual: ");
                        //        objpaquete.EstadoActual = Console.ReadLine();
                        //        Console.WriteLine("Digite el destino: ");
                        //        objpaquete.Destino = Console.ReadLine();
                        //        Console.WriteLine("Digite el origen: ");
                        //        objpaquete.Origen = Console.ReadLine();
                        //        Console.WriteLine("Digite el metodo de pago: ");
                        //        objpaquete.MetodoPago = Console.ReadLine();



                        //        //Aqui se llama al método de LOGICA y se valida la respuesta
                        //        if (Negocio.AgregarPaquete(objpaquete) > 0)
                        //            Console.WriteLine("Paquete fue agregado");

                        //        Console.ReadKey();
                        //    }
                        //    break;
                        //case 10:
                        //    {
                        //        Paquetes objpaquete = new Paquetes();

                        //        Console.Clear();
                        //        Console.WriteLine("Modificacion de paquete");

                        //        Console.WriteLine("");

                        //        //Se carga objeto con datos
                        //        Console.WriteLine("Digite el Id de paquete: ");
                        //        objpaquete.ID_Paquete = Convert.ToInt32(Console.ReadLine());
                        //        Console.WriteLine("Digite el estado actual: ");
                        //        objpaquete.EstadoActual = Console.ReadLine();
                        //        Console.WriteLine("Digite el destino: ");
                        //        objpaquete.Destino = Console.ReadLine();
                        //        Console.WriteLine("Digite el origen: ");
                        //        objpaquete.Origen = Console.ReadLine();
                        //        Console.WriteLine("Digite el metodo de pago: ");
                        //        objpaquete.MetodoPago = Console.ReadLine();



                        //        //Aqui se llama al método de LOGICA y se valida la respuesta
                        //        if (Negocio.AgregarPaquete(objpaquete) > 0)
                        //            Console.WriteLine("Paquete fue agregado");

                        //        Console.ReadKey();
                        //    }
                        //    break;
                        //case 11:
                        //    {
                        //        Usuarios objusuario = new Usuarios();

                        //        Console.Clear();
                        //        Console.WriteLine("Vincular usuario con paquete");
                        //        Console.WriteLine("");

                        //        //Se carga objeto con datos
                        //        Console.WriteLine("Digite el id de usuario: ");
                        //        objusuario.ID_Usuario = Convert.ToInt32(Console.ReadLine());
                        //        Console.WriteLine("Digite el id de paquete: ");
                        //        objusuario.Paquetes.ID_Paquete = Convert.ToInt32(Console.ReadLine());


                        //        //Aqui se llama al método de LOGICA y se valida la respuesta
                        //        if (Negocio.VincularUsuarioPaquete(objusuario) > 0)
                        //            Console.WriteLine("Paquete vinculado a usuario");

                        //        Console.ReadKey();
                        //    }
                        //    break;
                        //case 12:
                        //    {
                        //        Paquetes objpaquete = new Paquetes();

                        //        Console.Clear();
                        //        Console.WriteLine("Vincular paquete con estado");
                        //        Console.WriteLine("");

                        //        //Se carga objeto con datos
                        //        Console.WriteLine("Digite el id de paquete: ");
                        //        objpaquete.ID_Paquete = Convert.ToInt32(Console.ReadLine());
                        //        Console.WriteLine("Digite el id de estado: ");
                        //        objpaquete.Estados.ID_Estado = Convert.ToInt32(Console.ReadLine());
                        //        objpaquete.Estados.Fecha = DateTime.Now;

                        //        //Aqui se llama al método de LOGICA y se valida la respuesta
                        //        if (Negocio.VincularPaqueteEstado(objpaquete) > 0)
                        //            Console.WriteLine("Paquete vinculado con estado");

                        //        Console.ReadKey();
                        //    }
                        //    break;

                        case 0:

                            break;
                    }

                } while (x != 0);
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
