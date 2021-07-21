using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaDeAula.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }       
       
        public DateTime Nascimento { get; set; }
        public int Idade { get => Convert.ToInt32((DateTime.Now - Nascimento).TotalDays / 365); }



    }
}
