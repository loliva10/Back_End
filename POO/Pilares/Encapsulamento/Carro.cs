using System.Security.Cryptography;
using Encapsulamento;

namespace Encapsulamento
{
    public class Carro
    {
        private string Marca;
        private string Modelo;
        private int VelocidadeAtual;

        public void DefinirMarca(string marca)
        {
            Marca = marca;
        }

        public string ObterMarca()
        {
            return Marca;
        }

        public void DefinirModelo(string modelo)
        {
            Modelo = modelo;
        }

        public string ObterModelo()
        {
            return Modelo;
        }

        public int ObterVelocidade()
        {
            return VelocidadeAtual;
        }

        public void Acelerar(int velo)
        {
            VelocidadeAtual += velo;
        }

        public void Frear(int velo)
        {
            VelocidadeAtual -= velo;

            if (VelocidadeAtual < 0)
            {
                VelocidadeAtual = 0;
            }
        }
    }
}