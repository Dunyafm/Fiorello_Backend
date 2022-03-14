using Fiorello_website.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello_website.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderDetail> SliderDetails { get; set; }
         public DbSet<Product> Products { get; set; }
        public DbSet<Catergory> Catergories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
    }
}
