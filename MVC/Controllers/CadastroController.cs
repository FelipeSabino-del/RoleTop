using System;
using MVC.Models;
using MVC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.ViewModels;
using MVC.Enums;

namespace MVC.Controllers {
    public class CadastroController : AbstractController {
        UserRepository userRepository = new UserRepository ();
        public IActionResult Index()
        {
            return View (new BaseViewModel()
            {
                NomeView = "Cadastro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult CadastrarCliente (IFormCollection form) {
            ViewData["Action"] = "Cadastro";
            try {
                Usuario usuario = new Usuario (form["nome"], form["cpf"], form["telefone"], form["senha"], form["email"], DateTime.Parse (form["data-nascimento"]));
                usuario.TipoUsuario = (uint) TiposUsuario.CLIENTE;
                userRepository.Inserir (usuario);
                return View ("Sucesso", new RespostaViewModel(){
                    NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
                

            } catch (Exception e) {
                System.Console.WriteLine (e.StackTrace);
                return View ("Erro", new RespostaViewModel(){
                    NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }

        }
    }
}