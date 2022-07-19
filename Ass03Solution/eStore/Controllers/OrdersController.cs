using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ass3.Library;

namespace eStore.Controllers
{
    public class OrdersController : Controller
    {
        private OrderRepository OrderRepository = null;

        // GET: OrdersController
        public ActionResult Index(int? userID)
        {
            OrderRepository = new OrderRepository();
            if (userID == null)
            {
                var orders = OrderRepository.GetOrders();
                return View(orders);
            }
            else
            {
                var orders = OrderRepository.GetOrders(userID.Value);
                return View(orders);
            }
            
        }

        // GET: OrdersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrdersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrdersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrdersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrdersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrdersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrdersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
