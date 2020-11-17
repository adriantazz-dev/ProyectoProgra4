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
        int AgregarCliente(Clientes P_Cliente);

        [OperationContract]
        int ModificarCliente(Clientes P_Cliente);

        [OperationContract]
        int EliminarCliente(Clientes P_Cliente);

        [OperationContract]
        void AgregarPrestamo(Prestamos P_Prestamo);

        [OperationContract]
        List<Usuarios> VerificarUsuario(Usuarios P_Usuario);

        [OperationContract]
        List<Prestamos> ConsultarPrestamosPorCliente(Prestamos P_Prestamo);

        [OperationContract]
        List<Prestamos> ConsultarPrestamosPorEstado(Prestamos P_Prestamo);

        [OperationContract]
        List<Usuarios> ConsultarUsuarios();

        [OperationContract]
        List<Clientes> ConsultarClientes();

        [OperationContract]
        void EnviarCorreoElectronico(Correo P_Correo);

        [OperationContract]
        List<Usuarios> VerificarEmailUsuario(Usuarios P_Usuario);

        [OperationContract]
        void ActualizarPrestamo(Prestamos P_Prestamo);
    }
}
