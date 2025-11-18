using Exemplos;

namespace Exemplos
{
    public interface IControle
    {
        // Propriedades obrigatórias na classe
        public int NivelVolume

        // Métodos obrigatórios na classe
        void Ligar();
        void Desligar();
        void AumentarVolume();
        void DiminuirVolume();
    }
}