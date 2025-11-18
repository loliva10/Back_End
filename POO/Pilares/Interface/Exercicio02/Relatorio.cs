using Exercicio02;

namespace Exercicio02
{
    public class Relatorio : IImprimivel
    {
        public string Nome;
        public string TextoRelatorio = "";

        // Sobrecarga do Construtor
        public Relatorio(string responsavel, string txtrelatorio)
        {
            Nome = responsavel;
            TextoRelatorio = txtrelatorio;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Responsável: {Nome}");
            Console.WriteLine(TextoRelatorio);
        }
    }
}