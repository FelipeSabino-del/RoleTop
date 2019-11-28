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

        // public bool Inserir(Evento evento)
        // {
        //     var linha = new string[]{PrepararPedidoCSV(evento)};
        //     File.AppendAllLines(PATH,linha);
        //     return true;
        // }

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

                eventos.Add(evento);
            }
            return eventos;
        }
    }
}