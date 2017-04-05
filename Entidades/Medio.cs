using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medio:Producto
    {
        
        public String Titulo { get; set; }
        public String Descripcion { get; set; }
        public double Duracion { get; set; }
        public string CodigoMedio { get; set; }


        public Produccion Produccion { get; set; }
        public Int32 IdProduccionFK { get; set; }

        public Area Area { get; set; }
        public Int32 IdAreaFK { get; set; }

        public Genero Genero { get; set; }
        public Int32 IdGeneroFK { get; set; }


        public Formato Formato { get; set; }
        public Int32 IdFormatoFK { get; set; }


    }
}
