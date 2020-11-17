using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes
    {
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public char EstadoCivil{ get; set; }
        public Boolean EstadoCliente { get; set; }
        public int Telefono { get; set; }

        public Prestamos Prestamos = new Prestamos();

        public Clientes()
        {
            Cedula = 0;
            Nombre = string.Empty;
            Apellidos = string.Empty;
            EstadoCivil = char.MinValue;
            EstadoCliente = false;
            Telefono = 0;
        }
    }
}
