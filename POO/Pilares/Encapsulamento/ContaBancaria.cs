using Encapsulamento;

namespace Encapsulamento
{
    public class ContaBancaria
    {
        public float Saldo;

        // Construtor
        public ContaBancaria()
        {
            Saldo = 0;
        }

        // Sobrecarga do construtor
        public ContaBancaria(float saldoInicial)
        {
            if (saldoInicial > 0)
            {
                Saldo = saldoInicial;
            }
        }

        // Método público que seta/configura/guarda o saldo
        public void Depositar(float valor)
        {
            if (valor >= 0)
            {
                Saldo = valor;
                return;
            }
            Console.WriteLine($"Valor para depósito inválido");
        }

        // Método público que retorna o Saldo
        public float GetSaldo()
        {
            return Saldo;
        }

        // Método público Sacar
        public void Sacar(float valor)
        {
            if (valor >= 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque efetuado com sucesso");
                return;
            }
            Console.WriteLine("Valor para saque inválido");
        }
    }
}