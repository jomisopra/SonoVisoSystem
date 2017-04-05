using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using Repository;

namespace Service
{
   public class ProduccionService:IProduccionService
    {
       private IProduccionRepository _repository;

       public ProduccionService()
        {
            if (_repository == null)
            {
                _repository = new ProduccionRepository();
            }
        }
        public IEnumerable<Produccion> GetProducciones()
        {
            return _repository.GetProducciones();
        }
    }
}
