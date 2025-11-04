using ExerciciosMetodoConstrutor;

// Console.WriteLine();
// Console.WriteLine($"-- Carro --");
// Console.WriteLine();


// Console.WriteLine($"Digite a marca do carro: ");
// string Marca = Console.ReadLine();
// Console.WriteLine();

// Console.WriteLine($"Digite o modelo do carro: ");
// string Modelo = Console.ReadLine();
// Console.WriteLine();

// Console.WriteLine($"Digite o ano do carro: ");
// int Ano = int.Parse(Console.ReadLine());
// Console.WriteLine();

// Carro C1 = new Carro(Marca, Modelo, Ano);

// C1.ExibirDados();

// Console.WriteLine();
// Console.WriteLine($"-- Aluno --");
// Console.WriteLine();

// Console.WriteLine($"Digite o nome do aluno: ");
// string Nome = Console.ReadLine();
// Console.WriteLine();

// Console.WriteLine($"Digite a nota do aluno: ");
// int Nota = int.Parse(Console.ReadLine());
// Console.WriteLine();

// Aluno A1 = new Aluno(Nome, Nota);

// A1.ExibirDados();

// Console.WriteLine();
// Console.WriteLine($"-- Produto --");
// Console.WriteLine();

// Console.WriteLine($"Digite o nome do produto: ");
// string Nome = Console.ReadLine();
// Console.WriteLine();

// Console.WriteLine($"Digite o preço do produto em R$: ");
// int Preco = int.Parse(Console.ReadLine());
// Console.WriteLine();

// Console.WriteLine($"Quantidade em Estoque: ");
// int Estoque = int.Parse(Console.ReadLine());
// Console.WriteLine();

// Produto P1 = new Produto(Nome, Preco, Estoque);

// P1.ExibirDados();

// Console.WriteLine();
// Console.WriteLine($"-- Conta Bancária --");
// Console.WriteLine();

// Console.WriteLine($"Digite o nome do titular da conta: ");
// string Titular = Console.ReadLine();
// Console.WriteLine();

// Console.WriteLine($"Digite o valor inicial da conta: ");
// double Saldo = double.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine();

// ContaBancaria CB = new ContaBancaria(Titular, Saldo);

// CB.ExibirDados();

Console.WriteLine();
Console.WriteLine($"-- Média Aluno --");
Console.WriteLine();

MediaAluno A1 = new MediaAluno(6, 7, 2);

A1.Nome = "Luis";
A1.Media();

MediaAluno A2 = new MediaAluno();
A2.Nome = "Beatriz";
A2.Media();