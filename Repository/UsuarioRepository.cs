using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using System.Data.Entity;

namespace Repository
{
    public class UsuarioRepository:IUsuarioRepository
    {
        private SonoVisosContext _context;

        public UsuarioRepository ()
	{
            if (_context==null)
	{
		 _context = new SonoVisosContext();
	}
	}

        public IEnumerable<Usuario> GetUsuarios(string criterio)
        {
            var query = from c in _context.Usuarios select c;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from c in query
                        where c.Nombre.ToUpper().Contains(criterio.ToUpper())
                        select c;
            }
            return query;
        }
        

        public Usuario GetUsuario(int id)
        {
           return _context.Usuarios.Find(id);
        }

        public void AddUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void UpdateUsuario(Usuario usuario)
        {
            _context.Entry(usuario).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteUsuario(int usuario)
        {
            var usu = _context.Usuarios.Find(usuario);

            if (usu!= null)
            {
                _context.Entry(usu).State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }
    }
}
