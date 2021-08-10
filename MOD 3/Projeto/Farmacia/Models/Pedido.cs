using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Farmacia.Models
{
    public class Pedido
    {
        [Display(Name = "#")]
        public int Id { get; set; }
        public string Cliente { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Data do pedido")]
        public DateTime? dataPedido { get; set; }
        public string Observacao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Remédio")]
        public int? remedioId { get; set; }
        public Remedio remedio { get; set; }
    }
}
