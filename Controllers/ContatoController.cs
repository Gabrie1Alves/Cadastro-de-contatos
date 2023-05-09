using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ControleDeCadastros.Models;

namespace ControleDeCadastros.Controllers
{
    public class ContatoController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}