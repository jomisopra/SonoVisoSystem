using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleEvento
    {
        public Evento Evento { get; set; }
        public Producto Producto { get; set; }
        public Int32 IdProductoFk { get; set; }
        public Int32 IdEventoFk { get; set; }


        public Int32 Duracion { get; set; }
        public String Ubicacion { get; set; }
        public bool Estado { get; set; }
        public DateTime Fecha { get; set; }
        public Int32 PrecioUnitario { get; set; }
        public Int32 PrecioTotal { get; set; }

    }
}
