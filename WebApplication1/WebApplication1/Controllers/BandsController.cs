using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class BandsController : Controller
    {
        public IActionResult Index()
        {
            var model = DataManager.GetIndexList();
            var formSumbmitted = HttpContext.Session.GetString("FormSubmitted");
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Band band)
        {
            if (!ModelState.IsValid)
                return View(band);

            DataManager.AddBand(band);
            HttpContext.Session.SetString("FormSubmitted", DateTime.Now.ToString());

            return RedirectToAction(nameof(BandsController.Index));
        }
    }
}
