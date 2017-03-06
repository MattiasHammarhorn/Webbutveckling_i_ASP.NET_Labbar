using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroupAssignment_3.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroupAssignment_3.Controllers
{
    public class PeopleController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var viewModel = DataManager.ListPeople();

            return View(viewModel);
        }

        // Får vara tom eftersom formuläret ska vara tomt
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PeopleCreateVM viewModel)
        {
            var person = new Person();

            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            DataManager.AddPerson(viewModel);
            return RedirectToAction(nameof(PeopleController.Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = DataManager.GetPersonForEdit(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(PeopleEditVM person, int id)
        {
            if (!ModelState.IsValid)
            {
                return View(person);
            }
            DataManager.EditPerson(person, id);
            return RedirectToAction(nameof(PeopleController.Index));
        }
    }
}
