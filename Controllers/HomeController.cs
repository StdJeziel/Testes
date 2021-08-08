using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Control.Models;

namespace Control.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
