using Microsoft.AspNetCore.Mvc;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class UserController : AbstractController
    {

        public IActionResult Painel()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Painel",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

    }
}