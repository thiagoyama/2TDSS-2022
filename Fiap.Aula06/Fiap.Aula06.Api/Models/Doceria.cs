namespace Fiap.Aula06.Api.Models
{
    public class Doceria
    {
        public int DoceriaId { get; set; }
        public string? Endereco { get; set; }
        public string? Nome { get; set; }
        public bool Entrega { get; set; }
        public int Avaliacao { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
