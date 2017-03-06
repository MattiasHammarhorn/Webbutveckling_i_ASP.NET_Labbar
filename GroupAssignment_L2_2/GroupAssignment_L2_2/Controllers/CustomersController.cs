using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroupAssignment_L2_2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroupAssignment_L2_2.Controllers
{
    public class CustomersController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Customers = DataManager.GetAllCustomers();
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            DataManager.AddCustomer(customer);
            return RedirectToAction(nameof(CustomersController.Index));
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            ViewBag.Customer = DataManager.GetCustomer(id);
            return View();
        }
        
        [HttpPost]
        public IActionResult Remove(int id)
        {
            DataManager.RemoveCustomer(id);
            return RedirectToAction(nameof(CustomersController.Index));
        }
    }
}
