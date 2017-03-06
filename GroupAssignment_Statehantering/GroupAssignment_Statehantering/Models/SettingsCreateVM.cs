using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment_Statehantering.Models
{
    public class SettingsCreateVM
    {
        [Display(Name = "Support e-mail")]
        [Required(ErrorMessage = "*E-mail required")]
        public string SupportEmail { get; set; }

        [Display(Name = "Company name")]
        [Required(ErrorMessage = "*Company name required")]
        public string CompanyName { get; set; }

        public string TempData { get; set; }
    }
}
