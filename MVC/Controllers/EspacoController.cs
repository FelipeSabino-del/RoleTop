using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class EspacoController: Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Espaco";
            return View();
        }
    }
}