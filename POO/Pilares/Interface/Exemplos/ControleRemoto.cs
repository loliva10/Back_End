using Exemplos;

namespace Exemplos
{
    public class ControleRemoto : IControle
    {
        public int NivelVolume = 0;

        public int VolumeMaximo = 100;
        public ControleRemoto()
        {
            NivelVolume = 10;
        }

        public void Ligar()
        {
            Console.WriteLine($"Tv ligada");
        }

        public void Desligar()
        {
            Console.WriteLine($"Tv desligada");
        }

        public void AumentarVolume()
        {
            if(NivelVolume < VolumeMaximo)
            NivelVolume++;
            Console.WriteLine($"Volume aumentado para {NivelVolume}");
        }

        public void DiminuirVolume()
        {
            NivelVolume--;
            Console.WriteLine($"Volume diminuído para {NivelVolume}");
        }

    }
}