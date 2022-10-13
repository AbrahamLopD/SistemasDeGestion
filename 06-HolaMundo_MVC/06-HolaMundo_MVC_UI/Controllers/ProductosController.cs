using Microsoft.AspNetCore.Mvc;

namespace _06_HolaMundo_MVC_UI.Controllers
{
    public class ProductosController : Controller
    {
        public ViewResult ListadoProductos()
        {
            return View();
        }
    }
}
