using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Material:Producto
    {

        //public String Categoria { get; set; }
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public String NroSerie { get; set; }


        public Categoria Categoria { get; set; }
        public Int32 IdCategoriaFK { get; set; }
        

    }
}
