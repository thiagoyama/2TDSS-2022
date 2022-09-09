using System.ComponentModel.DataAnnotations;

namespace Fiap.Aula04.Web.Models
{
    public class Carro
    {
        public int Codigo { get; set; }

        public string? Modelo { get; set; }
        public int Ano { get; set; }
        public decimal Valor { get; set; }
        public string? Tipo { get; set; }

        public string? Marca { get; set; }

        [Display(Name = "Possui teto solar?")]
        public bool TetoSolar { get; set; }
        public Combustivel? Combustivel { get; set; }
    }

    public enum Combustivel
    {
        Etanol, Gasolina, Flex, Eletrico, Diesel
    }

}
