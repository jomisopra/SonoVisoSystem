using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
  public  class FormatoRepository:IFormatoRepository
    {
       private SonoVisosContext _context;

       public FormatoRepository()
        {
            if (_context == null)
            {
                _context = new SonoVisosContext();
            }
        }
    
public IEnumerable<Entidades.Formato> Getformatos()
{
    return _context.Formatos;
}
}
}
