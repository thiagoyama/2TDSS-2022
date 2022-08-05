//CTRL + L -> apaga a linha

using Fiap.Aula02.UI.Models;

//Instanciar um aluno
Aluno aluno = new Aluno("Emily", "Feminino", 89545)
{
    Curso = "TDS",
    AnoIngresso = 2021
};

//Instanciar um professor
Professor parducci = new Professor("Renato", "Masculino", 150, 40);

Professor kazuo = new Professor(genero: "Masculino", horas: 20, 
                valorHora: 100, nome: "Marcelo", especialidade: "Mobile");

