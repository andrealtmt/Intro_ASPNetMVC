using Microsoft.AspNetCore.Mvc;

namespace Intro_ASPNetMVC.Controllers
{
    public class InicioController : Controller
    {
        // GET: Index
        public string Index()
        {
            return "Mi primer aplicación de ASP.NET Core MVC";
        }

        // GET: Buscar
        public ActionResult Buscar(string nombre)
        {
            return Content("El nombre del cliente es: " + nombre);
        }
    }
}