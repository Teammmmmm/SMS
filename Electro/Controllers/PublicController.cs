using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Electro.Models;
namespace Electro.Controllers
{
    public class PublicController : Controller
    {
        public IActionResult Public()
        {
            return View();
        }
    }
}

public class PublicController : Controller
{
    public IActionResult Checkout()
    {
        return View();
    }
    public IActionResult Store()
    {
        return View();
    }
}



