using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CategoriaRepository:ICategoriaRepository
    {
        private SonoVisosContext _context;

        public CategoriaRepository()
        {
            if (_context == null)
            {
                _context = new SonoVisosContext();
            }
        }

      

        public IEnumerable<Entidades.Categoria> GetCategorias()
        {
            return _context.Categorias;
        }
    }
}
