using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using USIL_UG_MP_PROJECT.Models;
using USIL_UG_MP_PROJECT.Models.Interface;

namespace USIL_UG_MP_PROJECT.Controllers
{
    public class UbicacionController : Controller
    {
        // Llamamos al repositorio a través de la Interfaz
        private readonly UbicacionInterface _ubicacionRepository;

        // Inyectamos las dependencias tras haber agregado el servicio al Startup
        public UbicacionController(UbicacionInterface ubicacionRepository)
        {
            _ubicacionRepository = ubicacionRepository;
        }

        public IActionResult Index()
        {
            return View(_ubicacionRepository.GetAllUbicaciones());
        }

        public IActionResult Insert()
        {
            return View();
        }

        public IActionResult InsertUbicacion(Ubicacion ubicacion)
        {
            if (ModelState.IsValid)
            {
                _ubicacionRepository.Add(ubicacion);
                return RedirectToAction("Index");
            }

            else
            {
                return View("Insert");
            }
        }

        public IActionResult EditUbicacion(Ubicacion ubicacion)
        {
            if (ModelState.IsValid)
            {
                _ubicacionRepository.EditDetails(ubicacion);
                return RedirectToAction("Index");
            }

            else
            {
                return View("Edit");
            }
        }
    }
}
