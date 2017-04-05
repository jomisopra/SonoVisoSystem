using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
  public  class ProduccionRepository:IProduccionRepository
    {
         private SonoVisosContext _context;

         public ProduccionRepository()
        {
            if (_context == null)
            {
                _context = new SonoVisosContext();
            }
        }

    
public IEnumerable<Entidades.Produccion> GetProducciones()
{
    return _context.Produccions;
}
}
}
