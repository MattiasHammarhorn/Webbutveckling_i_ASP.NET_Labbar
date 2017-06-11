using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroupAssignment_Cookies.Models;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroupAssignment_Cookies.Controllers
{
    public class CookiesController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserLoginVM viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {

                if (viewModel.StoreCookiesAsPersistentOrNonPersisent)
                {
                    Response.Cookies.Append("username", viewModel.Username,
                    new CookieOptions { Expires = DateTime.Now.AddSeconds(60) });
                }
                else
                {
                    Response.Cookies.Append("username", viewModel.Username);
                }

                return RedirectToAction("Welcome");
            }
            
        }
        
        public IActionResult Welcome()
        {
            var model = new UserWelcomeVM { Username = Request.Cookies["username"] };

            return View(model);
        }
    }
}
