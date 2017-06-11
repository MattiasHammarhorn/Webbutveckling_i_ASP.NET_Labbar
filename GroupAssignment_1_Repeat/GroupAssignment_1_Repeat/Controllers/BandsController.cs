using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroupAssignment_1_Repeat.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroupAssignment_1_Repeat.Controllers
{
    public class BandsController : Controller
    {
        DataManager dataManager;

        public BandsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var models = dataManager.ListBands();
            return View(models);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            if (!ModelState.IsValid)
                return View();

            var model = dataManager.GetBand(id);
            return View(model);
        }
    }
}
