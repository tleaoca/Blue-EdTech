using Farmacia.Models;
using Farmacia.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Farmacia.Controllers
{
    public class PedidoController : Controller
    {
        IPedidoService service;
        IRemedioService remedioService;
        public PedidoController(IPedidoService service, IRemedioService remedioService)
        {            
            this.service = service;
            this.remedioService = remedioService;
        }            
        
        public IActionResult Index()
        {            
            return View(service.all());
        }        

        public IActionResult Read(int? id)
        {
            Pedido pedido = service.get(id);
            return pedido != null ?
                View(pedido) :
                NotFound();            
        }

        public IActionResult Delete(int? id)
        {
            Pedido pedido = service.get(id);
            return pedido != null ?
                View(pedido) :
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
            var remedios = remedioService.all();
            ViewBag.listaRemedios = new SelectList(remedios, "Id", "Nome");
            Pedido pedido = service.get(id);
            return pedido != null ?
                View(pedido) :
                NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]        
        public IActionResult Update(Pedido pedido)
        {
           

            if (!ModelState.IsValid) return View(pedido);
            
            if(service.update(pedido)) 
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(pedido);
            }            
        }

        [HttpGet]
        public IActionResult Create()
        {
            var remedios = remedioService.all();
            ViewBag.listaRemedios = new SelectList(remedios, "Id", "Nome");
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Create(Pedido pedido)
        {
            var remedios = remedioService.all();
            ViewBag.listaRemedios = new SelectList(remedios, "Id", "Nome");

            if (!ModelState.IsValid) return View(pedido);

            
            if (service.create(pedido))            
                return RedirectToAction(nameof(Index));
            else
            {
                return View(pedido);
            }                               
        }        
    }
}
