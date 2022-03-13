using Fiorello_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello_website.ViewModels
{
    public class HomeVm
    {
        public List<Slider> Sliders{ get; set; }
        public SliderDetail Detail { get; set; }
    }
}
