using ClassesEstaticas;

namespace ClassesEstaticas
{
    public static class CalculosMatematicos
    {
        // Operações Matemáticas Simples

        // (public - visibilidade); (void - tipoDeRetorno); (Somar - Nome); (float a, float b - parâmetros); ({} - corpo)
        public static float Somar(float a, float b)
        {
            return a + b;
        }
        public static float Subtrair(float a, float b)
        {
            return a - b;
        }
        public static float Dividir(float a, float b)
        {
            if (b == 0) 
            { 
                Console.WriteLine($"Divisão Inválida");
                return 0;
            }
            return a / b;
        }
        public static float Multiplicar(float a, float b)
        {
            return a * b;
        }
    }
}