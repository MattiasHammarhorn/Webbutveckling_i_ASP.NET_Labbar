using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class JSController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetBandHtml()
        {
            return PartialView("BandBox", new BandsIndexVM
            {
                Id = 1,
                Name = "Exodus",
                IsMetal = true
            });
        }

        public BandsIndexVM GetBandJson()
        {
            return new BandsIndexVM
            {
                Id = 1,
                Name = "Sodom",
                IsMetal = true
            };
        }
    }
}
