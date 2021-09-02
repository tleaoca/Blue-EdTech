using Armazem.Models;
using System.Collections.Generic;

namespace Armazem.Services
{
    public interface IProductService
    {
        List<Product> All();
        Product Get(int? id);
        bool Create(Product p);
        bool Update(Product p);
        bool Delete(int? id);
        List<Product> ProductsByUserRole(string role);
    }
}
