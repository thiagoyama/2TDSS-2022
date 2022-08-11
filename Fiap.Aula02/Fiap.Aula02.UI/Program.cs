//CTRL + L -> apaga a linha
using Fiap.Aula02.UI.Models;

//Instanciar um aluno
Aluno aluno = new Aluno("Emily", Genero.Feminino, 89545)
{
    Curso = "TDS",
    AnoIngresso = 2021
};

//Instanciar um professor
Professor parducci = new Professor("Renato", Genero.Masculino, 150, 40);

Professor kazuo = new Professor(genero: Genero.Masculino, horas: 20, 
                valorHora: 100, nome: "Marcelo", especialidade: "Mobile");


//Chamar o método exibir dados do professor e do aluno
Console.WriteLine(aluno.ExibirDados());
Console.WriteLine(kazuo.ExibirDados());

//Chamar o método falar do professor e do aluno
aluno.Falar(); //Método da classe Pessoa
parducci.Falar(); //Método da classe Professor

Pessoa menk = new Professor("Menk", Genero.Masculino, 1000, 40);
menk.Falar(); //Método da classe Professor

//kazuo.Especialidade = "Android";
//kazuo.CalcularSalario();
//((Professor)menk).Especialidade = "Cloud";
//((Professor)menk).CalcularSalario();

//Sobrescrever o método ToString para exibir os dados do objeto
Console.WriteLine(menk);
Console.WriteLine(kazuo);
Console.WriteLine(parducci);