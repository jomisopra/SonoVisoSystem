using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using Repository;

namespace Service
{
    public class ProductoService:IProductoService
    {
        private IProductoRepository _repository;

        public ProductoService()
        {
            if (_repository == null)
            {
                _repository = new ProductoRepository();
            }
        }


        public IEnumerable<Producto> GetProductos(string criterio)
        {
            return _repository.GetProductos(criterio);
        }

        public IQueryable<Material> GetMateriales(string criterio)
        {
            return _repository.GetMateriales(criterio);
        }

        public IQueryable<Medio> GetMedios(string criterio)
        {
            return _repository.GetMedios(criterio);
        }

        public Producto GetProducto(int id)
        {
            return _repository.GetProducto(id);
        }

        public Medio GetProductoByMedio(int id)
        {
            return _repository.GetProductoByMedio(id);
        }

        public void AddProducto(Producto producto)
        {
            _repository.AddProducto(producto);
        }

        public void UpdateProducto(Producto producto)
        {
            _repository.UpdateProducto(producto);
        }

        public void UpdateMaterial(Material material)
        {
            _repository.UpdateMaterial(material);
        }

        public void UpdateMedio(Medio medio)
        {
            _repository.UpdateMedio(medio);
        }

        public void DeleteProducto(int producto)
        {
            _repository.DeleteProducto(producto);
        }


       
    }
}
