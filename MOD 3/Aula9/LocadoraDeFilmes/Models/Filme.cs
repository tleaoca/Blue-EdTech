using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraDeFilmes.Models
{
    public class Filme
    {
        [Display(Name = "#")]
        public int Id { get; set; }

        [Display(Name = "Nome do Filme")]
        public string Nome { get; set; }

        public string Sinopse { get; set; }

        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime Lancamento { get; set; }

        [Display(Name = "Duração")]
        [DataType(DataType.Time)]
        public DateTime Duracao { get; set; }       
    }

}
