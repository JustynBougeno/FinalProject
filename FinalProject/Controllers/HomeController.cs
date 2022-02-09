using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using FinalProject.Data;
using FinalProject.ViewModels;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        DataDbContext context;

        public HomeController(DataDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            List<Product> products = context.Products.ToList();
            return View(products);
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
