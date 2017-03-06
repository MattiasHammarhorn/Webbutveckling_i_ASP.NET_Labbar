using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GroupAssignment_5.Models
{
    public class CarsCreateVM
    {
        [Display(Name = "Make")]
        [Required(ErrorMessage = "*Name required")]
        public string Brand { get; set; }

        [Display(Name = "Number of doors")]
        [Required(ErrorMessage = "*Number of doors required")]
        [Range(3, 5, ErrorMessage = "*Number of doors must be between 3 and 5")]
        public int Doors { get; set; }

        [Display(Name = "Top Speed")]
        [Required(ErrorMessage = "*Speed measure required")]
        [Range(0, 300, ErrorMessage = "*Top speed must be between 0 and 300")]
        public int TopSpeed { get; set; }
    }
}
