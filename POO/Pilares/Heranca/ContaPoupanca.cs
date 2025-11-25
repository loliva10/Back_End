using Heranca;

namespace Heranca
{
    public class ContaPoupanca : Conta
    {
         public ContaPoupanca(int numero, double saldoInicial = 0) : base(numero, saldoInicial)
        {
        }

        public void CalcularRendimento()
        {
            double rendimento = Saldo * 0.02; // 2% de rendimento
            Saldo += rendimento;
            Console.WriteLine($"Rendimento de R${rendimento:F2} aplicado");
        }
    }
}