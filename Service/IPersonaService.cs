using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IPersonaService
    {
        IEnumerable<Persona> GetPersonas(string criterio);

        IQueryable<Cliente> GetClientes(string criterio);

        IQueryable<Usuario> GetUsuarios(string criterio);

        Persona GetPersona(Int32 id);

        Cliente GetPersonabyCliente(Int32 id);

        void AddPersona(Persona persona);

        void UpdateUsuario(Usuario usuario);

        void UpdateCliente(Cliente cliente);

        void UpdatePersona(Persona persona);

        void DeletePersona(Int32 persona);
    }
}
