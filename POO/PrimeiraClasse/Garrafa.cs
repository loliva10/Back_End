using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    public class Garrafa
    {
        //Propriedades
        public string Marca;

        public string Capacidade;

        public string Cor;

        public string Tamanho;

        //Métodos
        public void Abrir()
        {
            Console.WriteLine($"Garrafa aberta");
        }

        public void Fechar()
        {
            Console.WriteLine($"Garrafa fechada");
        }

        public void Esvaziar()
        {
            Console.WriteLine($"Garrafa vazia");
        }
        
         public void Encher()
        {
            Console.WriteLine($"Garrafa cheia");
        }
    }
}