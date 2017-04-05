using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonoVisos.ViewModel
{
    public class AlquilerViewModel
    {
        public AlquilerViewModel()
        {
            DetalleAlquileres = new List<DetalleAlquilerViewModel>();
            Fecha = DateTime.Now;
            UsuarioId = 2;
        }

        public Int32 IdAlquiler { get; set; }
        public DateTime Fecha { get; set; }


        public Int32 UsuarioId { get; set; }
        public string UsuarioNombre { get; set; }

        public Int32 ClienteId { get; set; }
        public string ClienteNombre { get; set; }
        public decimal Total { get; set; }

        public List<DetalleAlquilerViewModel> DetalleAlquileres { get; set; }
    }
}
