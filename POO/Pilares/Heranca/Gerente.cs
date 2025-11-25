using Heranca;

namespace Heranca
{
    public class Gerente : Funcionarios
    {
        public double Bonus { get; set; }

        public Gerente(string nome, double salariobase, double bonus)
        : base(nome, salariobase)
        {
            Bonus = bonus;
        }

        public override double CalcularSalario() // override é usada quando uma classe filha quer substituir um método da classe pai com um novo comportamento
        {
            return SalarioBase + Bonus;
        }
    }
}