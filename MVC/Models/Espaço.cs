namespace MVC.Models
{
    public class Espaço
    {
        public string Nome {get;set;}
        public double Preco {get;set;}
        public Espaço()
        {

        }

        public Espaço(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}