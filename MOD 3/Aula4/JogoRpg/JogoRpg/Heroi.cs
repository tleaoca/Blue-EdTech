using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRpg
{
    class Heroi
    {
        public string Nome { get; set; }
        public int Xp { get; set; }
        public int Nivel { get; set; }
        public int Vida { get; set; }
        public int AtaqueBase { get; set; }
        public int Ataque { get; set; }

        public Heroi(string nome)
        {
            Random aleatorio = new Random();
            this.AtaqueBase = aleatorio.Next(1, 11);
            this.Nome = nome;
            this.Xp = 0;
            this.Nivel = 1;
            this.Vida = 10;
            this.Ataque = AtaqueBase;
        }

        public void GanhaXp(int xp)
        {
            Xp += xp;
            int novoNivel = (Xp / 10) + 1;
            if (novoNivel > Nivel)
            {
                Console.WriteLine("Você subiu de nivel");
                Vida = Nivel * 10;
                Ataque = AtaqueBase + Nivel;
            }
            Nivel = novoNivel;
        }
    }
}
