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
        
        public IActionResult Index(string id)
        {
            //ViewBag.x = maiorQtd();
            //ViewBag.y = maiorQtdNome();
            return View(id == null ? getRemedios() : getRemedios().FindAll(x => x.Nome.ToLower().Contains(id.ToLower())));
        }



        public List<Remedio> getRemedios()
        {
            remedios.Add(new Remedio { Id = 1, Nome = "Rivotril", Fabricante = "Blabla", Quantidade = 15, Preco = 30, Validade = new DateTime(2000, 10, 20) });
            remedios.Add(new Remedio { Id = 2, Nome = "Omeprazol", Fabricante = "Blabla", Quantidade = 12, Preco = 30, Validade = new DateTime(2000, 10, 20) });
            remedios.Add(new Remedio { Id = 3, Nome = "Viagra", Fabricante = "Blabla", Quantidade = 11, Preco = 30, Validade = new DateTime(2000, 10, 20) });
            remedios.Add(new Remedio { Id = 4, Nome = "Viagra", Fabricante = "Blabla", Quantidade = 1, Preco = 30, Validade = new DateTime(2000, 10, 20) });
            remedios.Add(new Remedio { Id = 5, Nome = "Viagra", Fabricante = "Blabla", Quantidade = 13, Preco = 30, Validade = new DateTime(2000, 10, 20) });
            remedios.Add(new Remedio { Id = 6, Nome = "Viagra", Fabricante = "Blabla", Quantidade = 16, Preco = 30, Validade = new DateTime(2000, 10, 20) });
            remedios.Add(new Remedio { Id = 7, Nome = "Viagra", Fabricante = "Blabla", Quantidade = 17, Preco = 30, Validade = new DateTime(2000, 10, 20) });
            remedios.Add(new Remedio { Id = 8, Nome = "Viagra", Fabricante = "Blabla", Quantidade = 19, Preco = 30, Validade = new DateTime(2000, 10, 20) });
            remedios.Add(new Remedio { Id = 9, Nome = "Viagra", Fabricante = "Blabla", Quantidade = 8, Preco = 30, Validade = new DateTime(2000, 10, 20) });
            remedios.Add(new Remedio { Id = 10, Nome = "Viagra", Fabricante = "Blabla", Quantidade = 6, Preco = 30, Validade = new DateTime(2000, 10, 20) });
            return remedios;
        }

        public int? maiorQtd()
        {
            List<Remedio> remedios = getRemedios();
            int? maiorQ = 0;            
            foreach (Remedio r in remedios)
            {

                if (r.Quantidade > maiorQ)
                {
                    maiorQ = r.Quantidade;
                    
                }
            }
            return maiorQ;
        }

        public string maiorQtdNome()
        {
            List<Remedio> remedios = getRemedios();
            int? maiorQ = 0;
            string nomeFilmeMaiorQ = "";
            foreach (Remedio r in remedios)
            {

                if(r.Quantidade > maiorQ)
                {                    
                    nomeFilmeMaiorQ = r.Nome;
                }
            }
            return nomeFilmeMaiorQ;
        }

        
        public IActionResult Read(int? id)
        {
            Remedio remedio = getRemedios().FirstOrDefault(r => r.Id == id);
            return remedio != null ? View(remedio) : RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int? id)
        {
            List<Remedio> listaRemedios = getRemedios();
            Remedio remedio = listaRemedios.FirstOrDefault(r => r.Id == id);

            if (remedio == null)
            {
                return NotFound();
            }
            return View(remedio);            
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult ConfirmarDelete(int? id)
        {
            List<Remedio> listaRemedios = getRemedios();
            Remedio remedio = listaRemedios.FirstOrDefault(r => r.Id == id);

            listaRemedios.Remove(remedio);

            return View(nameof(Index), listaRemedios);           
        }

        public IActionResult Update(int? id)
        {
            //ViewBag.x = maiorQtd();
            //ViewBag.y = maiorQtdNome();
            Remedio remedio = getRemedios().FirstOrDefault(r => r.Id == id);
            return View(remedio);
        }

        [HttpPost]
        public IActionResult Update(Remedio rAtualizado)
        {
            List<Remedio> listaRemedios = getRemedios();
            Remedio remedioExistente = listaRemedios.FirstOrDefault(r => r.Id == rAtualizado.Id);
            if (rAtualizado == null) return RedirectToAction(nameof(Index));

            var indice = listaRemedios.IndexOf(remedioExistente);
            listaRemedios[indice] = rAtualizado;

            return View(nameof(Index), listaRemedios);
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
            return View(nameof(Index), remedios);
        }
    }
}
