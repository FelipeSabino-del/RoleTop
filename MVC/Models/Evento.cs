using System;

namespace MVC.Models
{
    public class Evento
    {
        public Usuario Usuario {get; set;}
        public DateTime DataDoEvento {get; set;}
        public double PrecoTotal {get; set;}

        public Evento()
        {
            this.Usuario = new Usuario();
        }
    }
}