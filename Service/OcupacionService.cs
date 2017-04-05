using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using Repository;

namespace Service
{
    public class OcupacionService:IOcupacionService
    {
        private IOcupacionRepository _repository;

        public OcupacionService()
        {
            if (_repository == null)
            {
                _repository = new OcupacionRepository();
            }
        }

        public IEnumerable<Ocupacion> GetOcupaciones()
        {
            return _repository.GetOcupaciones();
        }
    }
}
