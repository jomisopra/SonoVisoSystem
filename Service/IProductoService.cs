using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IProductoService
    {
        IEnumerable<Producto> GetProductos(string criterio);

        IQueryable<Material> GetMateriales(string criterio);

        IQueryable<Medio> GetMedios(string criterio);

        Producto GetProducto(Int32 id);

        Medio GetProductoByMedio(Int32 id);

        void AddProducto(Producto producto);

        void UpdateMedio(Medio medio);

        void UpdateMaterial(Material material);

        void UpdateProducto(Producto producto);

        void DeleteProducto(Int32 producto);
    }
}
