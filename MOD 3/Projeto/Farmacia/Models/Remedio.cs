using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Farmacia.Models
{
    public class Remedio
    {        
        [Display(Name = "#")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe um nome para o remédio.")]
        public string Nome { get; set; }
        public string Fabricante { get; set; }

        [Required(ErrorMessage = "Informe uma quantidade.")]
        public int? Quantidade { get; set; }

        [Required(ErrorMessage = "Informe uma quantidade.")] //aparece outra msg de erro(mesmo sem ter essa linha no model), talvez pq seja decimal?
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Validade { get; set; }   
    }
}
