﻿using BlueFashionRetailer.Data;
using BlueFashionRetailer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueFashionRetailer.Services
{
    public class ProductService : IProductService
    {
        BFRContext _context;

        public ProductService(BFRContext context)
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
            try
            {
                if (!_context.Product.Any(prod => prod.Id == p.Id))
                    throw new Exception("Produto inválido");
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
