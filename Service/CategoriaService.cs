using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Repository;

namespace Service
{
   public  class CategoriaService:ICategoriaService
    {

        private ICategoriaRepository _context;

        public CategoriaService()
        {
            if (_context == null)
            {
                _context = new CategoriaRepository();
            }
        }

        public IEnumerable<Categoria> GetCategorias()
        {
            return _context.GetCategorias();
        }
    }
}
