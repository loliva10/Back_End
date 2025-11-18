using System.Diagnostics.Contracts;
using Exercicio02;

namespace Exercicio02
{
    public class Fatura : IImprimivel
    {
        public string Devedor = "";
        public string Credor = "";
        public float Valor = 0;
        public int DiasDeAtraso = 0;
        private float Juros = 0.10f;

        // Método Construtor
        public Fatura(string dev, string cred, float val, int dda)
        {
            Devedor = dev;
            Credor = cred;
            Valor = val;
            DiasDeAtraso = dda;
        }

        public void Imprimir()
        {
            // Calcular o júros antes de usar o valor da fatura
            CalcularValorDivida();

            Console.WriteLine(@$"
             Credor: {Credor}
             Devedor: {Devedor}
             Dias de Atraso: {DiasDeAtraso} dia(s)
             Valor: R${Valor:F2}
             Júros: R${(Juros * DiasDeAtraso):F2}
             Total com Júros: R${Valor:F2}
            ");
        }

        public void CalcularValorDivida()
        {
            if (DiasDeAtraso > 0)
            {
                Valor = Valor + DiasDeAtraso * Juros;
            }
            if (DiasDeAtraso >= 5)
            {
                Console.WriteLine($"Dívida encaminhada para o SERASA!");
            }
        }
    }
}