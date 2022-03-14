using Fiorello_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello_website.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders{ get; set; }
        public List<Catergory> Categories { get; set; }
        public List<Product> Products { get; set; }
        public SliderDetail Detail { get; set; }
    }
}
