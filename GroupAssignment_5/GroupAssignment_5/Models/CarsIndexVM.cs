using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GroupAssignment_5.Models
{
    public class CarsIndexVM
    {
        [Display(Name = "Car Brand")]
        public string Brand { get; set; }

        [Display(Name = "Number of doors")]
        public int Doors { get; set; }

        [Display(Name = "Top Speed")]
        public int TopSpeed { get; set; }

        public bool ShowAsFast { get; set; }
    }
}
