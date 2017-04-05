using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using Repository;

namespace Service
{

  public  class GeneroService:IGeneroService
    {
         private IGeneroRepository _repository;

         public GeneroService()
        {
            if (_repository == null)
            {
                _repository = new GeneroRepository();
            }
        }
    
public IEnumerable<Genero> GetGeneros()
{
    return _repository.GetGeneros();
}
}
}
