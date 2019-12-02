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
    public class UserRepository : RepositoryBase
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
                    Usuario user = new Usuario();
                    user.Nome = ExtrairValorDoCampo("nome",item);
                    user.TipoUsuario = uint.Parse(ExtrairValorDoCampo("tipo_usuario", item));
                    user.Email = ExtrairValorDoCampo("email",item);
                    user.DataNascimento = DateTime.Parse(ExtrairValorDoCampo("data_nascimento",item));
                    user.Cpf = ExtrairValorDoCampo("cpf",item);
                    user.Telefone = ExtrairValorDoCampo("telefone",item);
                    user.Senha = ExtrairValorDoCampo("senha",item);

                    return user;
                }
            }
            return null;
        }

        private string PrepararRegistroCSV(Usuario usuario)
        {
            return $"tipo_usuario={usuario.TipoUsuario};nome={usuario.Nome};email={usuario.Email};senha={usuario.Senha};cpf={usuario.Cpf};telefone={usuario.Telefone};data_nascimento={usuario.DataNascimento}";
        }
    }
}