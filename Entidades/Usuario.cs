using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario:Persona

    {
        
        public string Contraseña { get; set; }
        public Int32 Telefono { get; set; }

        public Cargo Cargo { get; set; }
        public Int32 IdCargoFK { get; set; }
         
      
    }
}
