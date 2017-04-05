using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using Repository;

namespace Service
{
    public class AlquilerService:IAlquilerService
    {
        private IAlquilerRepository _repository;

        public AlquilerService()
        {
            if (_repository == null)
            {
                _repository = new AlquilerRepository();
            }
        }


        public IEnumerable<Alquiler> GetAlquileres(string criterio)
        {
            return _repository.GetAlquileres(criterio);
        }

        public Alquiler GetAlquiler(int id)
        {
            return _repository.GetAlquiler(id);
        }

        public void AddAlquiler(Alquiler Alquiler)
        {
            _repository.AddAlquiler(Alquiler);
        }

        public void UpdateAlquiler(Alquiler Alquiler)
        {
            _repository.UpdateAlquiler(Alquiler);
        }
        
        public void DeleteAlquiler(int Alquiler)
        {
            _repository.DeleteAlquiler(Alquiler);
        }


       
    }
}
