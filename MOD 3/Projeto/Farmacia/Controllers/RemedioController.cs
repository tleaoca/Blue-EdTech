using Farmacia.Models;
using Farmacia.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Farmacia.Controllers
{
    public class RemedioController : Controller
    {
        IRemedioService staticService, SqlService, BothService, service;
        public RemedioController(RemedioStaticService staticService, RemedioSqlService SqlService, RemedioBothService BothService)
        {
            this.staticService = staticService;
            this.SqlService = SqlService;
            this.BothService = BothService;
            service = SqlService;
        }            
        
        public IActionResult Index(string id, bool ordenar=false, string service2 = "sql")
        {
            SelectService(service2);
            ViewBag.ordenar = ordenar;
            ViewBag.service = service2;
            List<Remedio> remedios = service.all(id,ordenar,service2);
            return View("Index", remedios);
        }

        private void SelectService(string service2 = "sql")
        {
            switch (service2)
            {
                case "static":
                    this.service = this.staticService;
                    break;
                case "both":
                    this.service = this.BothService;
                    break;
                default:
                    this.service = this.SqlService;
                    break;
            }
        }

        public IActionResult Read(int? id)
        {
            Remedio remedio = service.get(id);
            return remedio != null ?
                View(remedio) :
                NotFound();            
        }

        public IActionResult Delete(int? id)
        {
            Remedio remedio = service.get(id);
            return remedio != null ?
                View(remedio) :
                NotFound();
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult ConfirmarDelete(int? id)
        {
            if (service.delete(id))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Update(int? id)
        {
            Remedio remedio = service.get(id);
            return remedio != null ?
                View(remedio) :
                NotFound();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Update(Remedio remedio)
        {
            if (!ModelState.IsValid) return View(remedio);
            ViewBag.msgUpdate = true;
            if (service.update(remedio)) //// PacienteStaticService.Create(paciente)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(remedio);
            }            
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Create(Remedio remedio)
        {
            if (!ModelState.IsValid) return View(remedio);
            ViewBag.create = true;
            return service.create(remedio) ?
                RedirectToAction(nameof(Index)) :
                View(remedio);
        }

        public IActionResult Home()
        {
            List<Remedio> remedios = service.all();
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
            decimal? maiorV = 0;
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
            int qRemedioV = 0;
            foreach (Remedio r in remedios)
            {
                if (r.Validade < DateTime.Now)
                {
                    qRemedioV += 1;
                    ViewBag.qRemedioV = qRemedioV;
                }
            }
            return View(remedios);
        }

        public IActionResult Sobre()
        {
            return View();
        }
    }
}
