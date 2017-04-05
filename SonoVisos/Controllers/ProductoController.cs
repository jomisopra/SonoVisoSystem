using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Entidades;
using Service;

namespace SonoVisos.Controllers
{
    public class ProductoController : Controller
    {
           private IProductoService _service;

        public ProductoController()
        {
            if (_service == null)
            {
                _service = new ProductoService();
            }

           
        }


        public JsonResult DevolverProductosPorCriterio(string query)
        {
            var clientes = _service.GetProductos(query)
                .Select(c => new
                {
                    IdProductoFk = c.IdProducto,
                    ProductoNombre = c.Nombre,
                    PrecioUnitario = c.Costo
                });

            return Json(clientes, JsonRequestBehavior.AllowGet);
        }

    }
}