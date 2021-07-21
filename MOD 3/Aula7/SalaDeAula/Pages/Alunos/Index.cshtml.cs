using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SalaDeAula.Pages.Alunos
{
    public class IndexModel : PageModel
    {
        public List<Models.Aluno> listaAlunos = new List<Models.Aluno>();

        DateTime dataAgora = DateTime.Now;
        
        
        public void OnGet()
        {
            CarregarAlunos();
        }
        void CarregarAlunos()
        {
            listaAlunos.Add(new Models.Aluno { Id = 1, Nascimento = new DateTime(1989, 7, 10), Nome = "Thiago Leão" });
            listaAlunos.Add(new Models.Aluno { Id = 2, Nascimento = new DateTime(1987, 12, 27), Nome = "Alfredo Júnior" });
            listaAlunos.Add(new Models.Aluno { Id = 3, Nascimento = new DateTime(1991, 10, 13), Nome = "Caio Cézar" });
        }       

    }
}
