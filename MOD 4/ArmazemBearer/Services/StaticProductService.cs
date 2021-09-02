using Armazem.Data;
using Armazem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Armazem.Services
{
    public class StaticProductService : IProductService
    {              
        public List<Product> All()
        {
            List<Product> produtos = new List<Product>();

            produtos.Add(new Product() { Id = 1, Name = "Compensado", Description = "Madeira de reflorestamento." });
            produtos.Add(new Product() { Id = 2, Name = "Tábua pinus", Description = "Madeira de reflorestamento." });

            return produtos;
        }
        public bool Create(Product p)
        {
            return false;
        }
        public bool Delete(int? id)
        {
            return false;
        }
        public Product Get(int? id)
        {
            return null;
        }

        public List<Product> ProductsByUserRole(string role)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product p)
        {
            return false;
        }
    }
}
