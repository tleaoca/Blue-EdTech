using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeladAvançado
{
    public class SistemaProf
    {
        public void Menu()
        {
            Console.WriteLine("Sistema de controle para professores.");
            Console.WriteLine("1- Cadastrar turma");
            Console.WriteLine("2- Cadastrar aluno");
            Console.WriteLine("3- Visualizar lista de alunos");
            Console.WriteLine("4- Cadastrar nota");
            Console.WriteLine("5- Visualizar notas");
            Console.WriteLine("6- Adicionar falta");
            Console.WriteLine("7- Visualizar tudo");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    CadastrarTurma();
                    break;
                case "2":
                    Console.WriteLine("a");
                    break;
                case "3":
                    Console.WriteLine("a");
                    break;
                case "4":
                    Console.WriteLine("a");
                    break;
                case "5":
                    Console.WriteLine("a");
                    break;
                case "6":
                    Console.WriteLine("a");
                    break;
                case "7":
                    Console.WriteLine("a");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        public void CadastrarTurma()
        {
            Turma turma = new Turma();
            Console.WriteLine("Nome da turma: ");
            turma.nomeTurma = Console.ReadLine();
            Console.WriteLine("Tamanho da turma: ");
            turma.tamanhoTurma = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Turma {turma.nomeTurma}, máximo de {turma.tamanhoTurma} alunos, foi criada com sucesso.");
        }

        public void CadastrarAluno()
        {
            Turma turma = new Turma();
            for (int i = 0; i <= turma.tamanhoTurma; i++)
            {
                if (i < turma.tamanhoTurma)
                {
                    Console.WriteLine($"Nome do {i + 1} aluno: ");
                    break;
                }
            }
        }
    }
}
