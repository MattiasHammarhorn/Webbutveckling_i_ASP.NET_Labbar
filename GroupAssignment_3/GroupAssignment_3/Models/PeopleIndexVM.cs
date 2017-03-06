using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment_3.Models
{
    public class PeopleIndexVM
    {
        public int Id { get; set; }

        [Display(Name="First name")]
        [Required(ErrorMessage = "Please write a first name")]
        public string Name { get; set; }

        [Display(Name="E-mail")]
        [Required(ErrorMessage ="Invalid email")]
        [EmailAddress(ErrorMessage = "Please write an email")]
        public string Email { get; set; }


        public bool ShowAsHighlighted { get; set; }
    }
}
