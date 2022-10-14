using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Aula05.Web.Models
{
    public class Passagem
    {
        public int PassagemId { get; set; }
        public string? Titular { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Tarifa { get; set; }

        //Relacionamento N:1
        public Voo Voo { get; set; }
        public int VooId { get; set; }
    }
}
