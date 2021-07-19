using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRpg
{
    class Jogo
    {
        Heroi heroi;
        public void Iniciar()
        {
            Console.WriteLine("Digite o nome do herói: ");
            heroi = new(Console.ReadLine());
            Menu();
        }

        void Menu()
        {
            Console.Clear();
            Info();
            Console.WriteLine("Qual monstro você deseja enfrentar?");
            Console.WriteLine("1- Orc");
            Console.WriteLine("2- Troll");
            Console.WriteLine("3- Goblin");
            Console.WriteLine("Digite 0 para sair do jogo.");

            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "orc":
                    Batalhar(new Monstro("Orc", 2*heroi.Nivel, heroi.Nivel));
                    break;
                case "2":
                case "troll":
                    Batalhar(new Monstro("Troll", 5*heroi.Nivel, 2*heroi.Nivel));
                    break;
                case "3":
                case "goblin":
                    Batalhar(new Monstro("Goblin", 10*heroi.Nivel, 4*heroi.Nivel));
                    break;
                case "0":
                    return;                
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }

            Console.WriteLine("Digite uma tecla para continuar.");
            Console.ReadKey();
            if (heroi.Vida < 0)
            {
                Console.WriteLine("Você morreu.");
                return;
            }
            else
            {
                Menu();
            }


        }

        void Batalhar(Monstro monstro)
        {
            Console.Clear();
            Info();
            Console.WriteLine($"Monstro localizado -> {monstro.Nome} - Vida: {monstro.Vida} - Ataque: {monstro.Ataque} - XP: {monstro.Xp}");
            Console.WriteLine("Deseja Atacar(1) ou Fugir(2)?");
            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "atacar":
                    monstro.Vida -= heroi.Ataque;
                    Console.WriteLine($"Você causou {heroi.Ataque} de dano no {monstro.Nome}.");
                    if(monstro.Vida > 0)
                    {
                        heroi.Vida -= monstro.Ataque;
                        Console.WriteLine($"{monstro.Nome} causou {monstro.Ataque} de dano em você.");
                    }
                    if (heroi.Vida <= 0)
                    {
                        Console.WriteLine("Você morreu."); 
                        return;
                    }                      
                    if (monstro.Vida <= 0)
                    {
                        Console.WriteLine($"Você matou o {monstro.Nome}.");
                        heroi.GanhaXp(monstro.Xp);
                        return;
                    }                        
                    break;
                case "2":
                case "fugir":
                    Console.WriteLine("Você fugiu.");
                    return;                 
            }
            Console.WriteLine("Digite uma tecla para continuar.");
            Console.ReadKey();
            Batalhar(monstro);

        }

        void Info()
        {
            Console.WriteLine($"Nome: {heroi.Nome}");
            Console.WriteLine($"Experiência: {heroi.Xp}");
            Console.WriteLine($"Nível: {heroi.Nivel}");
            Console.WriteLine($"Vida: {heroi.Vida}");
            Console.WriteLine($"Ataque: {heroi.Ataque}");
            Console.WriteLine("---------------------------");
        }
    }
}
