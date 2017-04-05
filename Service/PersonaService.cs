using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using Entidades;
using Repository;

namespace Service
{
    public class PersonaService:IPersonaService
    {
        private IPersonaRepository _repository;

        public PersonaService()
        {
            if (_repository == null)
            {
                _repository = new PersonaRepository();
            }
        }

        public IEnumerable<Persona> GetPersonas(string criterio)
        {
            return _repository.GetPersonas(criterio);
        }

        public IQueryable<Cliente> GetClientes(string criterio)
        {
            return _repository.GetClientes(criterio);
        }

        public IQueryable<Usuario> GetUsuarios(string criterio)
        {
            return _repository.GetUsuarios(criterio);
        }


        public Persona GetPersona(int id)
        {
            return _repository.GetPersona(id);
        }

        public Cliente GetPersonabyCliente(int id)
        {
            return _repository.GetPersonabyCliente(id);
        }

        public void AddPersona(Persona persona)
        {
            _repository.AddPersona(persona);
        }

        public void UpdatePersona(Persona persona)
        {
            _repository.UpdatePersona(persona);
        }


        public void UpdateUsuario(Usuario usuario)
        {
            _repository.UpdateUsuario(usuario);
        }

        public void UpdateCliente(Cliente cliente)
        {
            _repository.UpdateCliente(cliente);
        }

        public void DeletePersona(int persona)
        {
            _repository.DeletePersona(persona);
        }


        

       
    }
}
