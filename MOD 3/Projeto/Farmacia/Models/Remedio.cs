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

        public string Nome { get; set; }
        public string Fabricante { get; set; }
        public int Quantidade { get; set; }

        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [DataType(DataType.Date)]
        public DateTime Validade { get; set; }
    }
}
