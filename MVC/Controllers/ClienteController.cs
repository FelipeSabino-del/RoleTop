using System;
using MVC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.ViewModels;

namespace MVC.Controllers {
    public class ClienteController : AbstractController {

        private UserRepository userRepository = new UserRepository();
        private EventoRepository eventoRepository = new EventoRepository();

        [HttpGet]
        public IActionResult Login () {
            return View (new BaseViewModel()
            {
                NomeView = "Login",
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
    
        public IActionResult Historico ()
        {
            var emailCliente = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            var eventoCliente = eventoRepository.ObterTodosPorCliente(emailCliente);

            return View(new HistoricoViewModel()
            {
                Eventos = eventoCliente,
                NomeView = "Historico",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult Logoff ()
        {
            HttpContext.Session.Remove(SESSION_CLIENTE_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE_NOME);
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}