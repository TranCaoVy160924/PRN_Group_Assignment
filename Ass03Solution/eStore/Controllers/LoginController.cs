﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static eStore.Models.DBHelper;
using Ass3.Library;

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
                    var isMember = MemberRepository.GetMailAndPassword(email, password);
                    if(isMember != null)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
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
