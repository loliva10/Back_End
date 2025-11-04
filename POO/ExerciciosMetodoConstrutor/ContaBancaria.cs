namespace ExerciciosMetodoConstrutor
{
    public class ContaBancaria
    {
        public string Titular;
        public double Saldo;

        public ContaBancaria(string t)
        {
            Titular = t;
            Saldo = 0;
        }

        public ContaBancaria(string t, double s)
        {
            Titular = t;
            Saldo = s;
        }

        public void ExibirDados()
        {
            Console.WriteLine(@$"Características da Conta Bancária: 
            Titular: {Titular}
            Saldo: R${Saldo:F2}

            ");
        }
    }
}