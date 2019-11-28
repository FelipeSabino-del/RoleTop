using Microsoft.AspNetCore.Mvc;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class EventosController : AbstractController
    {
        public IActionResult Social()
        {
            return View (new BaseViewModel()
            {
                NomeView = "Evento",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
        public IActionResult Casamento()
        {
            return View (new BaseViewModel()
            {
                NomeView = "Evento",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
        public IActionResult Universitario()
        {
            return View (new BaseViewModel()
            {
                NomeView = "Evento",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
        public IActionResult Corporativo()
        {
            return View (new BaseViewModel()
            {
                NomeView = "Evento",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}