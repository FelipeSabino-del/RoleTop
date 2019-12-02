namespace MVC.Models
{
    public class Adicional
    {
        public string Nome {get;set;}
        public double Preco {get;set;}
        public Adicional()
        {

        }

        public Adicional(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}