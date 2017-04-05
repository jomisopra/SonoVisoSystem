using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using System.Data.Entity;

namespace Repository
{
    public class ClienteRepository:IClienteRepository
    {
        private SonoVisosContext _context;

        public ClienteRepository()
        {
            if (_context== null)
            {
                _context = new SonoVisosContext();
            }
        }


        public IEnumerable<Cliente> GetClientes(string criterio)
        {
            var query = from c in _context.Clientes select c;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from c in query
                        where c.Nombre.ToUpper().Contains(criterio.ToUpper())
                        select c;
            }
            return query;
        }

        public Cliente GetCliente(int id)
        {
            return _context.Clientes.Find(id);
        }

        public void AddCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void UpdateCliente(Cliente cliente)
        {
            _context.Entry(cliente).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteCLiente(int cliente)
        {
            var cli = _context.Clientes.Find(cliente);

            if (cli!=null)
            {
                _context.Entry(cli).State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }
    }
}
