using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static eStore.Models.DBHelper;
using Ass3.Library;

namespace eStore.Controllers
{
    public class ReportsController : Controller
    {
        private IOrderDetailRepository OrderDetailRepository = null;

        // GET: ReportsController
        public ActionResult Index(string Generate, DateTime startDate , DateTime endDate)
        {
            OrderDetailRepository = new OrderDetailRepository();
            List<Report> report = null;
            if(Generate == null)
            {
                report = OrderDetailRepository.GetAll();
            }
            else
            {
                report = OrderDetailRepository.GetSaleReport(startDate, endDate);
                ViewBag.startDate = startDate;
                ViewBag.endDate = endDate;
            }
            return View(report);
        }

    }
}
