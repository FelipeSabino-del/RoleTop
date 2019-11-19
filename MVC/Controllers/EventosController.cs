using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class EventosController : Controller
    {
        public IActionResult Social()
        {
            ViewData["NomeView"] = "Evento";
            return View();
        }
        public IActionResult Casamento()
        {
            ViewData["NomeView"] = "Evento";
            return View();
        }
        public IActionResult Universitario()
        {
            ViewData["NomeView"] = "Evento";
            return View();
        }
        public IActionResult Corporativo()
        {
            ViewData["NomeView"] = "Evento";
            return View();
        }
    }
}