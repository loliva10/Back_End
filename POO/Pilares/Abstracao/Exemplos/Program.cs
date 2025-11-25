using Exemplos;

// -- Conta Bancária --
ContaCorrente cc = new ContaCorrente();
ContaPoupanca cp = new ContaPoupanca();

cc.Depositar(10);
cp.Depositar(10);

Console.WriteLine($"Saldo Conta Corrente antes do Saque: R${cc.Saldo}");
Console.WriteLine($"Saldo Conta Poupança antes do Saque: R${cp.Saldo}");
cc.Sacar(10);
cp.Sacar(5);

Console.WriteLine();

Console.WriteLine($"Saldo Conta Corrente após o saque: R${cc.Saldo}");
Console.WriteLine($"Saldo Conta Poupança após o Saque: R${cp.Saldo}");