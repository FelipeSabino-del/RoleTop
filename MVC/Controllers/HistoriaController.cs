using Microsoft.AspNetCore.Mvc;
    namespace MVC.Controllers  
    {
    public class HistoriaController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Historia";
            return View();
        }

    }
}