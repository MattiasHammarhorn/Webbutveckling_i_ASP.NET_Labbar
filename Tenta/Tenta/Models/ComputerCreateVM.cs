using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tenta.Models
{
    public class ComputerCreateVM
    {
        [Display(Name = "Fabrikat")]
        [Required(ErrorMessage = "Måste ha fabrikat.")]
        public string Manufacturer { get; set; }

        [Display(Name = "Pris")]
        [Required(ErrorMessage = "Måste ha ett pris.")]
        [Range(1, 30000, ErrorMessage = "Måste vara mellan 1 och 30 000.")]
        public int Price { get; set; }
    }
}
