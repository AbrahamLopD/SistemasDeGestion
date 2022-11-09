using _08_Ejercicio_DAL;
using _08_Ejercicio_Entidades;
using _08_Ejercicio_MVC.Models;
using _08_Ejercicio_MVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection.Emit;

namespace _08_Ejercicio_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Evento que devuelve la vista "Index" antes de enviar el formulario
        /// Precondición: ninguna
        /// Postcondición: ninguna
        /// </summary>
        /// <returns>View("Index")</returns>
        public ActionResult Index()
        {
            EscogerMision escogerMision = new EscogerMision();
            return View(escogerMision);
        }

        /// <summary>
        /// Evento que devuelve la vista "Index" tras enviar el formulario
        /// Precondición: la id de la misión deberá ser válida
        /// Postcondición: ninguna
        /// </summary>
        /// <param name="idMision"></param>
        /// <returns>View("Index")</returns>
        [HttpPost]
        public ActionResult Index(int idMision)
        {
            EscogerMision escogerMision = new EscogerMision();
            escogerMision.Mision = MisionManagerDAL.GetMisionById(idMision);
            return View(escogerMision);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}