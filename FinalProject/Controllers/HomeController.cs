using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using FinalProject.Data;
using FinalProject.ViewModels;
using System.Collections.Generic;
using System;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        DataDbContext context;

        public HomeController(DataDbContext dbContext)
        {
            context = dbContext;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var products = from p in context.Products
                           select p;
            if (!String.IsNullOrEmpty(searchString))
            {
                Console.WriteLine(searchString);
                products = products.Where(s => s.productName!.Contains(searchString));
            }
            
            return View(await products.ToListAsync());
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet("/Add")]
        public IActionResult AddProduct()
        {
            AddProductViewModel addProductViewModel = new AddProductViewModel();
            return View(addProductViewModel);
        }

        [HttpPost]
        public IActionResult ProcessProductForm(AddProductViewModel addProductViewModel)
        {
            
            
                Product newProduct = new Product
                {
                    productName = addProductViewModel.productName,
                    productType = addProductViewModel.productType,
                    productPrice = addProductViewModel.productPrice,
                    productUnitAmount = addProductViewModel.productUnitAmount,
                };
                context.Products.Add(newProduct);
                context.SaveChanges();
                return Redirect("/");
        }
    }
}
