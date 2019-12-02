using System.Collections.Generic;
using System.IO;
using MVC.Models;

namespace MVC.Repositories
{
    public class AdicionalRepository
    {
        private const string PATH = "Database/Adicional.csv";

        public double ObterPrecoDe(string nomeAdicional)
        {
            var lista = ObterTodos();
            var preco = 0.0;
            foreach (var item in lista)
            {
                if (item.Nome.Equals(nomeAdicional))
                {
                    preco = item.Preco;
                    break;
                }
            }
            return preco;
        }
        public List<Adicional> ObterTodos()
        {
            List<Adicional> adicionais = new List<Adicional>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                Adicional ad = new Adicional();
                string [] dados = linha.Split(";");
                ad.Nome = dados[0];
                ad.Preco = double.Parse(dados[1]);
                adicionais.Add(ad);
            }

            return adicionais;
        }
    }
}