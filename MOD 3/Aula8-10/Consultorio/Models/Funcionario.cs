using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Models
{
    public class Funcionario
    {
        public Funcionario(string nome)
        {
            this.Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public virtual double Pl { get => Salario * 2; }
        public virtual int Ferias { get => 30; }
    }
}
