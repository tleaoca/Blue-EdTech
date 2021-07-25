using Farmacia.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Farmacia.Controllers
{
    public class RemedioController : Controller
    {
        List<Remedio> remedios = new List<Remedio>();
        
        public IActionResult Index()
        {
            ViewBag.x = maiorQtd();
            return View(getRemedios());
        }

        public List<Remedio> getRemedios()
        {
            remedios.Add(new Remedio { Id = 1, Nome = "Rivotril", Fabricante = "Blabla", Quantidade = 15, Preco = 30, Validade = new DateTime(2000, 10, 20) });
            remedios.Add(new Remedio { Id = 1, Nome = "Omeprazol", Fabricante = "Blabla", Quantidade = 12, Preco = 30, Validade = new DateTime(2000, 10, 20) });
            remedios.Add(new Remedio { Id = 1, Nome = "Viagra", Fabricante = "Blabla", Quantidade = 11, Preco = 30, Validade = new DateTime(2000, 10, 20) });
            return remedios;
        }

        public int maiorQtd()
        {
            int maiorQ = 0;
            foreach (Remedio r in remedios)
            {

                if(r.Quantidade > maiorQ)
                {
                    maiorQ = r.Quantidade;
                }
            }
            return maiorQ;
        }

        [HttpPost]
        public IActionResult Buscar(string id)
        {
            return View(id == null ? getRemedios() : getRemedios().FindAll(x => x.Nome.ToLower() == id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Remedio remedio)
        {
            remedios = getRemedios();
            remedio.Id = remedios.Max(r => r.Id) + 1;
            remedios.Add(remedio);
            return View("Index", remedios);
        }
    }
}
