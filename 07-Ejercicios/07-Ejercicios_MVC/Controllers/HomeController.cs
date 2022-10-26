using _07_Ejercicios_Entidades;
using _07_Ejercicios_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using _07_Ejercicios_DAL;
using _07_Ejercicios_MVC.Models.ViewModels;

namespace _07_Ejercicios_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        /// <summary>
        /// Función que devuelve la vista Index y recoge en el ViewData un saludo, en el View Bag una fecha y una persona por modelo
        /// Precondición: La vista debe existir
        /// Postcondición: ninguna
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            Persona persona1 = new Persona(0, 1, "Abraham", "López");

            if(DateTime.Now.Hour >= 5 && DateTime.Now.Hour < 13) ViewData["Saludo"] = "Buenos días";
            else if(DateTime.Now.Hour >= 13 && DateTime.Now.Hour < 20) ViewData["Saludo"] = "Buenas tardes";
            else if(DateTime.Now.Hour >= 20 && DateTime.Now.Hour < 5) ViewData["Saludo"] = "Buenas noches";
            ViewBag.FechaActual = DateTime.Now;
            return View(persona1);
        }

        public ActionResult EditorPersona()
        {
            EditorPersonaVM editorPersona = new EditorPersonaVM();

            return View(editorPersona);
        }

        /// <summary>
        /// Función que devuelve la vista ListadoPersonas
        /// Precondición: La vista debe existir
        /// Postcondición: ninguna
        /// </summary>
        /// <returns></returns>
        public ActionResult ListadoPersonas()
        {
            return View(ListadoPersonasDAL.ListarPersonas());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}