using Consultorio.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Controllers
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
            Supervisor f1 = new Supervisor("Josef") { Id = 01, Salario = 10000 };
            Enfermeiro f2 = new Enfermeiro("Josefina") { Id = 02, Salario = 5000 };
            Funcionario f3 = new Funcionario("Alajosef") { Id = 03, Salario = 2000 };

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
        
        public IActionResult Info()
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
