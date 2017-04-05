using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Entidades;
using Service;

namespace SonoVisos.Controllers
{
    public class MaterialesController : Controller
    {
           private IProductoService _service;
           private ICategoriaService _categoriaService;

        public MaterialesController()
        {
            if (_service == null)
            {
                _service = new ProductoService();
            }

            if (_categoriaService == null)
            {
                _categoriaService = new CategoriaService();
            }

           
        }
        
       
        public ActionResult Index()
        {
            var lista = _service.GetMateriales("");

            return View(lista);
        }

        [HttpPost]
        public ActionResult Index(string criterio)
        {
            var lista = _service.GetMateriales(criterio);

            return PartialView("_Index", lista);
        }

        public ActionResult Create()
        {
            var categorias = _categoriaService.GetCategorias();

            ViewBag.Categorias = new SelectList(categorias, "IdCategoria", "Descripcion");

            return PartialView("_Create");
        }

        [HttpPost]
        public ActionResult Create(Material material)
        {

           
            if (ModelState.IsValid)
            {
                _service.AddProducto(material);

                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(Int32 id)
        {
            var material = _service.GetProducto(id);

            var categorias = _categoriaService.GetCategorias();

            ViewBag.Categorias = new SelectList(categorias, "IdCategoria", "Descripcion");
    
            return PartialView("_Edit", material);
        }

        [HttpPost]
        public ActionResult Edit(Material model)
        {
            _service.UpdateMaterial(model);

            var categorias = _categoriaService.GetCategorias();

            ViewBag.Categorias = new SelectList(categorias, "IdCategoria", "Descripcion");

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            _service.DeleteProducto(id);
            //TempData["UpdateSucces"] = "Se Elimino Correctamente";
            return RedirectToAction("Index");
        }
    }
}