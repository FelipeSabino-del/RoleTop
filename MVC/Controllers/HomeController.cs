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
        private UserRepository userRepository = new UserRepository();
        public IActionResult Index()
        {
            return View (new BaseViewModel()
            {
                NomeView = "Home",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        [HttpPost]
        public IActionResult Login (IFormCollection form) {
            ViewData["Action"] = "Login";
            try {
                System.Console.WriteLine ("========================");
                System.Console.WriteLine (form["email"]);
                System.Console.WriteLine (form["senha"]);
                System.Console.WriteLine ("========================");

                var usuario = form["email"];
                var senha = form["senha"];

                var user = userRepository.ObterPor(usuario);

                if (user != null)
                {
                    if (user.Senha.Equals(senha))
                    {
                        HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                        HttpContext.Session.SetString(SESSION_CLIENTE_NOME, user.Nome);
                        return RedirectToAction("Historico", "Cliente");
                    }else
                    {
                        return View("Erro", new RespostaViewModel($"Senha incorreta!"){
                            NomeView = "Login"
                        });
                    }
                }else
                {
                    
                    return View ("Erro", new RespostaViewModel($"Usuário {usuario} não encontrado")
                    {
                        NomeView = "Login"
                    });
                }

            } catch (Exception e) {
                System.Console.WriteLine (e.StackTrace);
                return View ("Erro");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
