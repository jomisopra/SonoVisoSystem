using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleAlquiler
    {
        public DetalleAlquiler()
        {
            Fecha = DateTime.Now;
        }

        public Producto Producto { get; set; }
        public Int32 IdProductoFk { get; set; }

        public Alquiler Alquiler { get; set; }
        public Int32 IdAlquilerFk { get; set; }


        public DateTime Fecha { get; set; }
        public double PrecioTotal { get; set; }
        public double PrecioUnitario { get; set; }
        public Int32 CantidadUnitaria { get; set; }
        public bool Estado { get; set; }

    }
}
