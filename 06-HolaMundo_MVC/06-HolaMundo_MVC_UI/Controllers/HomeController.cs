using Microsoft.AspNetCore.Mvc;

namespace _06_HolaMundo_MVC_UI.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Función que nos retorna la página index
        /// </summary>
        /// <returns></returns>
        public ViewResult Index()
        {
            return View();
        }

        /// <summary>
        /// Función que nos retorna un saludo
        /// </summary>
        /// <returns></returns>
        public String SaludoNombre()
        {
            return "Hola Abraham";
        }

        /// <summary>
        /// Función que nos retorna la página ViewHolaMundo
        /// </summary>
        /// <returns></returns>
        public ViewResult ViewHolaMundo()
        {
            return View();
        }

        /// <summary>
        /// Función que nos retorna la página TablaMultiplicaciones
        /// </summary>
        /// <returns></returns>
        public ViewResult TablaMultiplicaciones()
        {
            return View();
        }
    }
}
