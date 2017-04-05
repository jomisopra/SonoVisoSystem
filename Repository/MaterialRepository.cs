using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using System.Data.Entity;

namespace Repository
{
    public class MaterialRepository:IMaterialRepository
    {
         private SonoVisosContext _context;

        public MaterialRepository()
        {
            if (_context == null)
            {
                _context = new SonoVisosContext();
            }
        }

        public IEnumerable<Material> GetMateriales(string criterio)
        {
            var query = from c in _context.Materiales select c;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from c in query
                        where c.Categoria.ToUpper().Contains(criterio.ToUpper())
                        select c;
            }
            return query;
        }

        public Material GetMaterial(int id)
        {
            return _context.Materiales.Find(id);
        }

        public void AddMaterial(Material material)
        {
            _context.Materiales.Add(material);
            _context.SaveChanges();
        }

        public void UpdateMaterial(Material material)
        {
            _context.Entry(material).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteMaterial(int material)
        {
            var mat = _context.Materiales.Find(material);

            if (mat!=null)
            {
                _context.Entry(mat).State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }
    }
}
