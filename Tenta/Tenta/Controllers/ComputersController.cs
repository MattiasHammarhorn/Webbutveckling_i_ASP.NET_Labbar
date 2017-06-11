using System;
using Microsoft.AspNetCore.Mvc;
using Tenta.Models.Entities;
using Tenta.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tenta.Controllers
{
    public class ComputersController : Controller
    {
        TentaDbContext _context;

        public ComputersController(TentaDbContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            var vModel = _context.GetAllComputers();
            return View(vModel);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ComputerCreateVM vModel)
        {
            if (!ModelState.IsValid)
                return View(vModel);

            TempData["ConfirmationMsg"] = String.Format($"{vModel.Manufacturer} computer has successfully been added to the database.");
            _context.SaveComputer(vModel);

            return RedirectToAction(nameof(ComputersController.Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var vModel = _context.GetComputer(id);
            return View(vModel);
        }

        [HttpPost]
        public IActionResult Edit(ComputerEditVM vModel)
        {
            if (!ModelState.IsValid)
                return View(vModel);

            TempData["ConfirmationMsg"] = String.Format($"{vModel.Manufacturer} computer has successfully been edited.");

            _context.EditComputer(vModel);

            return RedirectToAction(nameof(ComputersController.Index));
        }
    }
}
