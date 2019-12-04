namespace MVC.Models
{
    public class NumPessoas
    {
        public string Nome {get;set;}
        public double Preco {get;set;}
        public NumPessoas()
        {

        }

        public NumPessoas(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}