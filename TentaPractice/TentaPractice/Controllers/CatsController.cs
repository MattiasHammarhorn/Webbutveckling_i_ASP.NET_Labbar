using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TentaPractice.Models;
using TentaPractice.Models.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TentaPractice.Controllers
{
    public class CatsController : Controller
    {
        TentaPracticeDBContext context;

        public CatsController(TentaPracticeDBContext context)
        {
            this.context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var models = context.ListCats();
            return View(models);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CatsCreateVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            context.AddCat(model);
            return RedirectToAction(nameof(CatsController.Index));
        }
    }
}
