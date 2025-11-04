namespace MetodoConstrutor
{
    public class Pessoa3Sobrecargas
    {
        public string Nome;
        public int Idade;

        public Pessoa3Sobrecargas()
        {
            Nome = "Desconhecido"; //valores iniciais fixos
            Idade = 0; //valores iniciais fixos
        }

        public Pessoa3Sobrecargas(string n)
        {
            Nome = n; //valor inicial dinâmico
            Idade = 0; //valor inicial fixo
        }

        public Pessoa3Sobrecargas(string n, int i)
        {
            Nome = n; //valor inicial dinâmico
            Idade = i; //valor inicial fixo
        }

    }
}