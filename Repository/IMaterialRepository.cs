using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Repository
{
    public interface IMaterialRepository
    {
        IEnumerable<Material> GetMateriales(string criterio);

        Material GetMaterial(Int32 id);

        void AddMaterial(Material material);

        void UpdateMaterial(Material material);

        void DeleteMaterial(Int32 material);
    }
}
