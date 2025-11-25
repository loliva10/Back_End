using Exemplos;

namespace Exemplos
{
    public class Cachorro : Animal
    {
        public override void FazerSom()
        {
            System.Console.WriteLine($"Au au");
        }

        public override void Mover()
        {
            System.Console.WriteLine($"Ploc Ploc");
        }
    }
}