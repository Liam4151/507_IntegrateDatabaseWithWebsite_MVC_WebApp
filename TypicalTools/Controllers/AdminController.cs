using TypicalTools.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using System.Data;

namespace TypicalTools.Controllers
{
    public class AdminController : Controller
    {
        private readonly ContextModel _mainContextModel;

        // Displays admin login page
        public IActionResult AdminLogin()
        {
            return View();
        }

        // Authenticates username and password so user can login   
        [HttpPost]
        public IActionResult AdminLogin(Admin user)
        {
            // Checks if username and password details are correct
            if (user.Username.Equals("Admin") && user.Password.Equals("SecurePassword123"))
            {   
                // Authenticates use if correct
                HttpContext.Session.SetString("Authenticated", "True");
            }
            // Returns user to index/products page 
            return RedirectToAction("Index", "Product");
        }
    }
}
