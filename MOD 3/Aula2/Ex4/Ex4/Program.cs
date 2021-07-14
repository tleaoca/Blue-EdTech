using System;

Console.WriteLine("Digite o tamanho da lista: ");
int tamanhoArray = Convert.ToInt32(Console.ReadLine());

int[] array = new int[tamanhoArray];



for (int i = 0; i <= array.Length; i++)
{
    Random num = new Random();
    if (i < array.Length)
    {        
        array[i] = num.Next(1,200);
    }
    else
    {
        Console.WriteLine("Você atingiu a quantidade máximo de números.");
        Array.Sort(array);
        foreach (int n in array) Console.WriteLine(n);
        Console.Read();
    }
}
