using System.Collections.Generic;
using System.IO;
using MVC.Models;

namespace MVC.Repositories
{
    public class NumPessoasRepository
    {
        private const string PATH = "Database/NumPessoas.csv";

        public double ObterPrecoDe(string numPessoas)
        {
            var lista = ObterTodos();
            var preco = 0.0;
            foreach (var item in lista)
            {
                if (item.Nome.Equals(numPessoas))
                {
                    preco = item.Preco;
                    break;
                }
            }
            return preco;
        }
        public List<NumPessoas> ObterTodos()
        {
            List<NumPessoas> pessoas = new List<NumPessoas>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                NumPessoas num = new NumPessoas();
                string [] dados = linha.Split(";");
                num.Nome = dados[0];
                num.Preco = double.Parse(dados[1]);
                pessoas.Add(num);
            }

            return pessoas;
        }
    }
}