using Heranca;

// -- Animais e Sons --
// Animais cachorro = new Cachorro();
// Animais gato = new Gato();

// cachorro.FazerSom();
// gato.FazerSom();

// -- Funcionários de uma Empresa --
// Funcionarios f1 = new Funcionarios("Beatriz", 3785.91);
// Gerente g1 = new Gerente("Luis", 5247.60, 1205.02);

// Console.WriteLine($"Funcionário: {f1.Nome}, possui um salário de: R${f1.CalcularSalario():F2}");
// Console.WriteLine($"Gerente: {g1.Nome}, possui um salário de: R${g1.CalcularSalario():F2}");

// -- Veículos --
// Carro c1 = new Carro("VolksWagen", "Golf GTI", 4);
// Moto m1 = new Moto("BMW", "F900", "LS2 RoboCop Preto");

// Console.WriteLine("-- Características dos Veículos --\n"); //\n pula uma linha no console
// c1.MostrarInfo();
// m1.MostrarInfo();

// -- Escola --
// Aluno a1 = new Aluno("Luis Oliva", 20, "Desenvolvimento de Sistmeas");
// Professor p1 = new Professor("Beatriz Yusmy", 22, "IA-900");

// Console.WriteLine($"-- Características da Escola -- \n");
// a1.MostrarInfo();
// p1.MostrarInfo();

// -- Sistema Bancário --
ContaPoupanca conta = new ContaPoupanca(1234);

Console.WriteLine($"-- Características da Conta -- \n");

conta.Depositar(1000);
Console.WriteLine($"Saldo antes do rendimento: R${conta.Saldo:F2} \n");

conta.CalcularRendimento();
Console.WriteLine($"Saldo depois rendimento: R${conta.Saldo:F2} \n");
