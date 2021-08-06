using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Models
{
    public class Enfermeiro : Funcionario
    {
        public Enfermeiro(string nome) : base (nome)
        {
            this.Nome = "Enf" + nome;
        }

        public override double Pl { get => Salario * 1.5; }
    }
}
