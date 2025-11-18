using Exercicio02;

namespace Exercicio02
{
    public class Contrato : IImprimivel
    {
        public string Contratante = "";
        public string PrestadorDeServiço = "";
        public string Clausulas = "";

        public Contrato(string contratante, string contratada, string clausulas)
        {
            Contratante = contratante;
            PrestadorDeServiço = contratada;
            Clausulas = clausulas;
        }

        public void Imprimir()
        {
            Console.WriteLine(@$"Características do Contrato:
                                    Contratante: {Contratante}
                                    Contratado: {PrestadorDeServiço}
                                    Cláusulas do Contrato: 
                                    {Clausulas}
                ");
        }
    }
}