using Consultorio.Data;
using Consultorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio
{
    public class GerenciadorPaciente
    {
        ConsultorioContext _context;
        public GerenciadorPaciente(ConsultorioContext context)
        {
            _context = context;
        }

        public List<Paciente> all(bool ordenar = false, string busca = null)
        {
            List<Paciente> lista = _context.Paciente.ToList();

            if (ordenar)
            {
                lista = lista.OrderBy(p => p.Nome).ToList();
                return lista;
            }

            return busca != null ?
               lista.FindAll(a =>
                    a.Nome.ToLower().Contains(busca.ToLower())
                ) :
                lista;
        }
    }
}
