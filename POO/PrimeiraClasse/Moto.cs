using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    public class Moto
    {
         //Propriedades
        public int qtdRodas;

        public string Marca;

        public string Modelo;

        public string Cor;

        public void Acelerar()
        {
            Console.WriteLine($"Moto Acelerando");
        }

        public void Frear()
        {
            Console.WriteLine($"Moto Freando");
        }

        public void Ligar()
        {
            Console.WriteLine($"Moto Ligando");
        }
        
        public void Desligar()
        {
            Console.WriteLine($"Moto Desligando");
        }
    }
}