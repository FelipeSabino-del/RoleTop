using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace MVC.Models
{
    public class Usuario
    {
        public string Nome {get; set;}
        public string Cpf {get; set;}
        public string Telefone {get; set;}
        public string Senha {get; set;}
        public string Email {get; set;}
        public DateTime DataNascimento {get; set;}
        public uint TipoUsuario {get;set;}

        public Usuario ()
        {

        }
        public Usuario(string Nome, string Cpf, string Telefone, string Senha, string Email, DateTime DataNascimento)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Telefone = Telefone;
            this.Senha = Senha;
            this.Email = Email;
            this.DataNascimento = DataNascimento;
        }
    }
}
