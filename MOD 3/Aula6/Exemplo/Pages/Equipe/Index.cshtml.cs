using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
 

namespace Exemplo.Pages.Equipe
{
    public class IndexModel : PageModel
    {
        public List<Models.Equipe> equipe = new List<Models.Equipe>();
        public void OnGet()
        {
            carregarEquipes();            
        }

        void carregarEquipes()
        {
            equipe.Add(new Models.Equipe { Nome = "Náutico", Cor = "Alvirubro", Titulos = 23, Url = "https://logodetimes.com/times/nautico/logo-nautico-1024.png" });
            equipe.Add(new Models.Equipe { Nome = "Sport", Cor = "Rubronegro", Titulos = 42, Url = "https://sportrecife.com.br/wp-content/uploads/2019/04/brasao_2000.png" });
            equipe.Add(new Models.Equipe { Nome = "Santa Cruz", Cor = "Tricolor", Titulos = 29, Url = "http://www.santacruzpe.com.br/wp-content/uploads/2017/03/escudo-santa-cruz2_0_0_0.jpg" });
        }
    }
}
