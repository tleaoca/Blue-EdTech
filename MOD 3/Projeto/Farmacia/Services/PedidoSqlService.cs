using Farmacia.Data;
using Farmacia.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Farmacia.Services
{
    public class PedidoSqlService : IPedidoService
    {
        RemedioContext _context;
        public PedidoSqlService(RemedioContext context)
        {
            _context = context;
        }
        public List<Pedido> all()
        {
            return _context.Pedido.Include(p => p.remedio).ToList();
        }
        public bool create(Pedido pedido)
        {
            try
            {
                _context.Pedido.Add(pedido);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Pedido get(int? id)
        {
            return _context.Pedido.Include(p => p.remedio).FirstOrDefault(p => p.Id == id);
        }
        public bool update(Pedido p)
        {
            try
            {
                _context.Pedido.Update(p);
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
                _context.Pedido.Remove(get(id));
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
