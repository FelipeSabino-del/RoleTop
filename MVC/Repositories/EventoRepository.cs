using System;
using System.Collections.Generic;
using System.IO;
using MVC.Models;

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
                evento.Usuario = new Usuario();
                evento.Usuario.Nome = ExtrairValorDoCampo("usuario_nome", linha);
                evento.Usuario.Cpf = ExtrairValorDoCampo("usuario_cpf", linha);
                evento.Usuario.Telefone = ExtrairValorDoCampo("usuario_telefone", linha);
                evento.Usuario.Email = ExtrairValorDoCampo("usuario_email", linha);
                evento.Adicional.Nome = ExtrairValorDoCampo("adicional_nome", linha);
                evento.Adicional.Preco = double.Parse(ExtrairValorDoCampo("adicional_preco", linha));

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
            Usuario user = evento.Usuario;
            Adicional ad = evento.Adicional;
            return $"id={evento.Id};status_evento={evento.Status};usuario_nome={user.Nome};usuario_cpf={user.Cpf};usuario_telefone={user.Telefone};usuario_email={user.Email};adicional_nome={ad.Nome};adicional_preco={ad.Preco};data_evento={evento.DataDoEvento};preco_total={evento.PrecoTotal}";
        }
    }
}