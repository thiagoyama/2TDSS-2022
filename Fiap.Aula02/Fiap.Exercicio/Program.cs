using Fiap.Exercicio.Exceptions;
using Fiap.Exercicio.Models;

//Ler a quantidade de clientes
Console.WriteLine("Digite a qtd de clientes");
int qtd = Convert.ToInt32(Console.ReadLine());

//Criar a lista de clientes
IList<Cliente> clientes = new List<Cliente>();

for (int i = 1; i <= qtd; i++)
{
    //Ler os clientes (nome e cpf) (o id é o i)
    Console.WriteLine("Digite o nome do cliente");
    var nome = Console.ReadLine();

    Console.WriteLine("Digite o cpf");
    var cpf = Console.ReadLine();

    //Instanciar o cliente e adicionar na lista
    var cliente = new Cliente(i, nome) { Cpf = cpf };
    clientes.Add(cliente);
}

//Ler os dados da conta corrente, agencia, numero, tipo
Console.WriteLine("Digite o número da conta");
int numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a agência da conta");
int agencia = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o tipo da conta: 0-Comum, 1-Especial, 2-Premium");
TipoConta tipo = (TipoConta)Convert.ToInt32(Console.ReadLine());

//Instanciar a conta corrente
var cc = new ContaCorrente(agencia, numero, clientes, tipo);

//Exibir os dados da conta corrente
Console.WriteLine(cc);

//Menu para 1-Depositar, 2-Retirar, 3-Exibir os dados da cc, 0-Sair
bool continuar = true;
while (continuar)
{
    Console.WriteLine("Escolha: \n1-Depositar \n2-Retirar \n3-Dados \n0-Sair");
    int opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            //Ler o valor e depositar
            Console.WriteLine("Digite o valor para depósito");
            decimal valor = Convert.ToDecimal(Console.ReadLine());
            cc.Depositar(valor);
            Console.WriteLine($"Depósito realizado! Novo saldo {cc.Saldo}");
            break;
        case 2:
            //Ler o valor e retirar
            Console.WriteLine("Digite o valor para retirada");
            valor = Convert.ToDecimal(Console.ReadLine());
            try
            {
                cc.Retirar(valor);
                Console.WriteLine($"Retirada realizada! Novo saldo {cc.Saldo}");
            }
            catch (SaldoInsuficienteException churros)
            {
                Console.WriteLine(churros.Message);
            }
            break;
        case 3:
            Console.WriteLine(cc);
            break;
        case 0:
            Console.WriteLine("Finalizando o programa!");
            continuar = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}