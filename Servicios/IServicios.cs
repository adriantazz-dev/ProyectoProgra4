using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicios" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicios
    {
        [OperationContract]
        int AgregarUsuario(Usuarios P_Usuario);

        [OperationContract]
        int ModificarUsuario(Usuarios P_Usuario);

        [OperationContract]
        int EliminarUsuario(Usuarios P_Usuario);

        [OperationContract]
        int AgregarContacto(Contactos P_Contacto);

        [OperationContract]
        int ModificarContacto(Contactos P_Contacto);

        [OperationContract]
        int EliminarContacto(Contactos P_Contacto);

        [OperationContract]
        List<Usuarios> VerificarUsuario(Usuarios P_Usuario);

        [OperationContract]
        List<Usuarios> ConsultarUsuarios();

        [OperationContract]
        List<Contactos> ConsultarContactos();

        [OperationContract]
        void EnviarCorreoElectronico(Correo P_Correo);

        [OperationContract]
        List<Usuarios> VerificarEmailUsuario(Usuarios P_Usuario);

    }
}
