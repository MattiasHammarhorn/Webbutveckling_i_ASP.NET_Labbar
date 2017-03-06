using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using GroupAssignment_Statehantering.Models;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroupAssignment_Statehantering.Controllers
{
    public class SettingsController : Controller
    {
        IMemoryCache cache;

        public SettingsController(IMemoryCache cache)
        {
            this.cache = cache;
        }

        // GET: /<controller>/
        public IActionResult Create()
        {
            return View();
        }

        // Returns the standard view if the model state isn't valid,
        // otherwise it will store the viewModel's SupportMail-property in the cache,
        // set a session string to the that of the viewModel's company name
        // and sets a value to the TempData, it then redirects the user to the display view
        [HttpPost]
        public IActionResult Create(SettingsCreateVM viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                cache.Set("SupportEmail", viewModel.SupportEmail);
                HttpContext.Session.SetString("CompanyName", viewModel.CompanyName);
                TempData["Message"] = "Dina värden har sparats!";

                return RedirectToAction(nameof(SettingsController.Display));
            }
        }

        // Creates a new SettingsDisplayVM and sets its values,
        // to that of the cache's, the session's and the TempData's strings
        // and then returns the View with that model's properties so that we
        // can display them in inside the View
        [HttpGet]
        public IActionResult Display()
        {
            var model = new SettingsDisplayVM { SupportEmail = cache.Get<string>("SupportEmail"),
                CompanyName = HttpContext.Session.GetString("CompanyName"),
                TempData = (string)TempData["Message"] };

            return View(model);
        }
    }
}
