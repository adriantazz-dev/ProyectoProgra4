using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        public string IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string Email { get; set; }
        public Boolean Estado { get; set; }

        public Usuarios()
        {
            IdUsuario = string.Empty;
            Nombre = string.Empty;
            Contrasena = string.Empty;
            Email = string.Empty;
            Estado = false;
        }
    }
}
