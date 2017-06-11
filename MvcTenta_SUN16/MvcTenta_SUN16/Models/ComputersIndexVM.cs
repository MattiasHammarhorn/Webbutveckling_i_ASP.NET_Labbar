using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTenta_SUN16.Models
{
    public class ComputersIndexVM
    {
        public int Id { get; set; }

        [Display(Name = "Fabrikat")]
        public string Manufacturer { get; set; }

        [Display(Name = "Pris")]
        public int Price { get; set; }

        public bool Functioning { get; set; }
        // public string SuccesfulCreationMessage { get; set; }
    }
}
