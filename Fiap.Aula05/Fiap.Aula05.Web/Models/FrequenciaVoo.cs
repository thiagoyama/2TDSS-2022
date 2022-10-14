using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Aula05.Web.Models
{
    [Table("Tbl_Frequencia_Voo")]
    public class FrequenciaVoo
    {
        [HiddenInput]
        public int FrequenciaVooId { get; set; }
        public int CodigoFrequencia { get; set; }
        public DateTime DataAtivacao { get; set; }
    }
}
