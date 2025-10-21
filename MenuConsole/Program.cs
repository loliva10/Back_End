//Crie um menu de console igual ao exibido abaixo, utilizando a estrutra switch do c#:
//-------------------------------------------------------
//        Bem Vindo, Usuário
//-------------------------------------------------------
//Escolha uma opção no menu abaixo:
//   1) Opção 1
//   2) Opção 2
//   3) Opção 3
//   0) Sair

Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("                  Bem Vindo, Usuário                   ");
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine();
Console.WriteLine("Escolha uma opçao no menu abaixo:");
Console.WriteLine();
Console.WriteLine("   1) Opçao 1");
Console.WriteLine("   2) Opçao 2");
Console.WriteLine("   3) Opçao 3");
Console.WriteLine("   0) Sair");
Console.WriteLine();
Console.Write("Digite o número da opçao ");

int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        Console.WriteLine("Você escolheu a opçao 1.");
        break;
    case 2:
        Console.WriteLine("Você escolheu a opçao 2.");
        break;
    case 3:
        Console.WriteLine("Você escolheu a opçao 3.");
        break;
    case 0:
        Console.WriteLine("Saindo");
        break;
    default:
        Console.WriteLine("Opçao inválida!");
        break;
}