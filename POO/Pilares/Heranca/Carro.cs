using Heranca;

namespace Heranca
{
    public class Carro : Veiculo
    {
        public int QtdPortas;

        public Carro(string marca, string modelo, int qtdportas)
            : base(marca, modelo)
        {
            QtdPortas = qtdportas;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine(@$"Características do carro: 
                                 Marca: {Marca} 
                                 Modelo: {Modelo} 
                                 Quantidade de Portas: {QtdPortas}
");
        }
    }
}