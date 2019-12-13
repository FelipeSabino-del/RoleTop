using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.Repositories;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class HomeController : AbstractController
    {
        EventoRepository eventoRepository = new EventoRepository();
        private UserRepository userRepository = new UserRepository();
        public IActionResult Index()
        {
            EventoViewModel pvm = new EventoViewModel();
            pvm.Eventos = eventoRepository.ObterTodos();

                pvm.NomeView = "Home";
                pvm.UsuarioEmail = ObterUsuarioSession();
                pvm.UsuarioNome = ObterUsuarioNomeSession();
                return View (pvm);
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
