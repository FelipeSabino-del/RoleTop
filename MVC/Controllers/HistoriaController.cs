using Microsoft.AspNetCore.Mvc;
using MVC.ViewModels;

namespace MVC.Controllers  
    {
    public class HistoriaController : AbstractController
    {
        public IActionResult Index()
        {
            return View (new BaseViewModel()
            {
                NomeView = "Historia",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

    }
}