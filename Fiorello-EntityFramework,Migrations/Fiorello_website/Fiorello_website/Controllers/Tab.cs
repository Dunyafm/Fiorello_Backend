using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello_website.Controllers
{
    public class Tab : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
