using Heranca;

namespace Heranca
{
    public class Moto : Veiculo
    {
        public string Capacete;

        public Moto(string marca, string modelo, string capacete)
            : base(marca, modelo)
        {
            Capacete = capacete;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine(@$"Características da Moto: 
                                 Marca: {Marca} 
                                 Modelo: {Modelo}  
                                 Capacete: {Capacete}
");
        }
    }
}