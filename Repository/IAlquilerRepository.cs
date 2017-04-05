using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Repository
{
    public interface IAlquilerRepository
    {
        IEnumerable<Alquiler> GetAlquileres(string criterio);
        
        Alquiler GetAlquiler(Int32 id);
        
        void AddAlquiler(Alquiler alquiler);

        void UpdateAlquiler(Alquiler alquiler);

        void DeleteAlquiler(Int32 Alquiler);
    }
}
