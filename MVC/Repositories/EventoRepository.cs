using System;
using System.Collections.Generic;
using System.IO;
using MVC.Models;
using MVC.Enums;

namespace MVC.Repositories
{
    public class EventoRepository : RepositoryBase
    {
        private const string PATH = "Database/Evento.csv";

        public EventoRepository()
        {
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Evento evento)
        {
            var quantidadeEventos = File.ReadAllLines(PATH).Length;
            evento.Id = (ulong) ++quantidadeEventos;
            var linha = new string[]{PrepararEventoCSV(evento)};
            File.AppendAllLines(PATH,linha);
            return true;
        }

        public List<Evento> ObterTodosPorCliente(string emailCliente)
        {
            var eventos = ObterTodos();
            List<Evento> eventosUsuario = new List<Evento>();
            foreach (var evento in eventos)
            {
                if (evento.Usuario.Email.Equals(emailCliente))
                {
                    eventosUsuario.Add(evento);
                }
            }
            return eventosUsuario;
        }

        public bool Atualizar(Evento evento)
        {
            var eventosTotais = File.ReadAllLines(PATH);
            var eventoCSV = PrepararEventoCSV(evento);
            var linhaEvento = -1;
            var resultado = false;

            for (int i = 0; i < eventosTotais.Length; i++)
            {
                var idConvertido = ulong.Parse(ExtrairValorDoCampo("id", eventosTotais[i]));
                if (evento.Id.Equals(idConvertido))
                {
                    linhaEvento = i;
                    resultado = true;
                    break;
                }
            }
            if (resultado)
            {
                eventosTotais[linhaEvento] = eventoCSV;
                File.WriteAllLines(PATH, eventosTotais);
            }

            return resultado;
        }

        public List<Evento> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Evento> eventos = new List<Evento>();

            foreach (var linha in linhas)
            {
                Evento evento = new Evento();

                evento.Id = ulong.Parse(ExtrairValorDoCampo("id", linha));
                evento.Status = uint.Parse(ExtrairValorDoCampo("status_evento", linha));
                evento.Adicional.Nome = ExtrairValorDoCampo("adicional_nome", linha);
                evento.Adicional.Preco = double.Parse(ExtrairValorDoCampo("adicional_preco", linha));
                evento.NumPessoa.Nome = ExtrairValorDoCampo("numpessoa_nome", linha);
                evento.NumPessoa.Preco = double.Parse(ExtrairValorDoCampo("numpessoa_preco", linha));
                evento.Espaço.Nome = ExtrairValorDoCampo("espaco_nome", linha);
                evento.Espaço.Preco = double.Parse(ExtrairValorDoCampo("espaco_preco", linha));
                evento.DataDoEvento = DateTime.Parse(ExtrairValorDoCampo("data_evento", linha));
                evento.PrecoTotal =double.Parse(ExtrairValorDoCampo("preco_total", linha));
                evento.Usuario.Email = ExtrairValorDoCampo("email_user", linha);

                eventos.Add(evento);
            }
            return eventos;
        }
        public Evento ObterPor(ulong id)
        {
            var eventosTotais = ObterTodos();
            foreach (var pedido in eventosTotais)
            {
                if (id.Equals(pedido.Id))
                {
                    return pedido;
                }
            }
            return null;
        }
        

        private string PrepararEventoCSV(Evento evento)
        {  
            return $"id={evento.Id};status_evento={evento.Status};adicional_nome={evento.Adicional.Nome};adicional_preco={evento.Adicional.Preco};numpessoa_nome={evento.NumPessoa.Nome};numpessoa_preco={evento.NumPessoa.Preco};espaco_nome={evento.Espaço.Nome};espaco_preco={evento.Espaço.Preco};data_evento={evento.DataDoEvento.ToShortDateString()};preco_total={evento.PrecoTotal};email_user={evento.Usuario.Email}";
        }
    }
}