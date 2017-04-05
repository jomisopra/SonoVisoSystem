using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
namespace Repository
{
    public interface IOcupacionRepository
    {
        IEnumerable<Ocupacion> GetOcupaciones();
    }
}
