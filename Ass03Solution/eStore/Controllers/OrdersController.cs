using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ass3.Library;
using Microsoft.AspNetCore.Mvc.Rendering;
using eStore.Models;

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
            OrderRepository = new OrderRepository();
            var order = OrderRepository.GetOrderByID(id);
            return View(order);
        }

        // GET: OrdersController/Create
        public ActionResult Create()
        {
            ViewBag.MemberId = GetMemberList();
            return View();
        }

        // POST: OrdersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserOrderViewModel orderViewModel)
        {
            OrderRepository = new OrderRepository();
            
            try
            {
                if (ModelState.IsValid)
                {
                    UserOrder userOrder = orderViewModel.ToDBModel();
                    if(userOrder.Freight > 0)
                    {
                        OrderRepository.InsertOrder(userOrder);
                    }
                    else
                    {
                        TempData["ErrorMessage"] = "Input must > 0";
                        return RedirectToAction(nameof(Create));
                    }
                } 
                else
                {
                    throw new Exception("Error");
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(orderViewModel);
            }
        }

        // GET: OrdersController/Edit/5
        public ActionResult Edit(int id)
        {
            OrderRepository = new OrderRepository();
            ViewBag.MemberId = GetMemberList();
            var userOrder = OrderRepository.GetOrderByID(id);
            return View(new UserOrderViewModel(userOrder));
        }

        // POST: OrdersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, UserOrderViewModel orderViewModel)
        {
            OrderRepository = new OrderRepository();

            try
            {
                if (ModelState.IsValid)
                {
                    UserOrder userOrder = orderViewModel.ToDBModel();
                    if(userOrder.Freight > 0)
                    {
                        OrderRepository.UpdateOrder(userOrder);
                    }
                    else
                    {
                        TempData["ErrorMessage"] = "Input must > 0";
                        return RedirectToAction(nameof(Edit));
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(orderViewModel);
            }
        }

        // GET: OrdersController/Delete/5
        public ActionResult Delete(int id)
        {
            OrderRepository = new OrderRepository();
            var userOrder = OrderRepository.GetOrderByID(id);
            return View(userOrder);
        }

        // POST: OrdersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, UserOrder userOrder)
        {
            OrderRepository = new OrderRepository();
            try
            {
                OrderRepository.DeleteOrder(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private List<SelectListItem> GetMemberList()
        {
            MemberRepository memberRepository = new MemberRepository();
            var members = memberRepository.GetMembers();
            var memberIdList = new List<SelectListItem>();

            foreach (var member in members)
            {
                memberIdList.Add(new SelectListItem()
                {
                    Text = member.MemberId.ToString() + ". " + member.Email,
                    Value = member.MemberId.ToString()
                });
            }

            return memberIdList;
        }
    }
}
