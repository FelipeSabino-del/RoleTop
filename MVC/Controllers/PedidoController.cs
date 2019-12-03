using System;
using MVC.Enums;
using MVC.Models;
using MVC.Repositories;
using MVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class PedidoController : AbstractController
    {
        UserRepository userRepository = new UserRepository();
        EventoRepository eventoRepository = new EventoRepository();
        AdicionalRepository adicionalRepository = new AdicionalRepository();


        [HttpGet]
        public IActionResult Index()
        {
            var Adicionais = adicionalRepository.ObterTodos();

            EventoViewModel pvm = new EventoViewModel(); 
            pvm.Adicionais = adicionalRepository.ObterTodos();

            var emailCliente = ObterUsuarioSession();
            if (!string.IsNullOrEmpty(emailCliente))
            {
                pvm.Usuario = userRepository.ObterPor(emailCliente);
            }
            var nomeUsuario = ObterUsuarioNomeSession();
            if (!string.IsNullOrEmpty(nomeUsuario))
            {
                pvm.NomeUsuario = nomeUsuario;
            }

            pvm.NomeView = "Pedido";
            pvm.UsuarioEmail = emailCliente;
            pvm.UsuarioNome = nomeUsuario;
            return View(pvm);
        }
        [HttpPost]
        public IActionResult Registrar(IFormCollection form)
        {
            Evento evento = new Evento();

            var nomeAdicional = form["adicional"];
            Adicional adicional = new Adicional(nomeAdicional, adicionalRepository.ObterPrecoDe(nomeAdicional));
            evento.Adicional = adicional;
            evento.NomeEvento = form["tipo_evento"];
            evento.DataDoEvento = DateTime.Parse(form["data"]);
            evento.NumPessoa = uint.Parse(form["numpessoas"]);
            evento.PrecoTotal = adicionalRepository.ObterPrecoDe(nomeAdicional);

            if (eventoRepository.Inserir(evento))
            {
                return View ("Sucesso", new BaseViewModel()
                {
                    NomeView = "Pedido",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }else{
                return View ("Erro", new BaseViewModel()
                {
                    NomeView = "Pedido",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
        public IActionResult Aprovar(uint id)
        {
            var evento = eventoRepository.ObterPor(id);
            evento.Status = (uint) StatusEvento.APROVADO;

            if (eventoRepository.Atualizar(evento))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }else
            {
            return View("Erro", new RespostaViewModel("Não foi possível aprovar o pedido")
            {
                NomeView = "Dashboard",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
                
            }
        }
        public IActionResult Reprovar(uint id)
        {
            var pedido = eventoRepository.ObterPor(id);
            pedido.Status = (uint) StatusEvento.REPROVADO;

            if (eventoRepository.Atualizar(pedido))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }else
            {
            return View("Erro", new RespostaViewModel("Não foi possível reprovar o pedido")
            {
                NomeView = "Dashboard",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
                
            }
        }
    }
}