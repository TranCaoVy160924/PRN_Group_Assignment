using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static eStore.Models.DBHelper;
using Ass3.Library;
using System.Web;
using eStore.Models;

namespace eStore.Controllers
{
    public class LoginController : Controller
    {
        private IMemberRepository MemberRepository = null;

        // GET: LoginController
        public ActionResult Index()
        {
            return View();
        }

        // POST: LoginController
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult btnLogin(string txtEmail, string txtPassword)
        {
            try
            {            
                MemberRepository = new MemberRepository();
                if (ModelState.IsValid)
                {
                    var email = Convert.ToString(txtEmail);
                    var password = Convert.ToString(txtPassword);
                    Member member = MemberRepository.GetMailAndPassword(email, password);
                    if(member != null)
                    {
                        HttpContext.Session.SetObject("MEMBER", member);
                        return RedirectToAction("Index", "Home");
                    }
                }
                TempData["ErrorMessage"] = "Username or password is wronng!!!";
                return RedirectToAction(nameof(Index));

            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }


    }
}
