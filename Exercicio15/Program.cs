//Faça um programa que receba 4 notas de um aluno, calcule e imprima a média
//aritmética das notas e a mensagem de APROVADO para média superior ou igual a 
//7,0 RECUPERAÇÃO para notas entre 5,0 e 7,0 ou a mensagem de REPROVADO para 
//média inferior a 5,0.

double nota1, nota2, nota3, nota4, media;

Console.Write("Digite a 1 nota: ");
nota1 = double.Parse(Console.ReadLine()!);

Console.Write("Digite a 2 nota: ");7
nota2 = double.Parse(Console.ReadLine()!);

Console.Write("Digite a 3 nota: ");
nota3 = double.Parse(Console.ReadLine()!);

Console.Write("Digite a 4 nota: ");
nota4 = double.Parse(Console.ReadLine()!);

// Cálculo
media = (nota1 + nota2 + nota3 + nota4) / 4;

//Exibição
if (media >= 7.0)
{
    Console.WriteLine("APROVADO");
}
else if (media >= 5.0)
{
    Console.WriteLine("RECUPERAÇÃO");
}
else
{
    Console.WriteLine("REPROVADO");
}
