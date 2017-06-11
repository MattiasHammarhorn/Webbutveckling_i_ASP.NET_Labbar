using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcTenta_SUN16.Models.Entities;
using MvcTenta_SUN16.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcTenta_SUN16.Controllers
{
    public class ComputersController : Controller
    {
        MvcTentaContext context;

        public ComputersController(MvcTentaContext context)
        {
            this.context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            //if (!ModelState.IsValid)
            //    return View(TempData["SuccessfulCreationMessage"]);


            var models = context.ListComputers();

            return View(models);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ComputersCreateVM computers)
        {
            if (!ModelState.IsValid)
                return View(computers);

            context.AddComputers(computers);
            TempData["SuccessfulCreationMessage"] = "Computers successfully saved to the database.";

            return RedirectToAction(nameof(ComputersController.Index));
        }
        
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = context.FindComputersForEditById(id);

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(ComputersEditVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            context.EditComputers(model);

            return RedirectToAction(nameof(ComputersController.Index));
        }
    }
}
