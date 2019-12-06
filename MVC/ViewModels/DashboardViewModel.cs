using System.Collections.Generic;
using MVC.Models;

namespace MVC.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        public List<Evento> Eventos {get;set;}
        public List<Adicional> Adicionais {get;set;}
        public List<NumPessoas> NumeroPessoas {get;set;}
        public List<Espaço> Espaços {get;set;}
        public uint EventosAprovados {get;set;}
        public uint EventosReprovados {get;set;}
        public uint EventosPendentes {get;set;}

        public DashboardViewModel()
        {
            this.Eventos = new List<Evento>();
            this.Adicionais = new List<Adicional>();
            this.NumeroPessoas = new List<NumPessoas>();
            this.Espaços = new List<Espaço>();
        }
    }
}