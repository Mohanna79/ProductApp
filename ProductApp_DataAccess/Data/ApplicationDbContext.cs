using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductApp_Models.Models;

namespace ProductApp_DataAccess.Data
{
   public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base (options )
        {

        }
        public DbSet<Product>Products { get; set; }
    }
}
