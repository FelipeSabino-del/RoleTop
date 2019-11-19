using System;

using MVC.Models;
using MVC.Repositories;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace McBonaldsMVC.Controllers {
    public class CadastroController : Controller {
        UserRepository userRepository = new UserRepository ();
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Cadastro";
            return View();
        }

        public IActionResult CadastrarCliente (IFormCollection form) {
            ViewData["NomeView"] = "msgfinal";
            ViewData["Action"] = "Cadastro";
            try {
                Usuario usuario = new Usuario (form["nome"], form["cpf"], form["telefone"], form["senha"], form["email"], DateTime.Parse (form["data-nascimento"]));
                userRepository.Inserir (usuario);
                return View ("Sucesso");
                

            } catch (Exception e) {
                System.Console.WriteLine (e.StackTrace);
                return View ("Erro");
            }

        }
    }
}