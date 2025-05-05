using Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using projectRest.Models;

namespace projectRest.Controllers
{
    public class CashierController : Controller
    {
        private readonly ResturantdbContext _context;
        public CashierController(ResturantdbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = (from product in _context.Products
                            join category in _context.Categories
                            on product.CategoryID equals category.CategoryID
                            select new ProductCategoryView
                            {
                                ProductID = product.ProductID,
                                Product_Name = product.Product_Name,
                                Product_Price = product.Product_Price,
                                Product_Quantity = product.Product_Quantity,
                                Product_Description = product.Product_Description,
                                Product_Image = product.Product_Image,
                                CategoryName = category.Category_Name,
                            }).ToList();
            return View(products);
        }
    }
}