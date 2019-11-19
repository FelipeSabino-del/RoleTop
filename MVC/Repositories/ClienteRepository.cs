using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MVC.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;


namespace MVC.Repositories
{
    public class UserRepository
    {
        private const string PATH = "Database/Usuario.csv";

        public UserRepository()
        {
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Usuario usuario)
        {
            var linha = new string[]{PrepararRegistroCSV(usuario)};
            File.AppendAllLines(PATH,linha);
            return true;
        }

        public Usuario ObterPor (string email)
        {
            var linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                if (ExtrairValorDoCampo("email",item).Equals(email))
                {
                    Usuario c = new Usuario();
                    c.Nome = ExtrairValorDoCampo("nome",item);
                    c.Email = ExtrairValorDoCampo("email",item);
                    c.DataNascimento = DateTime.Parse(ExtrairValorDoCampo("data_nascimento",item));
                    c.Cpf = ExtrairValorDoCampo("cpf",item);
                    c.Telefone = ExtrairValorDoCampo("telefone",item);
                    c.Senha = ExtrairValorDoCampo("senha",item);

                    return c;
                }
            }
            return null;
        }

        private string ExtrairValorDoCampo(string nomeCampo, string linha)
        {
            var chave = nomeCampo;

            var indiceChave = linha.IndexOf(chave);
            var indiceTerminal = linha.IndexOf(";", indiceChave);

            var valor = "";
            if (indiceTerminal != -1)
            {
                valor = linha.Substring(indiceChave, indiceTerminal - indiceChave);
            }else
            {
                valor = linha.Substring(indiceChave);
            }
            System.Console.WriteLine($"Campo: {nomeCampo} e valor {valor}");
            return valor.Replace(nomeCampo + "=","");
        }
        private string PrepararRegistroCSV(Usuario cliente)
        {
            return $"nome={cliente.Nome};email={cliente.Email};senha={cliente.Senha};cpf={cliente.Cpf};telefone={cliente.Telefone};data_nascimento={cliente.DataNascimento}";
        }
    }
}