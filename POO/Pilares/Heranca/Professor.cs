using Heranca;

namespace Heranca
{
    public class Professor : Pessoa
    {
        public string Disciplina;

        public Professor(string nome, int idade, string disciplina) : base(nome, idade)
        {
            Disciplina = disciplina;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine(@$"Características do Professor:
                                 Nome: {Nome}
                                 Idade: {Idade}
                                 Disciplina: {Disciplina}
");
        }
    }
}