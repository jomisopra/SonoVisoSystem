using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public class GeneroRepository:IGeneroRepository
    {
         private SonoVisosContext _context;

         public GeneroRepository()
        {
            if (_context == null)
            {
                _context = new SonoVisosContext();
            }
        }
    
public IEnumerable<Entidades.Genero> GetGeneros()
{
    return _context.Generos;
}
}
}
