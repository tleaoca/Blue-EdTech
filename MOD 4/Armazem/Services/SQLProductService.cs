using Armazem.Data;
using Armazem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Armazem.Services
{
    public class SQLProductService : IProductService
    {
        MAContext _context;
        public SQLProductService(MAContext context)
        {
            _context = context; 
        }
        public List<Product> All()
        {
            return _context.Product.ToList();
        }
        public bool Create(Product p)
        {
            try
            {
                _context.Add(p);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(int? id)
        {
            if (!_context.Product.Any(p => p.Id == id))
                return false;

            try
            {
                _context.Remove(this.Get(id));
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Product Get(int? id)
        {
            return _context.Product.FirstOrDefault(p => p.Id == id);
        }
        public bool Update(Product p)
        {
            if (!_context.Product.Any(prod => prod.Id == p.Id))
                return false;
            try
            {
                
                _context.Update(p);
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
