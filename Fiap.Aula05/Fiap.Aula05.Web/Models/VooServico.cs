namespace Fiap.Aula05.Web.Models
{
    public class VooServico
    {
        //Relacionamento 1:N (Voo)
        public int VooId { get; set; }
        public Voo Voo { get; set; }

        //Relacionamento 1:N (Servico)
        public int ServicoId { get; set; }
        public Servico Servico { get; set; }

    }
}
