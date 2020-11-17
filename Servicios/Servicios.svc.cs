using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LogicaNegocio;

namespace Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Servicios" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Servicios.svc o Servicios.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Servicios : IServicios
    {
        public void ActualizarPrestamo(Prestamos P_Prestamo)
        {
            Negocio.ActualizarPrestamo(P_Prestamo);
        }

        public int AgregarCliente(Clientes P_Cliente)
        {
            return Negocio.AgregarCliente(P_Cliente);
        }

        public void AgregarPrestamo(Prestamos P_Prestamo)
        {
            Negocio.AgregarPrestamo(P_Prestamo);
        }

        public int AgregarUsuario(Usuarios P_Usuario)
        {
            return Negocio.AgregarUsuario(P_Usuario);
        }

        public List<Clientes> ConsultarClientes()
        {
            return Negocio.ConsultarClientes();
        }

        public List<Prestamos> ConsultarPrestamosPorCliente(Prestamos P_Prestamo)
        {
            return Negocio.ConsultarPrestamosPorCliente(P_Prestamo);
        }

        public List<Prestamos> ConsultarPrestamosPorEstado(Prestamos P_Prestamo)
        {
            return Negocio.ConsultarPrestamosPorEstado(P_Prestamo);
        }

        public List<Usuarios> ConsultarUsuarios()
        {
            return Negocio.ConsultarUsuarios();
        }

        public void DoWork()
        {
        }

        public int EliminarCliente(Clientes P_Cliente)
        {
            return Negocio.EliminarCliente(P_Cliente);
        }

        public int EliminarUsuario(Usuarios P_Usuario)
        {
            return Negocio.EliminarUsuario(P_Usuario);
        }

        public void EnviarCorreoElectronico(Correo P_Correo)
        {
            Negocio.EnviarCorreoElectronico(P_Correo);
        }

        public int ModificarCliente(Clientes P_Cliente)
        {
            return Negocio.ModificarCliente(P_Cliente);
        }

        public int ModificarUsuario(Usuarios P_Usuario)
        {
            return Negocio.ModificarUsuario(P_Usuario);
        }

        public List<Usuarios> VerificarEmailUsuario(Usuarios P_Usuario)
        {
            return Negocio.VerificarEmailUsuario(P_Usuario);
        }

        public List<Usuarios> VerificarUsuario(Usuarios P_Usuario)
        {
            return Negocio.VerificarUsuario(P_Usuario);
        }
    }
}
