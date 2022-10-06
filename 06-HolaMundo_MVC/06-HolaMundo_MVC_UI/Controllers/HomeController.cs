using Microsoft.AspNetCore.Mvc;

namespace _06_HolaMundo_MVC_UI.Controllers
{
    public class HomeController : Controller
    {
        public String Index()
        {
            return "Hola Mundo";
        }

        public String SaludoNombre()
        {
            return "Hola Abraham";
        }

        public ViewResult ViewHolaMundo()
        {
            return View();
        }
    }
}
