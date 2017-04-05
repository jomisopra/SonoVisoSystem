using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public Producto()
        {
            DetalleAlquileres = new List<DetalleAlquiler>();
        }

        public Int32 IdProducto { get; set; }
        public Int32 Anio { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public Int32 Stock { get; set; }
        public Int32 Costo { get; set; }
        public DateTime FIngreso { get; set; }

        public List<DetalleAlquiler> DetalleAlquileres { get; set; }

    }
}
