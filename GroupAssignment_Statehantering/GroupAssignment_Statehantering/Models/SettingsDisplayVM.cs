using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment_Statehantering.Models
{
    public class SettingsDisplayVM
    {
        [Display(Name = "Support e-mail")]
        public string SupportEmail { get; set; }

        [Display(Name = "Company name")]
        public string CompanyName { get; set; }

        public string TempData { get; set; }
    }
}
