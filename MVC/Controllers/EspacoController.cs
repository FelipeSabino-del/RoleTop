using Microsoft.AspNetCore.Mvc;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class EspacoController: AbstractController
    {
        public IActionResult Index()
        {
            return View (new BaseViewModel()
            {
                NomeView = "Espaco",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}