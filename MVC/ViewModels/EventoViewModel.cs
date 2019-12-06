using System;
using System.Collections.Generic;
using MVC.Models;

namespace MVC.ViewModels
{
    public class EventoViewModel : BaseViewModel
    {
        public List<Evento> Eventos {get;set;}
        public List<Adicional> Adicionais {get;set;}
        public List<NumPessoas> NumeroPessoas {get;set;}
        public List<Espaço> Espaços {get;set;}
        public Usuario Usuario {get;set;}
        public string NomeUsuario {get;set;}

        public EventoViewModel()
        {
            this.Eventos = new List<Evento>();
            this.Adicionais = new List<Adicional>();
            this.NumeroPessoas = new List<NumPessoas>();
            this.Espaços = new List<Espaço>();
            this.NomeUsuario = "?";
        }
        
    }
}