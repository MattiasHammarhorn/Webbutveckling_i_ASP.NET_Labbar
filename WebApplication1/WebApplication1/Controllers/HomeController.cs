using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Filter;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [MyFilter]
    public class HomeController : Controller
    {
        //[Route("{controller}-{action}-{id}-{name}")]
        public IActionResult Index(int id, string name)
        {
            // Test
            var model = DataManager.GetAllBands();
            ViewBag.Bands = model;
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
