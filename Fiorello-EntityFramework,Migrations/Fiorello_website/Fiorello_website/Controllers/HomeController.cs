using Fiorello_website.Data;
using Fiorello_website.Models;
using Fiorello_website.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            SliderDetail detail = await _context.SliderDetails.FirstOrDefaultAsync();
            List<Catergory> catergories = await _context.Catergories.ToListAsync();
            List<Product> products = await _context.Products
                .Include(m => m.Catergory)
                .Include(m => m.Images)
                .ToListAsync();

            HomeVM HomeVM = new HomeVM
            {
                Sliders = sliders,
                Detail = detail,
                Categories = catergories,
                Products = products
            };


            //return View(sliders);
            return View(HomeVM);
        }
    }
}
