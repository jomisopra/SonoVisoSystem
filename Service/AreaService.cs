using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using Repository;

namespace Service
{
   public class AreaService:IAreaService
    {

       private IAreaRepository _repository;

       public AreaService()
        {
            if (_repository == null)
            {
                _repository = new AreaRepository();
            }
        }

        public IEnumerable<Entidades.Area> GetAreas()
        {
            return _repository.GetAreas();
        }
    }
}
