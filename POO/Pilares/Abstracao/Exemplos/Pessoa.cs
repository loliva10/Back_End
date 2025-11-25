using Exemplos;

namespace Exemplos
{
    public class Pessoa : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"Opa, sou uma pessoa");
        }

        public override void Mover()
        {
        Console.WriteLine($"Estou andandando a 2km para achar água de coco");
        }
    }
}