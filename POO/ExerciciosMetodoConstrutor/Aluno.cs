namespace ExerciciosMetodoConstrutor
{
    public class Aluno
    {
        public string Nome;

        public int Nota;

        public Aluno()
        {
            Nome = "Desconhecido";
            Nota = 0;
        }

        public Aluno(string n, int i)
        {
            Nome = n;
            Nota = i;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"{Nome} teve uma nota final de: {Nota}");
        }
    }
}