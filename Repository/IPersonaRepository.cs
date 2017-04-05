using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Repository
{
    public interface IPersonaRepository
    {
        IEnumerable<Persona> GetPersonas(string criterio);

        IQueryable<Cliente> GetClientes(string criterio);

        IQueryable<Usuario> GetUsuarios(string criterio);

        Persona GetPersona(Int32 id);

        Cliente GetPersonabyCliente(Int32 id);
       

        void AddPersona(Persona persona);

        void UpdatePersona(Persona persona);

        void UpdateUsuario(Usuario usuario);

        void UpdateCliente(Cliente cliente);

        void DeletePersona(Int32 id);
    }
}
