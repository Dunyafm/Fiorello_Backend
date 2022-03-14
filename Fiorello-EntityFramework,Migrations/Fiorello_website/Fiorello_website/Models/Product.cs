
using System.Collections.Generic;

namespace Fiorello_website.Models
{
    public class Product : BaseEntity
    {
        //public int Id { get; set; }
        //public string Description { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public int CatergoryId { get; set; }
        public Catergory Catergory{ get; set; }
        public ICollection<ProductImage> Images { get; set; }
    }
}
