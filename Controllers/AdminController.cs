using DP_60321_TROSHKO.Models.Entities;
using DP_60321_TROSHKO.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DP_60321_TROSHKO.Controllers
{
    public class AdminController : Controller
    {
        IRepository<AdPosts> repository1;

        public AdminController( IRepository<AdPosts> k)
        {
            repository1 = k;
        }

        public ActionResult Index()
        {

            return View(repository1.GetAll());
        }

        public ActionResult PublicYes(int id)
        {
            var m = repository1.GetAll().First(c => c.AdPostId == id);
            m.Confirm = true;
            repository1.Update(m);
            return RedirectToAction("Index", "Admin");
        }

        //[HttpPost]
        public ActionResult PublicHide(int id)
        {
            var m = repository1.GetAll().First(c => c.AdPostId == id);
            m.Confirm = false;
            repository1.Update(m);
            return RedirectToAction("Index", "Admin");
        }
    }
}