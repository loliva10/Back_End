using Exemplos;

namespace Exemplos
{
    public class ContaCorrente : ContaBancaria
    {
        public double Saldo;
        public double Taxa = 0.5; //5% de taxa
        public override void Depositar(double valor)
        {
            if(valor <= 0)
            {
                Console.WriteLine($"O valor do saque deve ser maior que R$0,00");
                return; //para a execução do método aqui
            }

            Saldo += valor;
        }

        public override void Sacar(double valor)
        {// Na classe ContaPoupanca aplicar a taxa de 3% no saque

           // Valor solicitado + taxa de x%
            double totalComTaxa = valor + (valor * Taxa);

            if(valor <= 0 || totalComTaxa >= Saldo)
            {// Não tem dinheiro na conta
                Console.WriteLine($"O valor do saque deve ser positivo e ter dinheiro suficiente para realizar o saque");
                return;// Para a execução do método aqui
            }

            // Calcular o saldo + taxa de saque
            Saldo -= totalComTaxa;
        }
    }
}