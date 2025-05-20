using Microsoft.AspNetCore.Mvc;

namespace Intro_ASPNetMVC.Controllers
{
    public class ProveedoresController : Controller
    {
        public IActionResult ListadoProveedores()
        {
            ViewBag.Proveedores = "Intel, NVIDIA, AMD, Microsoft";
            return View();
        }
    }
}