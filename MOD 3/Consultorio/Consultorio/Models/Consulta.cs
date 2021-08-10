using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Models
{
    public class Consulta
    {
        [Display(Name = "#")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Data - Hora")]
        public DateTime? dataHora { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Paciente")]
        public int? pacienteId { get; set; }
        public Paciente paciente { get; set; }
    }
}
