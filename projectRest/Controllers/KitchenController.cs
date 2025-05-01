using Data;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace projectRest.Controllers
{
    public class KitchenController : Controller 
    {

        private readonly ResturantdbContext _context;

        public KitchenController(ResturantdbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var order = _context.Orders
                .Select(o => new OrderSummaryView
                {
                    OrderID = o.OrderID,
                    status = o.status,
                    ProductSummary = string.Join("\n ",
                    _context.OrderProducts
                    .Where(op => op.OrderID == o.OrderID)
                    .Select(op => op.Product.Product_Name + " (" + op.Quantity + ")")
                    )
                })
                .ToList();
            return View(order);
        }
        [HttpPost]
        public IActionResult UpdateStatuses(int orderId, int status)
        {
            var order = _context.Orders.Find(orderId);
            if (order != null)
            {
                order.status = order.status == 0 ? 1 : 0;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


    }
}
