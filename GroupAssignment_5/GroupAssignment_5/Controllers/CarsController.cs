using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroupAssignment_5.Models;
using GroupAssignment_5.Models.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroupAssignment_5.Controllers
{
    public class CarsController : Controller
    {
        CarsDBContext context;

        public CarsController(CarsDBContext context)
        {
            this.context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var viewModel = context.ListCars();

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CarsCreateVM viewModel)
        {
            if(!ModelState.IsValid)
            {
                return View(viewModel);
            }

            context.AddCar(viewModel);
            return RedirectToAction(nameof(CarsController.Index));
        }
    }
}
