using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Entidades;
using Service;

namespace SonoVisos.Controllers
{
    public class MediosController : Controller
    {
         private IProductoService _service;
         private IAreaService _areaservice;
         private IGeneroService _Generoservice;
         private IFormatoService _Formatoservice;
         private IProduccionService _Produccionservice;

        public MediosController()
        {
            if (_service == null)
            {
                _service = new ProductoService();
            }

            if (_areaservice == null)
            {
                _areaservice = new AreaService();
            }
            if (_Generoservice == null)
            {
                _Generoservice = new GeneroService();
            }
            if (_Formatoservice == null)
            {
                _Formatoservice = new FormatoService();
            }
            if (_Produccionservice == null)
            {
                _Produccionservice = new ProduccionService();
            }
           
        }
        
       
        public ActionResult Index()
        {
            var lista = _service.GetMedios("");

            return View(lista);
        }

        [HttpPost]
        public ActionResult Index(string criterio)
        {
            var lista = _service.GetMedios(criterio);

            return PartialView("_Index", lista);
        }

        public ActionResult Create()
        {
            var areas = _areaservice.GetAreas();
            var aroducciones = _Produccionservice.GetProducciones();
            var generoes = _Generoservice.GetGeneros();
            var formatoes = _Formatoservice.Getformatos();

            ViewBag.Areas = new SelectList(areas, "IdArea", "Nombre");
            ViewBag.Producciones = new SelectList(aroducciones, "IdProduccion", "nombre");
            ViewBag.Generoes = new SelectList(generoes, "IdGenero", "Nombre");
            ViewBag.Formatoes = new SelectList(formatoes, "IdFormato", "Nombre");

            return PartialView("_Create");
        }

        [HttpPost]
        public ActionResult Create(Medio medio)
        {

           
            if (ModelState.IsValid)
            {
                _service.AddProducto(medio);

                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(Int32 id)
        {
            var medio = _service.GetProductoByMedio(id);

            var areas = _areaservice.GetAreas();
            var aroducciones = _Produccionservice.GetProducciones();
            var generoes = _Generoservice.GetGeneros();
            var formatoes = _Formatoservice.Getformatos();

            ViewBag.Areas = new SelectList(areas, "IdArea", "Nombre");
            ViewBag.Producciones = new SelectList(aroducciones, "IdProduccion", "nombre");
            ViewBag.Generoes = new SelectList(generoes, "IdGenero", "Nombre");
            ViewBag.Formatoes = new SelectList(formatoes, "IdFormato", "Nombre");


            return PartialView("_Edit", medio);
        }

        [HttpPost]
        public ActionResult Edit(Medio model)
        {
            _service.UpdateMedio(model);

            var areas = _areaservice.GetAreas();
            var aroducciones = _Produccionservice.GetProducciones();
            var generoes = _Generoservice.GetGeneros();
            var formatoes = _Formatoservice.Getformatos();

            ViewBag.Areas = new SelectList(areas, "IdArea", "Nombre");
            ViewBag.Producciones = new SelectList(aroducciones, "IdProduccion", "nombre");
            ViewBag.Generoes = new SelectList(generoes, "IdGenero", "Nombre");
            ViewBag.Formatoes = new SelectList(formatoes, "IdFormato", "Nombre");


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