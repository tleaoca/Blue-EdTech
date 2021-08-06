using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula12.Models
{
    public class Supervisor : Funcionario
    {
        public Supervisor(string nome) : base(nome)
        {
            this.Nome = "Sup " + nome;
        }

        public override int Ferias { get => 45; }
        public override double Pl { get => Salario * 5; }
    }
}
