//Baseado no programa do exercício número 9,
//crie um programa que contenha o menu para os exercícios de 1 a 6,
//onde cada programa/menu deve executar uma função.

int opcao;
do
{
    Console.WriteLine("\n1) Exercício 1 - orçamento");
    Console.WriteLine("2) Exercício 2 - futebol");
    Console.WriteLine("3) Exercício 3 - triângulo");
    Console.WriteLine("4) Exercício 4 - senha");
    Console.WriteLine("5) Exercício 5 - maças");
    Console.WriteLine("6) Exercício 6 - aluno");
    Console.WriteLine("0) Sair");
    Console.Write("Escolha uma opçao ");

    opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {
        Console.Write("Salário ");
        double salario = double.Parse(Console.ReadLine());
        Console.Write("Gastos ");
        double gastos = double.Parse(Console.ReadLine());
        Console.WriteLine(gastos <= salario ? "Gastos dentro do orçamento" : "Orçamento estourado");
    }
    else if (opcao == 2)
    {
        Console.Write("Gols do time 1 ");
        int t1 = int.Parse(Console.ReadLine());
        Console.Write("Gols do time 2 ");
        int t2 = int.Parse(Console.ReadLine());
        if (t1 == t2) Console.WriteLine("A partida acabou empatada");
        else if (t1 > t2) Console.WriteLine("A partida acabou com a vitória do time 1");
        else Console.WriteLine("A partida acabou com a vitória do time 2");
    }
    else if (opcao == 3)
    {
        Console.Write("Lado A ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Lado B ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Lado C ");
        double c = double.Parse(Console.ReadLine());
        if (a == b && b == c)
            Console.WriteLine("Equilátero");
        else if (a == b || a == c || b == c)
            Console.WriteLine("Isósceles");
        else
            Console.WriteLine("Escaleno");
    }
    else if (opcao == 4)
    {
        Console.Write("Senha ");
        int senha = int.Parse(Console.ReadLine());
        Console.WriteLine(senha == 1234 ? "ACESSO PERMITIDO" : "ACESSO NEGADO");
    }
    else if (opcao == 5)
    {
        Console.Write("Quantidade de maças ");
        int qtd = int.Parse(Console.ReadLine());
        double preco = qtd < 12 ? 0.30 : 0.25;
        Console.WriteLine($"Total: R$ {qtd * preco:F2}");
    }
    else if (opcao == 6)
    {
        Console.Write("Média ");
        double media = double.Parse(Console.ReadLine());
        Console.Write("Frequência do aluno (%) ");
        double freq = double.Parse(Console.ReadLine());

        if (freq < 75)
            Console.WriteLine("Reprovado por falta");
        else if (media >= 7)
            Console.WriteLine("Aprovado");
        else if (media >= 3)
            Console.WriteLine("Recuperação");
        else
            Console.WriteLine("Reprovado");
    }
    else if (opcao == 0)
    {
        Console.WriteLine("Encerrando");
    }
    else
    {
        Console.WriteLine("Opçao inválida");
    }

} while (opcao != 0);
