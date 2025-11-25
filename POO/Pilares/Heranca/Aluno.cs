using Heranca;

namespace Heranca
{
    public class Aluno : Pessoa
    {
        public string Curso;

        public Aluno(string nome, int idade, string curso)
            : base(nome, idade)
        {
            Curso = curso;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine(@$"Características do Aluno: 
                                 Nome: {Nome} 
                                 Idade: {Idade} 
                                 Curso: {Curso}
");
        }
    }
}