using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroupAssignment_7.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroupAssignment_7.Controllers
{
    public class CustomersController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            if (!ModelState.IsValid)
                return View();
            else
            {
                var models = DataManager.CustomersToList();
                
                return View(models);
            }
        }
        
        public IActionResult GetCustomerDetails(int id)
        {
            if (!ModelState.IsValid)
                return View();
            else
            {
                var viewModel = DataManager.GetCustomerVM(id);
                return PartialView("CompanyBox", viewModel);
            }
        }

        public CustomersIndexVM[] GetCustomersJson()
        {
            return DataManager.CustomersToList();
        }
    }
}
