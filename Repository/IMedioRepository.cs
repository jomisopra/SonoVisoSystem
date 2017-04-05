using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Repository
{
    public interface IMedioRepository
    {
        IEnumerable<Medio> GetMedios(string criterio);

        Medio GetMedio(Int32 id);

        void AddMedio(Medio medio);

        void UpdateMedio(Medio medio);

        void DeleteMedio(Int32 medio);
    }
}
