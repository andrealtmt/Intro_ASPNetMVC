using Intro_ASPNetMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Intro_ASPNetMVC.Controllers
{
    public class ClienteController : Controller
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
        public IActionResult Create(Cliente cliente)
        {
            try
            {
                // agregar cliente a la lista
                listaClientes.Add(cliente);
                // redirigir a la vista de listado de clientes
                return RedirectToAction("ListadoClientes");
            }
            catch (Exception ex)
            {
                // Log the error
                ModelState.AddModelError("", "Error al crear el cliente: " + ex.Message);
                return View(cliente);
            }
        }
    }
}