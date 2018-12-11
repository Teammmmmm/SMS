using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Electro.Models;

namespace Electro.Controllers
{
   


public class LoginController : Controller
{
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {

            return View();
        }
        
               public IActionResult Log(string Email, string password)
        {
            var result = Users.log(Email, password);

            if (result == true)

            {
                ViewBag.messeage = "welcome to our website";

                return View("Index");
            }
            else
            {
                ViewBag.messeage = "wrong username or password";

                return View("Login");
            }

        }

    }
}
