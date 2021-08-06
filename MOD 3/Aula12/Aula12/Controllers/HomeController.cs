using Aula12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Aula12.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Supervisor f1 = new Supervisor("Josef") { Salario = 10000 };
            Enfermeiro f2 = new Enfermeiro("Josefina") { Salario = 2500 };
            Funcionario f3 = new Enfermeiro("Alajosef") { Salario = 2200 };

            List<Funcionario> lista = new();
            lista.Add(f1);
            lista.Add(f2);
            lista.Add(f3);

            return Ok(lista);
            //return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
