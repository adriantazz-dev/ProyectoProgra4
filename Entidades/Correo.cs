using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Correo
    {
        public string Asunto { get; set; }
        public string MensajeCorreo { get; set; }

        public List<string> Destinatario { get; set; }
        public string Remitente { get; set; }
    }
}
