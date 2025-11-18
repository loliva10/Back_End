using Exemplos;

// Criar uma classe ControleRemoto
// Implementar os métodos e propriedades da interface
// Cria um objeto controleTv e testa os métodos

// -- Controle --
ControleRemoto controleTv = new ControleRemoto();

Console.WriteLine();
controleTv.Ligar();
controleTv.AumentarVolume();
controleTv.DiminuirVolume();
controleTv.Desligar();
Console.WriteLine();

Console.WriteLine($"Volume final da Tv: {controleTv.NivelVolume}");
Console.WriteLine();
