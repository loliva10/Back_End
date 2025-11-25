using Encapsulamento;

// float dinheiro = 200;

// ContaBancaria contaLuis = new ContaBancaria();
// ContaBancaria contaBea = new ContaBancaria(dinheiro);

// contaLuis.Depositar(dinheiro);
// contaBea.Depositar(dinheiro);

// Console.WriteLine($"Saldo de Luis: R${contaLuis.GetSaldo()}");
// Console.WriteLine($"Saldo de Bea: R${contaBea.GetSaldo()}");

// contaLuis.Sacar(107);
// contaBea.Sacar(43);

// Console.WriteLine($"Novo saldo de Luis: R${contaLuis.GetSaldo()}");
// Console.WriteLine($"Novo saldo de Bea: R${contaBea.GetSaldo()}");


// -- Exercício Carro --
Carro c = new Carro();

c.DefinirMarca("Koenigsegg");
c.DefinirModelo("Agera");

c.Acelerar(110);
c.Frear(20);
c.Acelerar(30);
c.Frear(67);

Console.WriteLine(@$"Características do Carro:
    Marca: {c.ObterMarca()}
    Modelo: {c.ObterModelo()}
    Velocidade Atual: {c.ObterVelocidade()} km/h
    ");