using Data;
using Microsoft.AspNetCore.Mvc;

namespace projectRest.Controllers
{
    public class AdminController : Controller
    {
        private readonly ResturantdbContext _Context;
        public AdminController(ResturantdbContext context)
        {
            _Context = context;
        }
        public IActionResult OrdarList()
        {
            var ordersL = _Context.Orders.ToList();
            return View(ordersL);
        }

        public IActionResult UserList()
        {
            var usersL = _Context.Customers.ToList();
            return View(usersL);
        }



    }
}
