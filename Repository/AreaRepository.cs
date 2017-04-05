using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public class AreaRepository:IAreaRepository
    {

         private SonoVisosContext _context;

         public AreaRepository()
        {
            if (_context == null)
            {
                _context = new SonoVisosContext();
            }
        }


        public IEnumerable<Entidades.Area> GetAreas()
        {
            return _context.Areas;
        }
    }
}
