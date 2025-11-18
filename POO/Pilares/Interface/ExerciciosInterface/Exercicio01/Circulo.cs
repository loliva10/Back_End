using Exercicio01;

namespace Exercicio01
{
    public class Circulo : IForma
    {
        public float Raio;
        private float PI = 3.14f;

        public void CalcularArea()
        {
            Console.WriteLine($"O raio do circulo é {PI * Raio * Raio}");
        }

    }
}