﻿
namespace Fiap.Aula02.UI.Models
{
    internal class Professor : Pessoa
    {
        public string Especialidade { get; set; }
        public decimal ValorHora { get; set; }
        public int Horas { get; set; }

        //Construtor com nome, genero, valorhora e horas
        public Professor(string nome, string genero, 
                        decimal valorHora, int horas) : base(nome, genero)
        {
            ValorHora = valorHora;
            Horas = horas;
        }

        //Construtor com nome, genero, valorhora, horas e especialidade
        public Professor(string nome, string genero, decimal valorHora, 
                        int horas, string especialidade): base(nome, genero)
        {
            ValorHora = valorHora;
            Horas = horas;
            Especialidade = especialidade;
        }

        //Métodos
        public override string ExibirDados()
        {
            return $"Nome: {Nome}, Especialidade: {Especialidade}";
        }

        public decimal CalcularSalario()
        {
            //Retorna o valor hora * as horas trabalhadas
            return ValorHora * Horas;
        }

        //Sobrecarga de método
        public decimal CalcularSalario(int horasExtras)
        {
            //Retorna o valor hora * (as horas trabalhadas + horas extras)
            return (Horas + horasExtras) * ValorHora; 
        }

    }
}