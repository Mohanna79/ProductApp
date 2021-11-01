using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductApp_Models.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ProductApp_DataAccess.Data;


namespace ProductApp.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Product> list = _context.Products.ToList();
            return View(list);
        }
        public IActionResult Upsert(int? id)
        {
            Product product = new Product();
            if (id == null)
                return View(product);
            product = _context.Products.FirstOrDefault(c => c.Id == id);
            if (product == null)
                return NotFound();

            return View(product);
        }
        [HttpPost]
        public IActionResult Upsert(Product product)
        {
            if (product.Id==0)
                _context.Products.Add(product);
            else
            {
                _context.Products.Update(product);
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
            
        }
       
        public IActionResult Delete(int id)
        {
            var product = _context.Products.First(c => c.Id == id);
            _context.Products.Remove(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        
    }
}
