using System;

int numero;
Console.WriteLine("Digite o número: ");
numero = Convert.ToInt32(Console.ReadLine());

int fatorial;
fatorial = numero;

for(int i = numero - 1; i>1; i--)
{
    fatorial *= i;
}

Console.WriteLine($"Valor do fatorial: {fatorial}");
Console.Read();