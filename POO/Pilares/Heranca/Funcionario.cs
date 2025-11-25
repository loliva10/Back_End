using Heranca;

namespace Heranca
{
    public class Funcionarios
    {
        public string Nome;
        public double SalarioBase;

        public Funcionarios(string nome, double salarioBase)
        {
            Nome = nome;
            SalarioBase = salarioBase;
        }

        public virtual double CalcularSalario()
        {
            return SalarioBase;
        }
    }
}