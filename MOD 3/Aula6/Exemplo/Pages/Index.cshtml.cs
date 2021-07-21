using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<string> times = new List<string>();  

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void CriarTime()
        {
            times.Add("Náutico");
            times.Add("Santa Cruz");
            times.Add("Sport");
        }

        public void OnGet()
        {
            CriarTime();
        }
    }
}
