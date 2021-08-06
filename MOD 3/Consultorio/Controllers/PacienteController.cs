using Consultorio.Data;
using Consultorio.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Controllers
{
    public class PacienteController : Controller
    {
        GerenciadorPaciente _gerenciador;
        public PacienteController(GerenciadorPaciente gerenciador)
        {
            _gerenciador = gerenciador;
        }

        public IActionResult Index(string busca, bool ordenar = false)
        {            
            ViewBag.ordenar = ordenar;
            return View(_gerenciador.all(ordenar, busca));
            
        }

        //[HttpGet]
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Create(Paciente paciente)
        //{
        //    //List<Paciente> pacientes = getPacientes();
        //    //paciente.Id = pacientes.Count() + 1;
        //    //pacientes.Add(paciente);
        //    //ViewBag.lista = pacientes;
        //    //return View("Index",pacientes);

        //    _context.Add(paciente);
        //    _context.SaveChanges();
        //    return RedirectToAction(nameof(Index));
        //}

        //public IActionResult Read(int? id) // localhost/Paciente/Read/id?
        //{
        //    //Paciente paciente = getPacientes().FirstOrDefault(p => p.Id == id);
        //    Paciente paciente = _context.Paciente.FirstOrDefault(p => p.Id == id);
        //    return paciente != null ? 
        //        View(paciente) :
        //        RedirectToAction(nameof(Index));
        //}

        //public IActionResult Update(int? id)
        //{
        //    //Paciente paciente = getPacientes().FirstOrDefault(p => p.Id == id);
        //    Paciente paciente = _context.Paciente.FirstOrDefault(p => p.Id == id);
        //    return paciente != null ?
        //        View(paciente) :
        //        RedirectToAction(nameof(Index));
        //}
        
        //[HttpPost] 
        //public IActionResult Update(Paciente paciente)
        //{
        //    //List<Paciente> listaPacientes = getPacientes();
        //    ////p3
        //    //Paciente pacienteExistente = listaPacientes.FirstOrDefault(p => p.Id == pacienteAtualizado.Id);
        //    //if (pacienteExistente == null) return RedirectToAction(nameof(Index));


        //    //// { p1, p2, p3}
        //    //int indice = listaPacientes.IndexOf(pacienteExistente);

        //    ////listaPaciente[2] = pacienteAtualizado
        //    //listaPacientes[indice] = pacienteAtualizado;

        //    //return View(nameof(Index), listaPacientes);

        //    _context.Paciente.Update(paciente);
        //    _context.SaveChanges();
        //    return RedirectToAction(nameof(Index));
        //}

        //public IActionResult Delete(int? id)
        //{
        //    var paciente = _context.Paciente.FirstOrDefault(p => p.Id == id);
        //    if (paciente == null) return NotFound();
        //    _context.Paciente.Remove(paciente);
        //    _context.SaveChanges();
        //    return RedirectToAction(nameof(Index));
        //}

        //List<Paciente> getPacientes()
        //{
        //    List<Paciente> listaPacientes = new List<Paciente>();
        //    listaPacientes.Add(new Paciente { Id = 1, Nome = "Italo", Nascimento = new DateTime(1980,10,08), Descricao = "Paciente 1 - Italo"});
        //    listaPacientes.Add(new Paciente { Id = 2, Nome = "Eduardo", Nascimento = new DateTime(1995, 01, 25), Descricao = "Paciente 2 - Eduardo" });
        //    listaPacientes.Add(new Paciente { Id = 3, Nome = "Janio", Nascimento = new DateTime(2000, 7, 5), Descricao = "Paciente 3 - Janio" });
        //    listaPacientes.Add(new Paciente { Id = 4, Nome = "Filipe", Nascimento = new DateTime(2000, 7, 5), Descricao = "Paciente 4 - Filipe" });
        //    listaPacientes.Add(new Paciente { Id = 5, Nome = "Gabriel", Nascimento = new DateTime(2000, 7, 5), Descricao = "Paciente 5 - Gabriel" });
        //    return listaPacientes;
        //}
    }
}
