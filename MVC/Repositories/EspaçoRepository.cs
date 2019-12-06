using System.Collections.Generic;
using System.IO;
using MVC.Models;

namespace MVC.Repositories
{
    public class EspaçoRepository
    {
        private const string PATH = "Database/Espaço.csv";

        public double ObterPrecoDe(string nomeEspaço)
        {
            var lista = ObterTodos();
            var preco = 0.0;
            foreach (var item in lista)
            {
                if (item.Nome.Equals(nomeEspaço))
                {
                    preco = item.Preco;
                    break;
                }
            }
            return preco;
        }
        public List<Espaço> ObterTodos()
        {
            List<Espaço> espaços = new List<Espaço>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                Espaço ep = new Espaço();
                string [] dados = linha.Split(";");
                ep.Nome = dados[0];
                ep.Preco = double.Parse(dados[1]);
                espaços.Add(ep);
            }

            return espaços;
        }
    }
}