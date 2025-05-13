using Data;
using Microsoft.AspNetCore.Mvc;
using Models;
using Microsoft.EntityFrameworkCore;

namespace projectRest.Controllers
{
    public class AdminController : Controller
    {
        private readonly ResturantdbContext _Context;
        public AdminController(ResturantdbContext context)
        {
            _Context = context;
        }
        public IActionResult Ordars()
        {
            var ordersL = _Context.Orders.ToList();
            return View(ordersL);
        }
        [HttpPost]
        public IActionResult DeleteOrder(int id)
        {
            var order = _Context.Orders.Find(id);
            if (order != null)
            {
                _Context.Orders.Remove(order);
                _Context.SaveChanges();
                return RedirectToAction("Ordars");
            }
            return NotFound();
        }



        public IActionResult Customers()
        {
            var Customers = _Context.Customers.ToList();
            return View(Customers);
        }


        [HttpPost]
        public IActionResult DeleteCustomer(int id)
        {
            var Customer = _Context.Customers.Find(id);
            if (Customer != null)
            {
                _Context.Customers.Remove(Customer);
                _Context.SaveChanges();
                return RedirectToAction("Customers");
            }
            return NotFound();
        }


        public IActionResult Employees()
        {
            var employees = _Context.Employees.ToList();
            return View(employees);
        }
        [HttpPost]
        public IActionResult DeleteEmployee(int id)
        {
            var employee = _Context.Employees.Find(id);
            if (employee != null)
            {
                _Context.Employees.Remove(employee);
                _Context.SaveChanges();
                return RedirectToAction("Employees");
            }
            return NotFound();
        }


        public IActionResult Prodacts()
        {
            var products = _Context.Products.ToList();
            return View(products);
        }

        public IActionResult DeleteProduct(int id)
        {
            var product = _Context.Products.Find(id);
            if (product != null)
            {
                _Context.Products.Remove(product);
                _Context.SaveChanges();
                return RedirectToAction("Prodacts");
            }
            return NotFound();
        }










        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _Context.Products.Add(product);
                _Context.SaveChanges();
                return RedirectToAction("Prodacts");
            }
            return View(product);
        }

        [HttpGet]
        public IActionResult CreateEmployee()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _Context.Employees.Add(employee);
                _Context.SaveChanges();
                return RedirectToAction("Employees");
            }
            return View(employee);
        }

        [HttpGet]
        public IActionResult CreateOrder()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateOrder(Order order)
        {
            if (ModelState.IsValid)
            {
                _Context.Orders.Add(order);
                _Context.SaveChanges();
                return RedirectToAction("Ordars");
            }
            return View(order);
        }

    }
}