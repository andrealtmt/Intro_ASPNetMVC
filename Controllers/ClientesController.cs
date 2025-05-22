using Intro_ASPNetMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Intro_ASPNetMVC.Controllers
{
    public class ClientesController : Controller
    {
        public static List<Cliente> listaClientes = new List<Cliente>
        {
            new Cliente {
                Id = 1,
                Nombre = "Andrea Robledo",
                FechaAlta = DateTime.Now,
                Email = "andy@gmail.com"
            },
            new Cliente {
                Id = 2,
                Nombre = "Judith Aguilera",
                FechaAlta = DateTime.Now,
                Email = "judy@gmail.com"
            },
        };

        // GET: Cliente
        public IActionResult Index()
        {
            return View();
        }

        // GET: listado de clientes
        public IActionResult ListadoClientes()
        {
            return View(listaClientes);
        }

        // GET: Clientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                cliente.Id = listaClientes.Count + 1;
                cliente.FechaAlta = DateTime.Now;
                listaClientes.Add(cliente);
                return RedirectToAction(nameof(ListadoClientes));
            }
            return View(cliente);
        }
    }
}