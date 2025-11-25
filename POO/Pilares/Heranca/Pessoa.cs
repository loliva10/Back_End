using Heranca;

namespace Heranca
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine(@$"Características da Pessoa: 
                                 Nome: {Nome} 
                                 Idade: {Idade}
");
        }
    }
}