using System.Web.Mvc;

namespace CaballerosZodiacoMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Caballeros del Zodiaco MVC con EF y Scaffold";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contacto";
            return View();
        }
    }
}