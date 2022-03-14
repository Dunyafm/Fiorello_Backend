//using System;
////using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

using System.Collections.Generic;

namespace Fiorello_website.Models
{
    public class Catergory : BaseEntity
    {
       
        public string Name { get; set; }
        public ICollection<Product> Products{ get; set; }

    }
}
