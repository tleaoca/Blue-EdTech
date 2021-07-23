using LocadoraDeFilmes.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraDeFilmes.Controllers
{
    public class FilmeController : Controller
    {
        List<Filme> filmes = new List<Filme>();

        int teste = 0;
        
        public IActionResult Index()
        {          
            return View(getFilmes());
        }



        [HttpPost]
        public IActionResult Buscar(string id)
        {
            return View(id == null ? getFilmes() : getFilmes().FindAll(x => x.Nome == id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Filme filme)
        {
            filmes = getFilmes();            
            filme.Id = filmes.Count() + 1;
            filmes.Add(filme);
            return View("Sucesso", filmes);
        }

        List<Filme> getFilmes()
        {           
            filmes.Add(new Filme { Id = 1, Nome = "Velozes e Furiosos 1", Lancamento = new DateTime(2001, 03, 02), Duracao = new DateTime(2001, 03, 02, 1, 47, 10) });
            filmes.Add(new Filme { Id = 2, Nome = "Velozes e Furiosos 2", Lancamento = new DateTime(2003, 04, 03), Duracao = new DateTime(2003, 04, 03, 1, 47, 10) });
            filmes.Add(new Filme { Id = 3, Nome = "Velozes e Furiosos 3", Lancamento = new DateTime(2006, 05, 04), Duracao = new DateTime(2006, 05, 04, 1, 44, 10) });
            filmes.Add(new Filme { Id = 4, Nome = "Velozes e Furiosos 4", Lancamento = new DateTime(2009, 06, 05), Duracao = new DateTime(2009, 06, 05, 1, 57, 10) });
            filmes.Add(new Filme { Id = 5, Nome = "Velozes e Furiosos 5", Lancamento = new DateTime(2011, 07, 06), Duracao = new DateTime(2011, 07, 06, 2, 10, 10) });
            filmes.Add(new Filme { Id = 6, Nome = "Velozes e Furiosos 6", Lancamento = new DateTime(2013, 08, 07), Duracao = new DateTime(2013, 08, 07, 2, 04, 10) });
            filmes.Add(new Filme { Id = 7, Nome = "Velozes e Furiosos 7", Lancamento = new DateTime(2015, 09, 08), Duracao = new DateTime(2015, 09, 08, 1, 40, 10) });
            filmes.Add(new Filme { Id = 8, Nome = "Velozes e Furiosos 8", Lancamento = new DateTime(2017, 10, 09), Duracao = new DateTime(2017, 10, 09, 1, 52, 10) });
            filmes.Add(new Filme { Id = 9, Nome = "Velozes e Furiosos: Hobbs & Shawn", Lancamento = new DateTime(2019, 01, 10), Duracao = new DateTime(2019, 01, 10, 2, 20, 10) });
            filmes.Add(new Filme { Id = 10, Nome = "8 Mile", Lancamento = new DateTime(2001,12,20), Duracao = new DateTime(2001, 12, 20, 1, 58, 10) });

            return filmes;
        }


    }
}
