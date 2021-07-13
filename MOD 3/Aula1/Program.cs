using System;
using System.Collections.Generic;

string nome = "Thiago";
int idade = 32;
char sexo = 'M';
double peso = 98.5;
const string familia = "Leão"; // não pode ser alterado.

Console.WriteLine($"Nome: {nome} ");
Console.WriteLine($"Idade: {idade} ");
Console.WriteLine($"Sexo: {sexo} ");
Console.WriteLine($"Peso: {peso} ");

peso = 99; // alterando valor da variável

Console.WriteLine($"Novo peso: {peso} ");


Console.WriteLine("Digite sua idade: ");
int idade2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Idade: {idade2}");
Console.WriteLine(idade2 >= 18 ? "Maior de idade" : "Menor de Idade"); // operador ternário


// Array

int[] testeArray = new int[] { 23, 312, 312, 54 };
int teste = testeArray[2];
Console.WriteLine(teste);

// Listas

List<int> testeLista = new List<int> { 1, 2, 3 };
int teste2 = testeLista[1];
Console.WriteLine(teste2);

// Switch

string cidade = "";
Console.WriteLine("Digite seu estado: ");
string uf = Console.ReadLine();

switch (uf)
{
    case "SP": cidade = "São Paulo"; break;
    case "RJ": cidade = "Rio de Janeiro"; break;
    case "BA": cidade = "Bahia"; break;
    default: cidade = "Nenhuma cidade citada"; break;
}
Console.WriteLine(cidade);


// While 

int n1 = 0;
while (n1 <= 5)
{
    Console.WriteLine($"Número = {n1}");
    n1++;
}

// Do while - vai executar a ação antes da verificação pelo menos uma vez

int n2 = 0;

do
{
    Console.WriteLine($"Número = {n2}");
    n2++;
} while (n2 <= 5);