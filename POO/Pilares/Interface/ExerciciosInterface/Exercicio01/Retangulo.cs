using Exercicio01;

namespace Exercicio01
{
    public class Retangulo : IForma
    {
        public float Largura;
        public float Altura;

        public void CalcularArea()
        {
            Console.WriteLine($"A área do retangulo é = {Largura * Altura}");
        }
    }
}