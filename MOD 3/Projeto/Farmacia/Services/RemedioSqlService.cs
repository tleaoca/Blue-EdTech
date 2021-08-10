using Farmacia.Data;
using Farmacia.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Farmacia.Services
{
    public class RemedioSqlService : IRemedioService
    {
        RemedioContext _context;
        public RemedioSqlService(RemedioContext context)
        {
            _context = context;
        }
        public List<Remedio> all(string id = null, bool ordenar = false, string service2 = "sql")
        {
            List<Remedio> lista = _context.Remedio.Include(p => p.Pedidos).ToList();
            if (ordenar)
            {
                lista = lista.OrderBy(p => p.Nome).ToList();
                return lista;
            }
            return id != null ?
               lista.FindAll(a =>
                    a.Nome.ToLower().Contains(id.ToLower())
                ) :
                lista;
        }
        public bool create(Remedio remedio)
        {
            try
            {
                _context.Remedio.Add(remedio);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Remedio get(int? id)
        {
            return _context.Remedio.Include(p => p.Pedidos).FirstOrDefault(x => x.Id == id);
        }
        public bool update(Remedio r)
        {
            try
            {
                _context.Remedio.Update(r);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool delete(int? id)
        {
            try
            {
                _context.Remedio.Remove(get(id));
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
