using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment_Cookies.Models
{
    public class UserLoginVM
    {
        [Display(Name="Username")]
        [Required(ErrorMessage = "*Name required")]
        public string Username { get; set; }

        [Display(Name="Password")]
        [Required(ErrorMessage = "*Password required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name="StoreCookies")]
        [Range(typeof(bool), "false", "true")]
        public bool StoreCookiesAsPersistentOrNonPersisent { get; set; }
    }
}
