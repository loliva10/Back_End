//altere o exercício anterior para que cada opção escolhida pelo usuário seja respondida 
//por uma função, ou seja, cada opção deve dar um Console.WriteLine() da opção escolhida.

int opcao;
do
{
    Console.WriteLine("\n1) Opçao 1");
    Console.WriteLine("2) Opçao 2");
    Console.WriteLine("3) Opçao 3");
    Console.WriteLine("0) Sair");
    Console.Write("Escolha uma opçao");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Executando opçao 1");
            break;
        case 2:
            Console.WriteLine("Executando opçao 2");
            break;
        case 3:
            Console.WriteLine("Executando opçao 3");
            break;
        case 0:
            Console.WriteLine("Saindo");
            break;
        default:
            Console.WriteLine("Opçao inválida!");
            break;
    }

} while (opcao != 0);
