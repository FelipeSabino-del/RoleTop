using System;
using MVC.Enums;
using MVC.Models;
using MVC.Repositories;
using MVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class UserController : AbstractController
    {
        UserRepository userRepository = new UserRepository();
        EventoRepository eventoRepository = new EventoRepository();
        AdicionalRepository adicionalRepository = new AdicionalRepository();
        NumPessoasRepository numPessoasRepository = new NumPessoasRepository();
        EspaçoRepository espaçoRepository = new EspaçoRepository();


        [HttpGet]
        public IActionResult Painel()
        {
            var Adicionais = adicionalRepository.ObterTodos();
            var numPessoas = numPessoasRepository.ObterTodos();
            var emailCliente = ObterUsuarioSession();

            EventoViewModel pvm = new EventoViewModel(); 
            pvm.Adicionais = adicionalRepository.ObterTodos();
            pvm.NumeroPessoas = numPessoasRepository.ObterTodos();
            pvm.Espaços = espaçoRepository.ObterTodos();
            pvm.Eventos = eventoRepository.ObterTodosPorCliente(emailCliente);

            if (!string.IsNullOrEmpty(emailCliente))
            {
                pvm.Usuario = userRepository.ObterPor(emailCliente);
            }
            var nomeUsuario = ObterUsuarioNomeSession();
            if (!string.IsNullOrEmpty(nomeUsuario))
            {
                pvm.NomeUsuario = nomeUsuario;
            }

            pvm.NomeView = "Painel";
            pvm.UsuarioEmail = emailCliente;
            pvm.UsuarioNome = nomeUsuario;
            return View(pvm);
        }
        [HttpPost]
        public IActionResult Registrar(IFormCollection form)
        {
            Evento evento = new Evento();
            var user = userRepository.ObterPor(ObterUsuarioSession());
            var nomeAdicional = form["adicional"];
            evento.Usuario.Email = user.Email;
            Adicional adicional = new Adicional(nomeAdicional, adicionalRepository.ObterPrecoDe(nomeAdicional));
            evento.Adicional = adicional;
            evento.DataDoEvento = DateTime.Parse(form["data_evento"]);
            var numPessoas = form["numpessoas"];
            NumPessoas pessoas = new NumPessoas(numPessoas, numPessoasRepository.ObterPrecoDe(numPessoas));
            evento.NumPessoa = pessoas;
            var nomeEspaço = form["tipo_evento"];
            Espaço espaço = new Espaço(nomeEspaço, espaçoRepository.ObterPrecoDe(nomeEspaço));
            evento.Espaço = espaço;
            evento.PrecoTotal = adicionalRepository.ObterPrecoDe(nomeAdicional) + numPessoasRepository.ObterPrecoDe(numPessoas) + espaçoRepository.ObterPrecoDe(nomeEspaço) +10000;

            if (eventoRepository.Inserir(evento))
            {
                return View ("Sucesso", new BaseViewModel()
                {
                    NomeView = "Painel",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }else{
                return View ("Erro", new BaseViewModel()
                {
                    NomeView = "Painel",
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