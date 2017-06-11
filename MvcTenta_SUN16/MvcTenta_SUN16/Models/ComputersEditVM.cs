using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTenta_SUN16.Models
{
    public class ComputersEditVM
    {
        public int Id { get; set; }

        [Display(Name = "Fabrikat")]
        [Required(ErrorMessage = "*Fabrikat ej ingenfyllt")]
        public string Manufacturer { get; set; }

        [Display(Name = "Pris")]
        [Required(ErrorMessage = "*Pris ej ingenfyllt")]
        [Range(1, 30000, ErrorMessage = "Priset får ej vara lägre än 1 eller större än 30000")]
        public int Price { get; set; }
    }
}
