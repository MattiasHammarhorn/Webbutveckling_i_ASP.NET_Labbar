using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Band
    {
        public int Id { get; set; }

        [Display(Name="Band name")]
        [Required(ErrorMessage = "Enter a band name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter a description")]
        public string Description { get; set; }
    }
}
