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
        public IActionResult Index(int? id)
        {
            //ViewBag.pacientes = id == null ? getPacientes() : getPacientes().FindAll(x => x.Id == id);
            return View(id == null ? getPacientes() : getPacientes().FindAll(x => x.Id == id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Paciente paciente)
        {
            List<Paciente> pacientes = getPacientes();
            paciente.Id = pacientes.Count() + 1;
            pacientes.Add(paciente);
            //ViewBag.pacientes = pacientes;
            return View("Index",pacientes);
        }

        List<Paciente> getPacientes()
        {
            List<Paciente> listaPacientes = new List<Paciente>();

            listaPacientes.Add(new Paciente { Id = 1, Nome = "Thiago", Nascimento = new DateTime(1989, 07, 10) });
            listaPacientes.Add(new Paciente { Id = 2, Nome = "Catharina", Nascimento = new DateTime(1994, 07, 25) });
            listaPacientes.Add(new Paciente { Id = 3, Nome = "Caio", Nascimento = new DateTime(1992, 10, 13) });

            return listaPacientes;
        }


    }
}
