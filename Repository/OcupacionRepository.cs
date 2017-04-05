using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class OcupacionRepository:IOcupacionRepository
    {
         private SonoVisosContext _context;

         public OcupacionRepository()
        {
            if (_context == null)
            {
                _context = new SonoVisosContext();
            }
        }
        
    public IEnumerable<Entidades.Ocupacion> GetOcupaciones()
    {
        return _context.Ocupaciones;
    }
}
}
