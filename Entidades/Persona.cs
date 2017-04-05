using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Persona
    {
        public Int32 Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public Int32 DNI { get; set; }
        public string Sexo { get; set; }

    [EmailAddress]
        public string Correo { get; set; }

        
    }
}
