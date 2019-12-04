using Microsoft.AspNetCore.Mvc;
using MVC.Repositories;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class EXTRAController : AbstractController
    {
        private EventoRepository eventoRepository = new EventoRepository();
        public IActionResult Painel()
        {
            var emailCliente = ObterUsuarioSession();
            var eventoCliente = eventoRepository.ObterTodosPorCliente(emailCliente);

            return View(new HistoricoViewModel()
            {
                Eventos = eventoCliente,
                NomeView = "Painel",
                UsuarioEmail = ObterUsuarioSession(), 
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

    }
}