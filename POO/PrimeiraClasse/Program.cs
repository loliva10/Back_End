// //Imports das classes externas
// using PrimeiraClasse;

// string nome = "Luis Oliva";

// //Cria um objeto do tipo Hello
// Hello cumprimento = new Hello();
// //Acessa a propriedade TextoHello e adiciona um texto
// cumprimento.TextoHello = "Olá usuário";
// //Acesse o método SaldarUsuario que imprime um texto
// cumprimento.SaldarUsuario();
// cumprimento.SaldarComNome("Luis Oliva");

// using PrimeiraClasse;

// Carro c1 = new Carro();
// c1.marca = "Lamborghini";
// c1.modelo = "Urus";
// c1.cor = "Roxa";
// c1.qtdPortas = 4;
// c1.qtdRodas = 4;
// c1.Ligar();
// c1.Acelerar();
// c1.Frear();
// c1.Desligar();

// Carro c2 = new Carro();
// c2.marca = "Chevrolet";
// c2.modelo = "Camaro";
// c2.cor = "Amarelo";
// c2.qtdPortas = 2;
// c2.qtdRodas = 4;

// Console.WriteLine($"Ligando o {c2.modelo}");
// Console.WriteLine($"Acelerando o {c2.modelo}");
// Console.WriteLine($"Freando o {c2.modelo}");
// Console.WriteLine($"Desligando o {c2.modelo}");

// Console.WriteLine();
// Console.WriteLine($"Características: ");
// Console.WriteLine();

// Console.WriteLine($"------ {c1.marca} ------");
// Console.WriteLine($"Carro: {c1.marca}");
// Console.WriteLine($"Modeloo: {c1.modelo}");
// Console.WriteLine($"Cor: {c1.cor}");
// Console.WriteLine($"Quantidade de Portas: {c1.qtdPortas}");
// Console.WriteLine();
// Console.WriteLine($"---");
// Console.WriteLine();

// Console.WriteLine($"------ {c2.marca} ------");
// Console.WriteLine($"Carro: {c2.marca}");
// Console.WriteLine($"Modelo: {c2.modelo}");
// Console.WriteLine($"Cor: {c2.cor}");
// Console.WriteLine($"Quantidade de Portas: {c2.qtdPortas}");
// Console.WriteLine();
// Console.WriteLine($"---");
// Console.WriteLine();

// using PrimeiraClasse;

// Moto m1 = new Moto();
// m1.Marca = "Bmw";
// m1.Modelo = "R1250 GS";
// m1.Cor = "Preta/Dourada";
// m1.qtdRodas = 2;
// m1.Ligar();
// m1.Acelerar();
// m1.Frear();
// m1.Desligar();

// Console.WriteLine();
// Console.WriteLine($"-- Características: --");
// Console.WriteLine();

// Console.WriteLine($"------ {m1.Marca} ------");
// Console.WriteLine($"Moto: {m1.Marca}");
// Console.WriteLine($"Modelo: {m1.Modelo}");
// Console.WriteLine($"Cor: {m1.Cor}");
// Console.WriteLine($"Quantidade de Rodas: {m1.qtdRodas}");
// Console.WriteLine();
// Console.WriteLine($"---");
// Console.WriteLine();

using PrimeiraClasse;
Console.WriteLine($"-- Digite as informações solicitadas! --");
Console.WriteLine();

Garrafa g1 = new Garrafa();
Console.WriteLine($"Digite a marca da garrafa: ");
g1.Marca = Console.ReadLine();

Console.WriteLine($"Digite a capacidade da garrafa (ex: 2 L/1,5 L): ");
g1.Capacidade = Console.ReadLine();

Console.WriteLine($"Digite a cor da garrafa: ");
g1.Cor = Console.ReadLine();

Console.WriteLine($"Digite o tamanho da garrafa (ex: Grande/Média/Pequena): ");
g1.Tamanho =  Console.ReadLine();


Console.WriteLine();
Console.WriteLine($"-- Características: --");
Console.WriteLine();

Console.WriteLine($"Marca: {g1.Marca}");
Console.WriteLine($"Capacidade: {g1.Capacidade}");
Console.WriteLine($"Cor: {g1.Cor}");
Console.WriteLine($"Tamanho: {g1.Tamanho}");
Console.WriteLine();
Console.WriteLine($"---");
Console.WriteLine();