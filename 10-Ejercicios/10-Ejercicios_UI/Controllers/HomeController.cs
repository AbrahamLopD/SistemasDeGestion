using _10_Ejercicios_DAL;
using _10_Ejercicios_Entidades;
using _10_Ejercicios_UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace _10_Ejercicios_UI.Controllers
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

        [ActionName("Index")]
        [HttpPost]
        public ActionResult IndexPost()
        {
            
            SqlConnection miConexion = new SqlConnection();

            try
            {

                miConexion.ConnectionString = "server=rlindes.database.windows.net;database=rubenDB;uid=fernando;pwd=Mandaloriano69;";
            
                miConexion.Open();

                ViewBag.estadoConexion = miConexion.State;

            } 
            catch (Exception e)
            {
                return View("Error");
                //ViewBag.estadoConexion = e.Message;
            } 
            finally
            {
                miConexion.Close();
            }

            return View();
        }

        public ActionResult ListadoPersona()
        {
            List<Persona> personas = ListadoPersonasDAL.ListarPersonas();
            return View(personas);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}