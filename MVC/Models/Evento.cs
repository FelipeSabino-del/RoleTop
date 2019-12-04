using System;
using MVC.Enums;

namespace MVC.Models
{
    public class Evento
    {
        public ulong Id {get;set;}
        public string NomeEvento {get;set;}
        public NumPessoas NumPessoa {get;set;}
        public Usuario Usuario {get; set;}
        public DateTime DataDoEvento {get; set;}
        public Adicional Adicional {get;set;}
        public double PrecoTotal {get; set;}
        public uint Status {get;set;}

        public Evento()
        {
            this.Id = 0;
            this.Status = (uint) StatusEvento.PENDENTE;
        }
    }
}