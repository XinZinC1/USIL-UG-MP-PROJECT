using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using USIL_UG_MP_PROJECT.Models;
using USIL_UG_MP_PROJECT.Models.Interface;

namespace USIL_UG_MP_PROJECT.Controllers
{
    public class MetodoPagoController : Controller
    {
        // Llamamos al repositorio a través de la Interfaz
        private readonly MetodoPagoInterface _metodoPagoRepository;

        // Inyectamos las dependencias tras haber agregado el servicio al Startup
        public MetodoPagoController(MetodoPagoInterface metodoPagoRepository)
        {
            _metodoPagoRepository = metodoPagoRepository;
        }

        public IActionResult Index()
        {
            return View(_metodoPagoRepository.GetAllMetodosPago());
        }

        public IActionResult Insert()
        {
            return View();
        }

        public IActionResult InsertMetodoPago(MetodoPago metodoPago)
        {
            if (ModelState.IsValid)
            {
                _metodoPagoRepository.Add(metodoPago);
                return RedirectToAction("Index");
            }

            else
            {
                return View("Insert");
            }
        }

    }
}
