using Heranca;

namespace Heranca
{
    public class Conta
    {
        public int Numero;
        public double Saldo;

        public Conta(int numero, double saldoInicial = 0)
        {
            Numero = numero;
            Saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Deposito de R${valor:F2} realizado");
            }
            else
            {
                Console.WriteLine("Valor de deposito invalido");
            }
        }

        public void Sacar(double valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R${valor:F2} realizado");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }
    }
}