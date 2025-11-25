using Exemplos;

namespace Exemplos
{
    public class Gato : Animal
    {
        public override void FazerSom()
        {
            System.Console.WriteLine($"Miau Miau");
        }

        public override void Mover()
        {
            System.Console.WriteLine($"Movendo as patinhas");
        }
    }
}