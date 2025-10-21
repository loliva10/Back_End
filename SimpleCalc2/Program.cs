double n1, n2;

//pedir os dados
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("digite o primeiro numero");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("digite o segundo numero");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine();


double soma = n1 + n2;

if (n1 > n2)
{
    Console.WriteLine("O primeiro número é maior: " + n1);/*interpola o valor da variável n1*/

}
else if (n1 < n2)
{
    Console.WriteLine($"O segundo número é maior: {n2}");/*interpola o valor da variável n1*/
} else
{
    Console.WriteLine($"Os números {n1} e {n2} são iguais");
}
