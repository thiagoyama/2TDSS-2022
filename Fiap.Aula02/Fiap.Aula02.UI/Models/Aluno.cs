
namespace Fiap.Aula02.UI.Models
{
    //Aluno herda de Pessoa
    internal class Aluno : Pessoa
    {
        //Propriedades rm, curso, ano ingresso
        public int Rm { get; set; }
        public string Curso { get; set; }
        public int AnoIngresso { get; set; }

        //Criar o construtor do Aluno com nome, genero e rm
        public Aluno(string nome, string genero, int rm) : base(nome, genero)
        {
            Rm = rm;
        }

        //Métodos
        public override string ExibirDados()
        {
            return $"RM: {Rm}, Nome: {Nome}, Curso: {Curso}";
        }

    }
}
