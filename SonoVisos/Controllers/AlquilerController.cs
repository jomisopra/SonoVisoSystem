using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Service;
using SonoVisos.ViewModel;

namespace SonoVisos.Controllers
{
    public class AlquilerController : Controller
    {
        private IAlquilerService _service;

        public AlquilerController()
        {
            if (_service == null)
            {
                _service = new AlquilerService();
            }
        }

        [HttpGet]
        public ActionResult Index()
        {
            var viewModel = new List<AlquilerViewModel>();

            viewModel = _service.GetAlquileres("").Select(model => new AlquilerViewModel()
            {
                IdAlquiler = model.IdAlquiler,
                ClienteId = model.ClienteId,
                ClienteNombre = model.Cliente.Nombre,
                UsuarioId = model.UsuarioId,
                UsuarioNombre = model.Usuario.Nombre,
                Fecha = model.Fecha,
            }).ToList();

            return View("Index", viewModel);
        }

        [HttpPost]
        public ActionResult Index(string criterio)
        {
            var viewModel = new List<AlquilerViewModel>();

            var lista = _service.GetAlquileres(criterio);

            viewModel = lista.Select(model => new AlquilerViewModel()
            {
                IdAlquiler = model.IdAlquiler,
                ClienteId = model.ClienteId,
                ClienteNombre = model.Cliente.Nombre,
                UsuarioId = model.UsuarioId,
                UsuarioNombre = model.Usuario.Nombre,
                Fecha = model.Fecha,
            }).ToList();

            
            return PartialView("_Index", viewModel);
        }

        public ActionResult Create()
        {
            var viewModel = new AlquilerViewModel();
            return View("Create", viewModel);
        }

        [HttpPost]
        public ActionResult Create(AlquilerViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var model = new Alquiler()
                {
                    ClienteId = viewModel.ClienteId,
                    UsuarioId = viewModel.UsuarioId,
                };

                model.DetalleAlquileres = viewModel.DetalleAlquileres.Select(a => new DetalleAlquiler()
                {
                    IdProductoFk = a.IdProductoFk,
                    IdAlquilerFk = a.IdAlquilerFk,
                    Fecha = a.Fecha,
                    PrecioUnitario = a.PrecioUnitario,
                    CantidadUnitaria = a.CantidadUnitaria,
                    PrecioTotal = a.PrecioUnitario * a.CantidadUnitaria,
                    Estado = a.Estado
                }).ToList();

                _service.AddAlquiler(model);

                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(Int32 id)
        {
            var alquiler = _service.GetAlquiler(id);

            return View("Edit", alquiler);
        }

        [HttpPost]
        public ActionResult Edit(AlquilerViewModel model)
        {
            if (ModelState.IsValid)
            {
                //_service.UpdateAlquiler(model);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
             var viewModel = new AlquilerViewModel();

            var model = _service.GetAlquiler(id);

            viewModel.ClienteId = model.ClienteId;
            viewModel.ClienteNombre = model.Cliente.Nombre;
            viewModel.UsuarioId = model.UsuarioId;
            viewModel.UsuarioNombre = model.Usuario.Nombre;
            viewModel.Fecha = model.Fecha;
            viewModel.Total = (decimal) model.DetalleAlquileres.Sum(d => d.PrecioTotal);
            
            viewModel.DetalleAlquileres = model.DetalleAlquileres.Select(a => new DetalleAlquilerViewModel()
            {
                IdProductoFk = a.IdProductoFk,
                IdAlquilerFk = a.IdAlquilerFk,
                Fecha = a.Fecha,
                PrecioUnitario = a.PrecioUnitario,
                CantidadUnitaria = a.CantidadUnitaria,
                PrecioTotal = a.PrecioUnitario * a.CantidadUnitaria,
                Estado = a.Estado,
                ProductoNombre = a.Producto.Nombre
            }).ToList();

            return View("Details", viewModel);
        }
        
        [HttpGet]
        public ActionResult Delete(int id)
        {
            _service.DeleteAlquiler(id);
            return RedirectToAction("Index");
        }
    }
}