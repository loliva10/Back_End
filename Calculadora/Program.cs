int opcao = -1;
double resultado = 0, n1 = 0, n2 = 0;
do
{
    Console.Clear();
    Console.WriteLine("=====CALCULADORA=====");
    Console.WriteLine();
    Console.WriteLine($"1- Soma");
    Console.WriteLine($"2- Subtracao");
    Console.WriteLine($"3- Multiplicacao");
    Console.WriteLine($"4- Divisao");
    Console.WriteLine($"0- Sair");
    Console.WriteLine($"Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());


    if (opcao != 0)
    {
        Console.WriteLine($"Digite o primeiro numero");
        n1 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Digite o segundo numero");
        n2 = double.Parse(Console.ReadLine());
    }




    switch (opcao)
    {
        case 1:
            resultado = Somar(n1, n2);
            Console.WriteLine($"Resultado da Soma: {resultado}");
            break;

        case 2:
            resultado = Subtracao(n1, n2);
            Console.WriteLine($"Resultado da Subtração: {resultado}");
            break;

        case 3:
            resultado = Multiplicacao(n1, n2);
            Console.WriteLine($"Resultado da Multiplicação: {resultado}");
            break;

        case 4:
            if (n2 == 0)
            {
                Console.WriteLine($"Divizão por zero");
            }

            else
            {
                resultado = Divisao(n1, n2);
                Console.WriteLine($"Resultado da Divisão: {resultado}");
            }
            break;

        case 0:
            Console.WriteLine($"obrigado por utiliar nosso programa:");
            break;
    }

    Console.WriteLine($"Pressione qualquer tecla + <Enter> para continuar ...");
    Console.ReadLine();

} while (opcao != 0);







double Somar(double x, double y)
{
    return x + y;
}

double Subtracao(double x, double y)
{
    return x - y;
}

double Multiplicacao(double x, double y)
{
    return x * y;
}

double Divisao(double x, double y)
{
    return x / y;
}