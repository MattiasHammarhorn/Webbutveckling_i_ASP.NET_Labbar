using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TentaPractice.Models
{
    public class CatsCreateVM
    {
        [Required(ErrorMessage = "*Name required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*Anger required")]
        [Range(0, 10)]
        public int Anger { get; set; }

        [Required(ErrorMessage = "*Weight required")]
        public double Weight { get; set; }
    }
}
