using DP_60321_TROSHKO.Models.Entities;
using DP_60321_TROSHKO.Models.Interfaces;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DP_60321_TROSHKO.Controllers
{
    public class ContractorController : Controller
    {
        IRepository<Offers> repository2;
        IRepository<Comments> repository3;

        public ContractorController(IRepository<Offers> g, IRepository<Comments> e)
        {

            repository2 = g;
            repository3 = e;
        }
        // GET: Contractor
        public ActionResult IndexContractor()
        {
            return View(repository2.GetAll().Where(f=>f.UserIdContractor==User.Identity.GetUserId()).ToList());
        }

        //СТРАНИЦА С ОТЗЫВАМИ НА ОТДЕЛЬНОГО ПОДРЯДЧИКА
        public ActionResult ShowComments(string id)
        {
            var wq = repository3.GetAll().Where(d=>d.ContractorToId==id);
            List<int> rait = new List<int>();
            foreach (var y in wq)
            {
               string v = y.User.UserName;
                ViewBag.vop = v;
                int e = y.Rating;
                rait.Add(e);
            }
            double av = rait.Average();
            ViewBag.vop1 = av;
            return View(wq);
        }
    }
}