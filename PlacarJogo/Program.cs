//Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol 
//(os gols de cada time) e informa se o resultado foi um empate, 
//se a vitória foi do primeiro time ou do segundo time.

int n = 0, contador = 0;

Console.WriteLine("Informe o numero de repetiçoes");
n = int.Parse(Console.ReadLine());

while (contador < n)
{
    int gols1, gols2;

    Console.WriteLine("Informe os gols do time 1");
    gols1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe os gols do time 2");
    gols2 = int.Parse(Console.ReadLine());

    if (gols1 == gols2)
    {
        Console.WriteLine("A partida acabou empatada");
    }
    else if (gols1 > gols2)
    {
        Console.WriteLine("A partida acabou com a vitoria do time 1");
    }
    else
    {

        Console.WriteLine("A partida acabou com a vitoria do time 2");
    }

    contador++;
}
