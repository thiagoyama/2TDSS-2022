namespace Fiap.Aula02.UI.Models
{
    //CTRL + SHIFT + B -> buildar o projeto
    //Classe abstrata: não pode ser instanciada e pode conter métodos abstratos
    internal abstract class Pessoa
    {
        //Propriedades
        public string Nome { get; set; }
        //prop -> tab tab
        public string Genero { get; set; }

        //Construtor com nome e genero
        //ctor -> tab tab
        public Pessoa(string nome, string genero)
        {
            Nome = nome;
            Genero = genero;
        }

        //Métodos
        public void Falar()
        {
            Console.WriteLine("Pessoa falando...");
        }

        public abstract string ExibirDados();

    }
}
