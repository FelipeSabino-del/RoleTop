using System;
using MVC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.ViewModels;
using MVC.Enums;

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
                        switch (user.TipoUsuario)
                        {
                            case (uint) TiposUsuario.CLIENTE:
                                HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                                HttpContext.Session.SetString(SESSION_CLIENTE_NOME, user.Nome);
                                HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, user.TipoUsuario.ToString());
                                return RedirectToAction("Painel", "User");

                            case (uint) TiposUsuario.ADMINISTRADOR:
                                HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                                HttpContext.Session.SetString(SESSION_CLIENTE_NOME, user.Nome);
                                HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, user.TipoUsuario.ToString());
                                return RedirectToAction("Dashboard", "Administrador");

                            default: return View(new RespostaViewModel($"Tipo de usuário não encontrado"));
                        }
                    }else
                    {
                        return View("Erro", new RespostaViewModel($"Senha incorreta!"));
                    }
                }else
                {
                    
                    return View ("Erro", new RespostaViewModel($"Usuário {usuario} não encontrado"));
                }

            } catch (Exception e) {
                System.Console.WriteLine (e.StackTrace);
                return View ("Erro");
            }
        }
    
        public IActionResult Historico ()
        {
            var emailCliente = ObterUsuarioSession();
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