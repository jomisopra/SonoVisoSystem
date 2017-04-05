using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente:Persona
    {
        
        public Int32 Telefono { get; set; }

        public Ocupacion Ocupacion { get; set; }
        public Int32 IdOcupacionFk { get; set; }

    }
}
