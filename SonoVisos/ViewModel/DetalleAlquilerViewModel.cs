using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonoVisos.ViewModel
{
    public class DetalleAlquilerViewModel
    {
        public DetalleAlquilerViewModel()
        {
            Fecha = DateTime.Now;
        }

        public Int32 IdProductoFk { get; set; }
        public string ProductoNombre { get; set; }

        public Int32 IdAlquilerFk { get; set; }


        public DateTime Fecha { get; set; }
        public double PrecioTotal { get; set; }
        public double PrecioUnitario { get; set; }
        public Int32 CantidadUnitaria { get; set; }
        public bool Estado { get; set; }

    }
}
