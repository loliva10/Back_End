using Heranca;

namespace Heranca
{
    public class Veiculo
    {
        public string Marca;
        public string Modelo;
        public Veiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine(@$" Características do veículo: 
                                  Marca: {Marca} 
                                  Modelo: {Modelo}
");
        }
    }
}