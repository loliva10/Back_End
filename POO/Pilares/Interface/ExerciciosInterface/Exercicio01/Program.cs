using Exercicio01;

Console.WriteLine($"-- Seja bem vindo ao programa de Cálculos de Geometria --");
Console.WriteLine();

// Retangulo
Console.WriteLine($"Vamos calcular o retangulo⬇️");
Console.WriteLine();
Console.Write("Digite a largura do retangulo ");
float largura = float.Parse(Console.ReadLine());

Console.Write("Digite a altura do retangulo ");
float altura = float.Parse(Console.ReadLine());

Retangulo ret = new Retangulo();
ret.Altura = altura;
ret.Largura = largura;
ret.CalcularArea();

Console.WriteLine();

// Circulo
Console.WriteLine($"Vamos calcular o circulo⬇️");
Console.WriteLine();
Console.Write("Digite o raio do circulo ");
float raio = float.Parse(Console.ReadLine());

Circulo circ = new Circulo();
circ.Raio = raio;
circ.CalcularArea();
