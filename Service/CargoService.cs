using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using Repository;

namespace Service
{
    public class CargoService:ICargoService
    {
        private ICargoRepository _repository;

        public CargoService()
        {
            if (_repository == null)
            {
                _repository = new CargoRepository();
            }
        }

        public IEnumerable<Cargo> GetCargos()
        {
            return _repository.GetCargos();
        }
    }
}
