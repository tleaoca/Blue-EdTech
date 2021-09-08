using Armazem.API;
using Armazem.Models;
using Armazem.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Security.Claims;

namespace Armazem.Controllers
{
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]    
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ApiBaseController
    {
        IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }

        /// <summary>
        /// Retorna lista de todos os produtos no banco de dados.
        /// </summary>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]        
        public IActionResult Index() => ApiOk(_service.All());

        /// <summary>
        /// Retorna produto específico do banco de dados.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Route("{id}"), HttpGet]        
        public IActionResult Index(int? id)
        {
            Product existente = _service.Get(id);
            return existente == null ?
                ApiNotFound("Produto não encontrado.") :
                ApiOk(existente);
        }

        /// <summary>
        /// Cria um novo produto no banco de dados.
        /// </summary>
        /// <param name="prod"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create([FromBody] Product prod)
        {
            prod.createdById = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            return _service.Create(prod) ?
                ApiOk("Produto criado com sucesso.") :
                ApiNotFound("Erro ao criar o produto.");
        }
            
        /// <summary>
        /// Atualiza o produto informado no banco de dados.
        /// </summary>
        /// <param name="prod"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Update([FromBody] Product prod)
        {
            prod.updatedById = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            return _service.Update(prod) ?
                ApiOk("Produto atualizado com sucesso.") :
                ApiNotFound("Erro ao atualizar o produto.");
        }
            
        /// <summary>
        /// Deleta um produto informado do banco de dados.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [AuthorizeRoles(RoleType.Admin)]
        [Route("{id}"), HttpDelete]       
        public IActionResult Delete(int? id) =>
            _service.Delete(id) ?
            ApiOk("Produto deletado com sucesso.") :
            ApiNotFound("Erro ao deletar o produto.");


        /// <summary>
        /// Seleciona um produto random do banco de dados.
        /// </summary>
        /// <returns></returns>
        [AuthorizeRoles(RoleType.Admin)]
        [Route("Random"), HttpGet]
        public IActionResult Random()
        {
            Random ale = new Random();
            List<Product> lista = _service.All();
            return ApiOk(lista[ale.Next(lista.Count())]);
        }

        /// <summary>
        /// Retorna todos os produtos criados por uma role específica
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [Route("ProductsByRole/{role?}")]
        [HttpGet]
        public IActionResult ProductsByRole(string role)
        {
            return ApiOk(_service.ProductsByUserRole(role));
        }
    }
}
