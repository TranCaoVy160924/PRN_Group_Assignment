using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static eStore.Models.DBHelper;
using Ass3.Library;
using eStore.Models;

namespace eStore.Controllers
{
    public class MembersController : Controller
    {
        private IMemberRepository MemberRepository = null;

        // GET: MembersController
        public ActionResult Index()
        {
            MemberRepository = new MemberRepository();

            var memberList = MemberRepository.GetMembers();
            return View(memberList);
        }

        // GET: MembersController/Details/5
        public ActionResult Details(int id)
        {
            MemberRepository = new MemberRepository();

            var member = MemberRepository.GetMemberByID(id);
            if (member == null)
            {
                return NotFound();
            } 
            return View(member);
        }

        // GET: MembersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MembersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {
            try
            {
                MemberRepository = new MemberRepository();
                if (ModelState.IsValid)
                {
                    MemberRepository.InsertMember(member);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        // GET: MembersController/Edit/5
        public ActionResult Edit(int id)
        {
            MemberRepository = new MemberRepository();
            var member = MemberRepository.GetMemberByID(id);
            return View(member);
        }

        // POST: MembersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Member member)
        {
            MemberRepository = new MemberRepository();
            
            try
            {
                if (ModelState.IsValid)
                {
                    MemberRepository.UpdateMember(member);
                }
                if (member.IsAdmin)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(member);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        // GET: MembersController/Delete/5
        public ActionResult Delete(int id)
        {
            MemberRepository = new MemberRepository();
            var member = MemberRepository.GetMemberByID(id);
            return View(member);
        }

        // POST: MembersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            MemberRepository = new MemberRepository();
            try
            {
                MemberRepository.DeleteMember(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
