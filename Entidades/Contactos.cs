using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Contactos
    {
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string PalabraClave{ get; set; }
        public string Correo { get; set; }
        public string TipoContacto { get; set; }
        public string Servicios { get; set; }
        public Boolean EstadoContacto { get; set; }
        

        public Contactos()
        {
            Nombre = string.Empty;
            Telefono = 0;
            PalabraClave = string.Empty;
            Correo = string.Empty;
            TipoContacto = string.Empty;
            Servicios = string.Empty;
            EstadoContacto = false;
            
        }
    }
}
