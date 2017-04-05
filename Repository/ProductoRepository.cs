using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using System.Data.Entity;

namespace Repository
{
    public class ProductoRepository:IProductoRepository
    {
        private SonoVisosContext _context;

        public ProductoRepository()
        {
            if (_context == null)
            {
                _context = new SonoVisosContext();
            }
        }

        public IEnumerable<Producto> GetProductos(string criterio)
        {
            var query = from c in _context.Productos select c;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from c in query
                        where c.Nombre.ToUpper().Contains(criterio.ToUpper())
                        select c;
            }
            return query;
        }

        public Producto GetProducto(int id)
        {
            return _context.Materiales.FirstOrDefault(m => m.IdProducto == id); 
        }

        public Medio GetProductoByMedio(int id)
        {
            return _context.Medios.FirstOrDefault(u => u.IdProducto == id);
        }

        public void AddProducto(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
        }

        public void UpdateProducto(Producto producto)
        {
            _context.Entry(producto).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void UpdateMaterial(Material material)
        {
            _context.Entry(material).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void UpdateMedio(Medio medio)
        {
            _context.Entry(medio).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteProducto(int id)
        {
            var prod = _context.Productos.Find(id);

            if (prod != null)
            {
                _context.Productos.Remove(prod);
                _context.SaveChanges();
            }
        }


        public IQueryable<Material> GetMateriales(string criterio)
        {
            var query = from c in _context.Materiales.Include("Categoria")
                        select c;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from c in query
                        where c.Nombre.ToUpper().Contains(criterio.ToUpper())
                        select c;
            }
            return query.OfType<Material>();
        }


        public IQueryable<Medio> GetMedios(string criterio)
        {
            var query = from c in _context.Medios.Include("Area").Include("Genero").Include("Formato").Include("Produccion") select c;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from c in query
                        where c.Nombre.ToUpper().Contains(criterio.ToUpper())
                        select c;
            }
            return query.OfType<Medio>();
        }
    }
}
