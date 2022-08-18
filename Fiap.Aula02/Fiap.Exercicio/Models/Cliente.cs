
namespace Fiap.Exercicio.Models
{
    internal class Cliente
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Cliente(long id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
