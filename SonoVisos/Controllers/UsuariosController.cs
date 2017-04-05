using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Entidades;
using Service;

namespace SonoVisos.Controllers
{
    public class UsuariosController : Controller
    {
        private IPersonaService _service;
        private ICargoService _cargoService;


        public UsuariosController()
        {
            if (_service == null)
            {
                _service = new PersonaService();
            }

            if (_cargoService == null)
            {
                _cargoService = new CargoService();
            }

           
        }


        public ActionResult Index()
        {
            var lista = _service.GetUsuarios("");

            return View(lista);
        }

        [HttpPost]
        public ActionResult Index(string criterio)
        {
            var lista = _service.GetUsuarios(criterio);

            return PartialView("_Index", lista);
        }

        public ActionResult Create()
        {
            var cargos = _cargoService.GetCargos();

            ViewBag.Cargos = new SelectList(cargos, "IdCargo", "NombreCargo");

            return PartialView("_Create");
        }

        [HttpPost]
        public ActionResult Create(Usuario usuario)
        {


            if (ModelState.IsValid)
            {
                _service.AddPersona(usuario);

                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(Int32 id)
        {
            var usuario = _service.GetPersona(id);

            var cargos = _cargoService.GetCargos();

            ViewBag.Cargos = new SelectList(cargos, "IdCargo", "NombreCargo");

            return PartialView("_Edit", usuario);
        }


        [HttpPost]
        public ActionResult Edit(Usuario model)
        {
            _service.UpdateUsuario(model);
            var cargos = _cargoService.GetCargos();

            ViewBag.Cargos = new SelectList(cargos, "IdCargo", "NombreCargo");

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            _service.DeletePersona(id);
            //TempData["UpdateSucces"] = "Se Elimino Correctamente";
            return RedirectToAction("Index");
        }


      
        //[HttpGet]
        //public ActionResult Details(int id)
        //{
        //    var data = _servicePersona(id);
        //    
        //    return Niew("Details",data);
        //}



    }
}