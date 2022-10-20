namespace Fiap.Aula05.Web.Models
{
    public class Servico
    {
        public int ServicoId { get; set; }
        public string? Categoria { get; set; }
        public string? Descricao { get; set; }
        public decimal Valor { get; set; }

        //Relacionamento N:1
        public IList<VooServico> VoosServicos { get; set; }

    }
}
