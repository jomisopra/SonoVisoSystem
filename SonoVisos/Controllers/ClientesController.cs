using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Entidades;
using Service;

namespace SonoVisos.Controllers
{
    public class ClientesController : Controller
    
    {
   private IPersonaService _service;
   private IOcupacionService _ocupacionService;

        public ClientesController()
        {
            if (_service == null)
            {
                _service = new PersonaService();
            }

            if (_ocupacionService == null)
            {
                _ocupacionService = new OcupacionService();
            }

           
        }
        
       
        public ActionResult Index()
        {
            var lista = _service.GetClientes("");

            return View(lista);
        }

        [HttpPost]
        public ActionResult Index(string criterio)
        {
            var lista = _service.GetClientes(criterio);

            return PartialView("_Index", lista);
        }

        public ActionResult Create()
        {
            var ocupaciones = _ocupacionService.GetOcupaciones();

            ViewBag.Ocupaciones = new SelectList(ocupaciones, "IdOcupacion", "NombreOcu");
            return PartialView("_Create");
        }

        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {

           
            if (ModelState.IsValid)
            {
                _service.AddPersona(cliente);

                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(Int32 id)
        {
            var cliente = _service.GetPersonabyCliente(id);

            var ocupaciones = _ocupacionService.GetOcupaciones();

            ViewBag.Ocupaciones = new SelectList(ocupaciones, "IdOcupacion", "NombreOcu");

            return PartialView("_Edit", cliente);
        }


        [HttpPost]
        public ActionResult Edit(Cliente model)
        {
            _service.UpdateCliente(model);

            var ocupaciones = _ocupacionService.GetOcupaciones();

            ViewBag.Ocupaciones = new SelectList(ocupaciones, "IdOcupacion", "NombreOcu");

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            _service.DeletePersona(id);
            //TempData["UpdateSucces"] = "Se Elimino Correctamente";
            return RedirectToAction("Index");
        }

        public JsonResult DevolverClientesPorCriterio(string query)
        {
            var clientes = _service.GetClientes(query)
                .Select(c => new
                {
                    ClienteId = c.Id,
                    ClienteNombre = c.Nombre
                });

            return Json(clientes, JsonRequestBehavior.AllowGet);
        }
    }
}