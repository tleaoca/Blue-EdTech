using System;
using System.Linq;

Console.WriteLine("Digite o tamanho da lista: ");
int tamanhoArray = Convert.ToInt32(Console.ReadLine());

int[] array = new int[tamanhoArray];

for(int i = 0; i <= array.Length; i++)
{    
    if (i < array.Length){
        Console.WriteLine($"Digite o {i+1} número da lista: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    else
    {        
        Console.WriteLine("Você atingiu a quantidade máximo de números.");
        Console.WriteLine($"Maior número da lista: {array.Max()}");
        Console.Read();
    }
}
