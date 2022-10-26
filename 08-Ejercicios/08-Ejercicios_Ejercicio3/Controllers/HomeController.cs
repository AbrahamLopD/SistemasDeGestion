using _08_Ejercicios_Ejercicio3.Models;
using _08_Ejercicios_Ejercicio3.Models.Entidades;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _08_Ejercicios_Ejercicio3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            Persona p = new Persona("Fernando", "Galiana", 49);
            return View(p);
        }

        [HttpPost]
        public ActionResult Index(Persona persona)
        {
            return View("Editar", persona);
        }

        public ActionResult Editar(Persona persona)
        {
            ViewBag.nombre = persona.Nombre;
            return View(persona);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}