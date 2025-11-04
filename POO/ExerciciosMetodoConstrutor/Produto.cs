namespace ExerciciosMetodoConstrutor
{
    public class Produto
    {
        public string Nome;

        public int Preco;

        public int Estoque;

        public Produto(string n, int p, int e)
        {
            Nome = n;
            Preco = p;
            Estoque = e;
        }

        public void ExibirDados()
        {
            Console.WriteLine(@$"Características do Produto:
            Porduto: {Nome}
            Preço: R${Preco:F2}
            Em estoque: {Estoque}

            ");
        }
    }
}