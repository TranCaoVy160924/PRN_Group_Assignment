using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ass3.Library;
using Microsoft.AspNetCore.Mvc.Rendering;
using eStore.Models;
using Microsoft.EntityFrameworkCore;

namespace eStore.Controllers
{
    public class OrderDetailController : Controller
    {
        private OrderDetailRepository OrderDetailRepository = null;

        // GET: OrderDetailController
        public ActionResult Index(int orderID) 
        {
            OrderDetailRepository = new OrderDetailRepository();
            var orderDetail = OrderDetailRepository.GetOrderDetail(orderID);

            return View(orderDetail);
        }

        // GET: OrderDetailController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderDetailController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderDetailController/Create
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

        // GET: OrderDetailController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderDetailController/Edit/5
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

        // GET: OrderDetailController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderDetailController/Delete/5
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
