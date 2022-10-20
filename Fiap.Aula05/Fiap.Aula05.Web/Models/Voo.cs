using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Aula05.Web.Models
{
    [Table("Tbl_Voo")]
    public class Voo
    {
        [HiddenInput, Column("Id")]
        public int VooId { get; set; }

        //Relacionamento 1:N
        public IList<Passagem> Passagens { get; set; }

        //Relacionamento 1:1
        public FrequenciaVoo Frequencia { get; set; }
        //FK (opcional)
        public int FrequenciaVooId { get; set; }

        //Relacionamento N:M
        public IList<VooServico> VoosServicos { get; set; }

        [Required, MaxLength(100)] 
        public string? Origem { get; set; }

        [Required, MaxLength(100)]
        public string? Destino { get; set; }

        public bool Escala { get; set; }

        public float Duracao { get; set; }

        [Required]
        public DateTime Data { get; set; } 
    }
}
