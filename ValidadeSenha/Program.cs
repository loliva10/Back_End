﻿//Escreva um programa que verifique a validade de uma senha     
//fornecida pelo usuário. A senha válida é o número 1234. Devem     
//ser impressas as seguintes mensagens:     
//ACESSO PERMITIDO caso a senha seja válida.     
//ACESSO NEGADO caso a senha seja inválida


int n = 0, contador = 0;

Console.WriteLine("Informe o numero de repetiçoes:");
n = int.Parse(Console.ReadLine());

while (contador < n)
{
    int senha;
    Console.WriteLine("Informe a senha:");
    senha = int.Parse(Console.ReadLine());

    if (senha == 2121)
        Console.WriteLine("ACESSO PERMITIDO");
    else
        Console.WriteLine("ACESSO NEGADO");

    contador++;
}