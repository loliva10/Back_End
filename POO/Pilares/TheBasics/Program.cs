using Pilares;

Console.Clear();

// // --- Luis ---
// // Endereço
// Endereco enderecoLuis = new Endereco();
// enderecoLuis.Logradouro = "Rua dos Caquizeiros";
// // Pessoa com Endereço
// Pessoa Luis = new Pessoa(enderecoLuis);
// Luis.Nome = "Luis Oliva";
// Luis.Idade = 16;

// // --- Beatriz ---
// // Endereço
// Endereco enderecoBea = new Endereco();
// enderecoBea.Logradouro = "Rua Joaquim Evaristo";
// // Pessoa com Endereço
// Pessoa Beatriz = new Pessoa(enderecoBea);
// Beatriz.Nome = "Beatriz Yusmy";
// Beatriz.Idade = 18;

// // --- Livia ---
// // Endereço
// Endereco enderecoLivia = new Endereco();
// enderecoLivia.Logradouro = "Rua Rincão";
// // Pessoa com Endereço
// Pessoa Livia = new Pessoa(enderecoLivia);
// Livia.Nome = "Livia Lançonni";
// Livia.Idade = 16;

// // --- Felipe ---
// // Endereço
// Endereco enderecoFelipe = new Endereco();
// enderecoFelipe.Logradouro = "Travessa Ana Maria";
// // Pessoa com Endereço
// Pessoa Felipe = new Pessoa(enderecoFelipe);
// Felipe.Nome = "Felipe Brito";
// Felipe.Idade = 17;



// // Guardando os dados na lista
// peoples.Add(Luis); //0
// peoples.Add(Beatriz); //1
// peoples.Add(Livia); //2
// peoples.Add(Felipe); //3

// foreach (Pessoa p in peoples)
// {
//     Console.WriteLine(@$"Nome: {p.Nome}");
// }

// Endereco endLu = new Endereco();
// endLu.Logradouro = "Rua dos Caquizeiros";
// endLu.Numero = 88;
// Aluno luisOliva = new Aluno(endLu);
// luisOliva.Nome = "Luis Oliva";
// luisOliva.Curso = "Desenvolvimento de Sistemas";
// luisOliva.RA = "110622958-Sp";
// luisOliva.NotaFinal = 9.75f;

// Endereco endProfBea = new Endereco();
// endProfBea.Logradouro = "Rua Niterói";
// endProfBea.Numero = 180;
// Professor profBea = new Professor(endProfBea);
// profBea.Nome = "Beatriz Yusmy";

// Console.WriteLine($"Aluno {luisOliva.Nome} estuda na turma {luisOliva.Curso} da professora {profBea.Nome}");

// --- Moto ---
// Moto mt = new Moto();
// mt.Marca = "Yamaha";
// mt.Modelo = "Xj6";
// mt.QtdRodas = 2;

// Console.WriteLine(@$"Características da Moto:
//                     Marca: {mt.Marca}
//                     Modelo: {mt.Modelo}
//                     Quantidade de Rodas: {mt.QtdRodas}
// ");
// mt.Ligar();
// mt.Empinar();
// mt.Desligar();

// // --- Carro ---
// Carro c1 = new Carro();
// c1.Marca = "VolksWagen";
// c1.Modelo = "Golf GTI";
// c1.QtdRodas = 4;

// Console.WriteLine(@$"Características do Carro:
//                     Marca: {c1.Marca}
//                     Modelo: {c1.Modelo}
//                     Quantidade de Rodas: {c1.QtdRodas}       
// ");
// c1.AbrirPortaMala();
// c1.Ligar();
// c1.Desligar();

Aviao av1 = new Aviao();
av1.Marca = "Gol";
av1.Modelo = "Boeing 787-9";
av1.QtdRodas = 10;

Console.WriteLine(@$"Características do Avião: 
                     Companhia Aérea: {av1.Marca}
                     Modelo do Avião: {av1.Modelo}
                     Quantidade de Rodas: {av1.QtdRodas}
");
av1.Decolar();
