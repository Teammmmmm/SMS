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
    public IActionResult Login()
    {
        return View();
    }
        
        public IActionResult log(string Email, string password)
        {
            var result = Users.log(Email, password);

            if (result == true)

            
                return View("Index");
            else
                return View("Login");

        }

    }
}
