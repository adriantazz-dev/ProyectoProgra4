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

        public int AgregarContacto(Contactos P_Contacto)
        {
            return Negocio.AgregarContacto(P_Contacto);
        }

        public int AgregarUsuario(Usuarios P_Usuario)
        {
            return Negocio.AgregarUsuario(P_Usuario);
        }

        public List<Contactos> ConsultarContactos()
        {
            return Negocio.ConsultarContactos();
        }

        public List<Usuarios> ConsultarUsuarios()
        {
            return Negocio.ConsultarUsuarios();
        }

        public void DoWork()
        {
        }

        public int EliminarContacto(Contactos P_Contacto)
        {
            return Negocio.EliminarContacto(P_Contacto);
        }

        public int EliminarUsuario(Usuarios P_Usuario)
        {
            return Negocio.EliminarUsuario(P_Usuario);
        }

        public void EnviarCorreoElectronico(Correo P_Correo)
        {
            Negocio.EnviarCorreoElectronico(P_Correo);
        }

        public int ModificarContacto(Contactos P_Contacto)
        {
            return Negocio.ModificarContacto(P_Contacto);
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
