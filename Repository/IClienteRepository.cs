using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Repository
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> GetClientes(string criterio);

        Cliente GetCliente(Int32 id);

        void AddCliente(Cliente cliente);

        void UpdateCliente(Cliente cliente);

        void DeleteCLiente(Int32 cliente);

    }
}
