using Fiorello_website.Data;
using Fiorello_website.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello_website.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
            
        }
        public async Task <IActionResult> Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();

            return View(sliders);
        }
    }
}
