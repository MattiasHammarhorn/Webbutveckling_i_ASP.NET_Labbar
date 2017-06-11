using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AuthDemo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuthDemo.Controllers
{
    public class UsersController : Controller
    {
        UserManager<IdentityUser> userManager;
        SignInManager<IdentityUser> signInManager;
        IdentityDbContext context;

        public UsersController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IdentityDbContext context)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UsersRegisterVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            // Create the DB Schema
            //await context.Database.EnsureCreatedAsync();

            // 1. Create user
            var user = new IdentityUser(model.Username);
            var result = await userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                ModelState.AddModelError(
                    nameof(UsersRegisterVM.Username),
                    result.Errors.First().Description);

                return View(model);
            }
            
            // 2. Log in user
            await signInManager.PasswordSignInAsync(model.Username, model.Password, false, false);

            // 3. Redirect user
            return RedirectToAction(nameof(UsersController.Secret));
        }

        [Authorize()]
        public string Secret()
        {
            return "The secret page...";
        }

        public string Login()
        {
            return "This is the login page...";
        }
    }
}
