using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaDeAula.Pages
{
    public class IndexModel : PageModel
    {        
        public Random rdm = new Random();
        public int numero;

        

        public void OnGet()
        {
            numero = rdm.Next(1,101);
            
        }

        
    }
}
