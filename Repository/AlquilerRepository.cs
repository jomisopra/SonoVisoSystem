using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using System.Data.Entity;

namespace Repository
{
    public class AlquilerRepository:IAlquilerRepository
    {
         private SonoVisosContext _context;

        public AlquilerRepository()
        {
            if (_context == null)
            {
                _context = new SonoVisosContext();
            }
        }
        public IEnumerable<Alquiler> GetAlquileres(string criterio)
        {
            var query = from c in _context.Alquileres
                .Include("Usuario")
                .Include("Cliente") select c;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from c in query
                        where c.Cliente.Nombre.ToUpper().Contains(criterio.ToUpper())
                        select c;
            }
            return query;
        }

        public Alquiler GetAlquiler(int id)
        {
            return _context.Alquileres.Include("Usuario").Include("Cliente").Include("DetalleAlquileres.Producto").First(a => a.IdAlquiler == id);
        }

        public void AddAlquiler(Alquiler alquiler)
        {
            foreach (var item in alquiler.DetalleAlquileres)
            {
                _context.Entry(item).State = EntityState.Added;
            }

            _context.Alquileres.Add(alquiler);
            _context.SaveChanges();
        }

        public void UpdateAlquiler(Alquiler alquiler)
        {
            throw new NotImplementedException();
        }

        public void DeleteAlquiler(int Alquiler)
        {
            var alquiler = _context.Alquileres.Find(Alquiler);
            _context.Alquileres.Remove(alquiler);
            _context.SaveChanges();
        }
    }
}
