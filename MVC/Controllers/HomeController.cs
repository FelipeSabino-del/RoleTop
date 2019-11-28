using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class HomeController : AbstractController
    {
        public IActionResult Index()
        {
            return View (new BaseViewModel()
            {
                NomeView = "Home",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
