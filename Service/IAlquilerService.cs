using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IAlquilerService
    {
        IEnumerable<Alquiler> GetAlquileres(string criterio);

        Alquiler GetAlquiler(Int32 id);

        void AddAlquiler(Alquiler Alquiler);

        void UpdateAlquiler(Alquiler Alquiler);

        void DeleteAlquiler(Int32 Alquiler);
    }
}
