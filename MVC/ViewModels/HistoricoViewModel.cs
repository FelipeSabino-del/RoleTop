using System.Collections.Generic;
using MVC.Models;

namespace MVC.ViewModels
{
    public class HistoricoViewModel : BaseViewModel
    {
        public List<Evento> Eventos {get;set;}
        public List<NumPessoas> Adicionais {get;set;}

    }
}