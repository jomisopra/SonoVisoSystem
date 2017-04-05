using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alquiler
    {
        public Alquiler()
        {
            DetalleAlquileres = new List<DetalleAlquiler>();
            Fecha = DateTime.Now;
        }

        public Int32 IdAlquiler { get; set; }
        public DateTime Fecha { get; set; }


        public Persona Usuario { get; set; }
        public Int32 UsuarioId { get; set; }

        public Persona Cliente { get; set; }
        public Int32 ClienteId { get; set; }

        public List<DetalleAlquiler> DetalleAlquileres { get; set; }
    }
}
