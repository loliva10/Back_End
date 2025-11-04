//Arrays

string nome = "Luis";
Console.WriteLine($"Nome: {nome}");

//Cria um array tamanho 4 e preenche com vazio
string[] nomes = new string[4];

nomes[0] = "Beatriz";
nomes[1] = "Livia";
nomes[2] = "Eloysa";
nomes[3] = "Felipe Brito";

Console.WriteLine();

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine(nomes[i]);
}
