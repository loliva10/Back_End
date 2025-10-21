//Faça um programa que o usuário informe o salário recebido e o total gasto.
//Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto 
//não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto 
//ultrapassar o valor do salário.

int n = 0, contador = 0;

Console.WriteLine("Informe o numero de repetiçoes");
n = int.Parse(Console.ReadLine());

while (contador < n)
{
    double salario, gastos;

    Console.WriteLine("Informe o salario recebido");
    salario = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe o total gasto:");
    gastos = double.Parse(Console.ReadLine());

    if (gastos <= salario)
    {
        Console.WriteLine("Gastos dentro do orçamento");
    }
    else
    {
        Console.WriteLine("Orçamento estourado");
    }

    contador++;
}