//Faça uma alteração no programa acima do menu para que ele funcione em loop. Pra isso utilize o laço do while do c#.

int opcao;
do
{
    Console.WriteLine("\n1) Opçao 1");
    Console.WriteLine("2) Opçao 2");
    Console.WriteLine("3) Opçao 3");
    Console.WriteLine("0) Sair");
    Console.Write("Escolha uma opçao ");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Você escolheu a opçao 1");
            break;
        case 2:
            Console.WriteLine("Você escolheu a opçao 2");
            break;
        case 3:
            Console.WriteLine("Você escolheu a opçao 3");
            break;
        case 0:
            Console.WriteLine("Saindo");
            break;
        default:
            Console.WriteLine("Opçao inválida");
            break;
    }

} while (opcao != 0);
