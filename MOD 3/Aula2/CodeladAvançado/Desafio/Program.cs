using System;
using System.Linq;

Console.WriteLine("Nome da turma: ");
string nomeTurma = Console.ReadLine();

Console.WriteLine("Tamanho da turma: ");
int tamanhoTurma = Convert.ToInt32(Console.ReadLine());
string[] listaAlunos = new string[tamanhoTurma];
string[] notas = new string[tamanhoTurma];


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
                Console.WriteLine($"Aluno {ordem+1}: {n}");
            }
         
        }
        else break;
    }
}

for(int i = 0; i <= tamanhoTurma; i++)
{
    if (i < tamanhoTurma)
    {
        Console.WriteLine($"Nota de {listaAlunos[i]}: ");
        int nota = Convert.ToInt32(Console.ReadLine());
        if (nota > 0 && nota <= 10)
        {
            notas[i] = Convert.ToString(nota);
        }
        else
        {
            Console.WriteLine("Valor inválido, nota não registrada.");
        }        
    }
    else
    {
        Console.WriteLine("Digite 0 para visualizar os alunos e notas ou qualquer outra tecla para continuar");
        string validacao = Console.ReadLine();
        if (validacao == "0")
        {
            var alunosNotas = listaAlunos.Zip(notas, (a, n) => new { Aluno = a, Nota = n });
            foreach (var an in alunosNotas)
            {                
                Console.WriteLine($"Nota de {an.Aluno}: {an.Nota}");
            }
        }
        else break;
    }
}


/* Cadastrar: 
- Nome da turma;
- Tamanho de turma;
- Printar confirmação da criação da turma (mostrando nome e qtd de alunos);
- Cadastrar alunos (respeitar numero maximo de alunos);
- Opção de visualizar alunos;
- Cadastrar notas (uma nota por aluno, nao pode ser negativa ou maior que 10);
- Opção de visualizar alunos com notas;
- Adicionar faltas;
- Opção de visualizar alunos com notas, faltas e resultado final (menos de 4 faltas e nota maior que 7);
*/
