using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using System.Data.Entity;

namespace Repository
{
    public class PersonaRepository : IPersonaRepository
    {

        private SonoVisosContext _context;

        public PersonaRepository()
        {
            if (_context == null)
            {
                _context = new SonoVisosContext();
            }
        }

        public IEnumerable<Persona> GetPersonas(string criterio)
        {
            var query = from c in _context.Personas.Include("Cliente").Include("Usuario") select c;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from c in query
                        where c.Nombre.ToUpper().Contains(criterio.ToUpper())
                        select c;
            }
            return query;
        }

        public Persona GetPersona(int id)
        {
            return _context.usuarios.FirstOrDefault(u => u.Id == id);

        }


        public Cliente GetPersonabyCliente(int id)
        {
            return _context.clientes.FirstOrDefault(u => u.Id == id);
        }

        public void AddPersona(Persona persona)
        {
            _context.Personas.Add(persona);
            _context.SaveChanges();
        }


        public void UpdatePersona(Persona persona)
        {
            _context.Entry(persona).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void UpdateUsuario(Usuario usuario)
        {
            _context.Entry(usuario).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void UpdateCliente(Cliente cliente)
        {
            _context.Entry(cliente).State = EntityState.Modified;
            _context.SaveChanges();
        }



        public void DeletePersona(int id)
        {
            var per = _context.Personas.Find(id);

            if (per != null)
            {
               
                 _context.Personas.Remove(per);
                _context.SaveChanges();
            }

        }



        public IQueryable<Cliente> GetClientes(string criterio)
        {
            var query = from c in _context.clientes.Include("Ocupacion")
                        select c;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from c in query
                        where c.Nombre.ToUpper().Contains(criterio.ToUpper())
                        select c;
            }
            return query.OfType<Cliente>();
        }


        public IQueryable<Usuario> GetUsuarios(string criterio)
        {
            var query = from c in _context.usuarios.Include("Cargo")
                        select c;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from c in query
                        where c.Nombre.ToUpper().Contains(criterio.ToUpper())
                        select c;
            }
            return query.OfType<Usuario>();
        }


      
    }
}
