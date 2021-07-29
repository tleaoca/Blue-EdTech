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
        
        public IActionResult Index(string id, bool ordenar=false)
        {
            remedios = getRemedios();

            ViewBag.ordenar = ordenar;
            if (ordenar)
            {
                remedios.Sort((x, y) => x.Nome.CompareTo(y.Nome));                
            }                       
            
            int? maiorQ = 0;
            string nomeRemedioMaiorQ = "";
            foreach (Remedio r in remedios)
            {
                if (r.Quantidade > maiorQ)
                {
                    maiorQ = r.Quantidade;
                    nomeRemedioMaiorQ = r.Nome;
                    ViewBag.NomeMaiorQ = nomeRemedioMaiorQ;
                }
            }
           


            return View(id == null ? remedios : remedios.FindAll(x => x.Nome.ToLower().Contains(id.ToLower())));
        }



        public List<Remedio> getRemedios()
        {
            remedios.Add(new Remedio { Id = 01, Nome = "Dipirona", Fabricante = "Medley", Quantidade = 43, Preco = 26, Validade = new DateTime(2024, 01, 12) });
            remedios.Add(new Remedio { Id = 02, Nome = "Loratadina", Fabricante = "Cimed", Quantidade = 22, Preco = 8, Validade = new DateTime(2022, 02, 21) });
            remedios.Add(new Remedio { Id = 03, Nome = "Simeticona", Fabricante = "Needs", Quantidade = 15, Preco = 13, Validade = new DateTime(2021, 03, 06) });
            remedios.Add(new Remedio { Id = 04, Nome = "Paracetamol", Fabricante = "Cimed", Quantidade = 50, Preco = 7, Validade = new DateTime(2025, 04, 10) });
            remedios.Add(new Remedio { Id = 05, Nome = "Omeprazol", Fabricante = "Medley", Quantidade = 13, Preco = 37, Validade = new DateTime(2021, 05, 04) });
            remedios.Add(new Remedio { Id = 06, Nome = "Clonazepam", Fabricante = "Medley", Quantidade = 16, Preco = 21, Validade = new DateTime(2021, 06, 28) });
            remedios.Add(new Remedio { Id = 07, Nome = "Ondansetrona", Fabricante = "Ems", Quantidade = 23, Preco = 26, Validade = new DateTime(2022, 07, 15) });
            remedios.Add(new Remedio { Id = 08, Nome = "Gliclazida", Fabricante = "Ranbaxy", Quantidade = 19, Preco = 9, Validade = new DateTime(2021, 08, 12) });
            remedios.Add(new Remedio { Id = 09, Nome = "Prometazina", Fabricante = "Teuto", Quantidade = 8, Preco = 5, Validade = new DateTime(2020, 09, 03) });
            remedios.Add(new Remedio { Id = 10, Nome = "Hidroclorotiazida", Fabricante = "Medley", Quantidade = 6, Preco = 3, Validade = new DateTime(2020, 12, 30) });
            return remedios;
        }

        public int? maiorQtd()
        {
            remedios = getRemedios();
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
            remedios = getRemedios();
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
            ViewBag.x = listaRemedios;

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

        public IActionResult Home()
        {
            List<Remedio> remedios = getRemedios();
            int? maiorQ = 0;
            string nomeRemedioMaiorQ = "";
            int? idRemedioMaiorQ = 0;
            foreach (Remedio r in remedios)
            {
                if (r.Quantidade > maiorQ)
                {
                    maiorQ = r.Quantidade;
                    nomeRemedioMaiorQ = r.Nome;
                    idRemedioMaiorQ = r.Id;
                    ViewBag.NomeMaiorQ = nomeRemedioMaiorQ;
                    ViewBag.IdMaiorQ = idRemedioMaiorQ;
                }
            }
            decimal maiorV = 0;
            string nomeRemedioMaiorV = "";
            int? idRemedioMaiorV = 0;
            foreach (Remedio r in remedios)
            {
                if (r.Preco > maiorV)
                {
                    maiorV = r.Preco;
                    nomeRemedioMaiorV = r.Nome;
                    idRemedioMaiorV = r.Id;
                    ViewBag.NomeMaiorV = nomeRemedioMaiorV;
                    ViewBag.IdMaiorV = idRemedioMaiorV;
                }
            }
            
            return View(remedios);
        }
    }
}
