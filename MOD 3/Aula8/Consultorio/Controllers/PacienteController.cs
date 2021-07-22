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
        public IActionResult Index(int id)
        {
            ViewBag.pacientes = id == 0 ? getPacientes() : getPacientes().FindAll(x => x.Id == id);
            return View();
        }

        List<Paciente> getPacientes()
        {
            List<Paciente> listaPacientes = new List<Paciente>();

            listaPacientes.Add(new Paciente { Id = 1, Nome = "Thiago", Nascimento = new DateTime(1989, 07, 10) });
            listaPacientes.Add(new Paciente { Id = 2, Nome = "Catharina", Nascimento = new DateTime(1994, 07, 25) });
            listaPacientes.Add(new Paciente { Id = 1, Nome = "Caio", Nascimento = new DateTime(1992, 10, 13) });

            return listaPacientes;
        }


    }
}
