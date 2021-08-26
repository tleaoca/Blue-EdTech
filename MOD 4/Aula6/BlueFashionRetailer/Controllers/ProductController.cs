using BlueFashionRetailer.API;
using BlueFashionRetailer.Models;
using BlueFashionRetailer.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueFashionRetailer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ApiBaseController
    {
        IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Index() => ApiOk(_service.All());
        

        [Route("{id}")]
        [HttpGet]
        public IActionResult Index(int? id)
        {
            Product existente = _service.Get(id);
            return existente == null ?
                ApiNotFound("Produto não encontrado") :
                ApiOk(existente);
                
        }
        [HttpPost]
        public IActionResult Create([FromBody] Product prod) =>
            _service.Create(prod) ?
                ApiOk("Produto criado com sucesso") :
                ApiNotFound("Erro ao criar o produto");

        [HttpPut]
        public IActionResult Update([FromBody] Product prod) =>
            _service.Update(prod) ?
                ApiOk("Produto atualizado com sucesso") :
                ApiNotFound("Erro ao atualizar o produto");



        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int? id) =>
            _service.Delete(id) ?
            ApiOk("Produto deletado com sucesso") :
            ApiNotFound("Erro ao deletar o produto");
        
    }
}
