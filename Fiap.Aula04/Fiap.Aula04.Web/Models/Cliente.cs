namespace Fiap.Aula04.Web.Models
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Fidelizado { get; set; }
        public Genero Genero { get; set; }

        //Select com as opções: Fundamental, Médio, Superior
        public string? Formacao { get; set; }
    }

    public enum Genero
    {
        Feminino, Masculino, Outros
    }
}
