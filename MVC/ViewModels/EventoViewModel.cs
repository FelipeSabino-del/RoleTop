using System;
using System.Collections.Generic;
using MVC.Models;

namespace MVC.ViewModels
{
    public class PedidoViewModel : BaseViewModel
    {
        // public List<Hamburguer> Hamburgueres {get;set;}
        // public List<Shake> Shakes {get;set;}
        public Usuario Usuario {get;set;}
        public string NomeUsuario {get;set;}

        public PedidoViewModel()
        {
            // this.Hamburgueres = new List<Hamburguer>();
            // this.Shakes = new List<Shake>();
            this.Usuario = new Usuario();
            this.NomeUsuario = "?";
        }
        
    }
}