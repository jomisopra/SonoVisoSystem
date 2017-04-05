using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using Repository;

namespace Service
{
   public class FormatoService:IFormatoService
    {
        private IFormatoRepository _repository;

        public FormatoService()
        {
            if (_repository == null)
            {
                _repository = new FormatoRepository();
            }
        }
        public IEnumerable<Formato> Getformatos()
        {
            return _repository.Getformatos();
        }
    }
}
