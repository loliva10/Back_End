using ClassesEstaticas;

Console.WriteLine("Bem vindo ao programa!");
Console.WriteLine();

Console.Clear();

// Console.WriteLine($"Digite o primeiro número: ");
// float a = float.Parse(Console.ReadLine());

// Console.WriteLine($"Digite o segundo número: ");
// float b = float.Parse(Console.ReadLine());

// // Uso da classe estática de forma auxiliar
// float r = CalculosMatematicos.Somar(a , b);
// Console.WriteLine($"Soma: {r}");

// r = CalculosMatematicos.Subtrair(a , b);
// Console.WriteLine($"Subtração: {r}");

// r = CalculosMatematicos.Dividir(a , b);
// Console.WriteLine($"Dvisão: {r}");

// r = CalculosMatematicos.Multiplicar(a , b);
// Console.WriteLine($"Multiplicação: {r}");

// Console.WriteLine($"Valor do PI é: {Math.PI}");
// Console.WriteLine($"Potência de 3 elevado a 2 é: {Math.Pow(3, 2)}");

Console.Write("Digite o primeiro número: ");
float a = float.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
float b = float.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine($"O maior número é: {Math.Max(a, b)}");
Console.WriteLine($"O menor número é: {Math.Min(a, b)}");
