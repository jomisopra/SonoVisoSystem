using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CargoRepository:ICargoRepository
    {
         private SonoVisosContext _context;

         public CargoRepository()
        {
            if (_context == null)
            {
                _context = new SonoVisosContext();
            }
        }
    
    public IEnumerable<Entidades.Cargo> GetCargos()
    {
        return _context.Cargos;
    }
}
}
