using System;

 
Console.WriteLine("Nome da turma: ");
string nomeTurma = Console.ReadLine();

Console.WriteLine("Tamanho da turma: ");
int tamanhoTurma = Convert.ToInt32(Console.ReadLine());
string[] listaAlunos = new string[tamanhoTurma];

Console.WriteLine($"Turma {nomeTurma}, máximo de {tamanhoTurma} alunos, foi criada com sucesso.");

for(int i = 0; i <= tamanhoTurma; i++)
{
    if (i < tamanhoTurma)
    {
        Console.WriteLine($"Nome do {i + 1} aluno: ");
        listaAlunos[i] = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Digite 0 para visualizar os alunos ou qualquer outra tecla para encerrar");
        string validacao = Console.ReadLine();
        if (validacao == "0")
        {
            foreach(string n in listaAlunos)
            {
                var ordem = Array.FindIndex(listaAlunos, row => row.Contains(n));
                Console.WriteLine($"Aluno {ordem}: {n+1}");
            }
         
        }
        else break;
    }
}