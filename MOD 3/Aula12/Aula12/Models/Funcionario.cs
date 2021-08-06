using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula12.Models
{
    public abstract class Funcionario
    {
        public Funcionario(string nome)
        {
            this.Nome = nome;
        }

        
        public string Nome { get; set; }
        public double Salario { get; set; }
        public virtual double Pl { get => Salario * 2; }
        public virtual int Ferias { get => 30; }
    }
}
