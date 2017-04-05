using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Evento
    {
        public Int32 IdEvento { get; set; }
        public String Nombre { get; set; }



        public Persona Usuario { get; set; }
        public Int32 UsuarioId { get; set; }

        public Persona Cliente { get; set; }
        public Int32 ClienteId { get; set; }

    }
}
