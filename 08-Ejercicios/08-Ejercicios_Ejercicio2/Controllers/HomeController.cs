using _08_Ejercicios_Ejercicio2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _08_Ejercicios_Ejercicio2.Controllers
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
            return View();
        }

        [HttpPost]
        public ActionResult Index(string nombre)
        {
            ViewBag.nombre = nombre;
            return View("Index");
        }

        public ActionResult Saludo(string nombre)
        {
            ViewBag.nombre = nombre;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}