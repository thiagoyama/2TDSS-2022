using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula05.Web.Models
{
    public class Voo
    {
        [HiddenInput]
        public int VooId { get; set; }
        public string? Origem { get; set; }
        public string? Destino { get; set; }
        public bool Escala { get; set; }
        public float Duracao { get; set; }
        public DateTime Data { get; set; } 
    }
}
