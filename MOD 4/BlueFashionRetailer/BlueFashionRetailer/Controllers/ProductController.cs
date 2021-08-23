using BlueFashionRetailer.API;
using BlueFashionRetailer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueFashionRetailer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        List<Product> All()
        {
            List<Product> lista = new List<Product>();
            lista.Add(new Product() {Id = 1, Name = "Camisa Regata", Price = 30, Description = "Descrição" });
            lista.Add(new Product() {Id = 2, Name = "Camisa Regata", Price = 60, Description = "Descrição" });
            lista.Add(new Product() {Id = 3, Name = "Camisa Regata", Price = 70, Description = "Descrição" });
            lista.Add(new Product() {Id = 4, Name = "Camisa Regata", Price = 80, Description = "Descrição" });
            lista.Add(new Product() {Id = 5, Name = "Camisa Regata", Price = 90, Description = "Descrição" });

            return lista;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(new APIResponse<List<Product>>() { Results = All() });
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult Index(int? id)
        {
            Product produtoExistente = All().Find(p => p.Id == id);
            var response = new APIResponse<Product>();
            if (produtoExistente == null)
            {
                response.Error = "Não foi encontrado o produto informado";
                return NotFound(response);
            }
            else
            {
                response.Results = produtoExistente;
                return Ok(response);
            }
        }
        [HttpPost]
        public IActionResult Create([FromBody] Product prod)
        {
            List<Product> produtos = All();
            prod.Id = produtos.Max(p => p.Id) + 1;
            Product produtoExistente = All().Find(p => p.Name == prod.Name);

            var response = new APIResponse<Product>();
            if (produtoExistente == null)
            {
                response.Results = prod;
                return Ok(response);
            }
            else
            {
                response.Error = "Já existe um produto com o nome informado.";
                return NotFound(response);
            }
        }
        [HttpPut]
        public IActionResult Update([FromBody] Product prod)
        {
            List<Product> produtos = All();            
            Product produtoExistente = All().Find(p => p.Id == prod.Id);

            var response = new APIResponse<Product>();
            if (produtoExistente == null)
            {
                response.Error = "Não foi encontrado o produto informado.";
                return NotFound(response);
                
            }
            else
            {
                response.Results = prod;
                return Ok(response);
            }
        }
    }
}
