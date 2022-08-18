using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exercicio.Models
{
    internal class ContaPoupanca : Conta, IContaInvestimento
    {
        public ContaPoupanca(int agencia, int numero, IList<Cliente> clientes) : base(agencia, numero, clientes)
        {
        }

        public decimal CalcularRetornoInvestimento()
        {
            throw new NotImplementedException();
        }

        public override void Depositar(decimal valor)
        {
            throw new NotImplementedException();
        }

        public override void Retirar(decimal valor)
        {
            throw new NotImplementedException();
        }
    }
}
