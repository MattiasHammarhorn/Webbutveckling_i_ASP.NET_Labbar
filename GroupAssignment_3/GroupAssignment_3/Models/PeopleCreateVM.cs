using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment_3.Models
{
    public class PeopleCreateVM
    {
        public int Id;

        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter an email")]
        [Display(Name="E-mail")]
        [EmailAddress(ErrorMessage = "Invalid email")]
        public string Email { get; set; }

        [Display(Name="I Accept terms & conditions")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "You have to agree to the terms and conditions of this site!")]
        public bool AcceptTerms { get; set; }
    }
}
