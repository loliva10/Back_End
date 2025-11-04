namespace ExerciciosMetodoConstrutor
{
    public class Carro
    {
        //Propriedades
        public string Marca;

        public string Modelo;

        public int Ano;

        public Carro(string mc, string md, int a)
        {
            Marca = mc;
            Modelo = md;
            Ano = a;
        }

        public void ExibirDados()
        {
            Console.WriteLine(@$" Características do carro: 
            Marca:{Marca}
            Modelo: {Modelo}
            Ano: {Ano}

            ");
        }
    }
}