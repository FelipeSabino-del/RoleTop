using Microsoft.AspNetCore.Mvc;
    namespace MVC.Controllers  
    {
    public class UserController : Controller
    {
        public IActionResult Historia()
        {
            ViewData["NomeView"] = "User";
            return View();
        }

    }
}