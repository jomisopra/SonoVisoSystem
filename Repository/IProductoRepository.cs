using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IProductoRepository
    {
        IEnumerable<Producto> GetProductos(string criterio);

        IQueryable<Material> GetMateriales(string criterio);

        IQueryable<Medio> GetMedios(string criterio);

        Producto GetProducto(Int32 id);

        Medio GetProductoByMedio(Int32 id);

        void AddProducto(Producto producto);

        void UpdateProducto(Producto producto);

        void UpdateMedio(Medio medio);

        void UpdateMaterial(Material material);

        void DeleteProducto(Int32 id);
    }
}
