using System.Web.Mvc;
using Ninject;
using DP_60321_TROSHKO.Models.Interfaces;
using DP_60321_TROSHKO.Models.Entities;
using System.Linq;
using System;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using DP_60321_TROSHKO.Models;
using System.Web;
using Microsoft.AspNet.Identity.Owin;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        IRepository<AdCategories> repository;
        IRepository<AdPosts> repository1;
        IRepository<Offers> repository2;
        IRepository<Comments> repository3;

        public HomeController(IRepository<AdCategories> g, IRepository<AdPosts> k, IRepository<Offers> d, IRepository<Comments> n)
        {
            repository = g;
            repository1 = k;
            repository2 = d;
            repository3 = n;
        }

        public PartialViewResult LeftCategories()
        {
            var f = repository.GetAll();
            return PartialView(f);
        }

        public PartialViewResult LeftCategoriesC()
        {
            var f = repository.GetAll();
            return PartialView(f);
        }

        public PartialViewResult PartialAddPost()
        {

            return PartialView();
        }

        public PartialViewResult PartialAddPostContractor()
        {

            return PartialView();
        }

        public ActionResult Index()
        {
            return View();
        }

        //СПИСОК ОБЪЯВЛЕНИЙ ПО КАТЕГОРИЯМ ДЛЯ ЗАКАЗОВ
        public ActionResult ShowListPosts(int id)
        {
            var t = repository1.GetAll().Where(r => r.AdCategoryId == id && r.AdRazdId == 1);
            return View(t);
        }

        //СПИСОК ОБЪЯВЛЕНИЙ ПО КАТЕГОРИЯМ ДЛЯ ПОДРЯДЧИКОВ
        public ActionResult ShowListPostsC(int id)
        {
            var t = repository1.GetAll().Where(r => r.AdCategoryId == id && r.AdRazdId == 2);
            return View(t);
        }

        //ПОДАЧА ОБЪЯВЛЕНИЯ

        [HttpGet]
        public ActionResult CreateAdPost()
        {
            return View(new AdPosts());
        }

        [HttpPost]
        public ActionResult CreateAdPost(AdPosts h)
        {
            h.IsActual = true;
            h.Confirm = false;
            if (User.IsInRole("Заказчик"))
            {
                h.AdRazdId = 1;
            } else if (User.IsInRole("Подрядчик"))
            {
                h.AdRazdId = 2;
            }
            h.UserId = User.Identity.GetUserId();
            h.Date = DateTime.Now;
          
                repository1.Create(h);
           
            return RedirectToAction("Index", "Home");
        }

           
         


        //ОТОБРАЖЕНИЕ ОБЪЯВЛЕНИЙ ЗАКАЗЧИКОВ
        public ActionResult ShowListPostsR(int page=1)
        {
            var gw=repository1.GetAll().Where(r => r.AdRazdId == 1 && r.Confirm == true).OrderByDescending(s => s.Date);
            int pageSize = 3; // количество объектов на страницу
            return View(PageInfo<AdPosts>.CreatePage(gw, page, pageSize));
        }

       

        //ОТОБРАЖЕНИЕ ОБЪЯВЛЕНИЙ ПОДРЯДЧИКОВ
        public ActionResult ShowListPostsRI(int page = 1)
        {
            //var applicationDbContext = HttpContext.GetOwinContext().Get<ApplicationDbContext>();
            //var users = applicationDbContext.Users.ToList();
            //foreach (var n in users)
            //{
            //    if (n.Comments != null)
            //    {
            //        int t = n.Comments.Count;
            //        ViewBag.vop = t;
            //    }
            //    else continue;
            //}

            var p = repository1.GetAll().Where(d=>d.AdRazdId==2&&d.Confirm==true).OrderByDescending(s => s.Date).ToList();
            int pageSize = 3; // количество объектов на страницу
            return View(PageInfo<AdPosts>.CreatePage(p,page,pageSize)); 
        }

        public ActionResult FormContractor(string id)
        {
            return View(repository1.GetAll().Where(d => d.UserId == id).ToList());
        }

        //ОТПРАВКА ПРЕДЛОЖЕНИЯ ЗАКАЗЧИКУ ОТ ПОДРЯДЧИКА
        [HttpPost]
        public ActionResult AddOffer(int id,string s,string p)
        {
            if (ModelState.IsValid)
            {
                var g = new Offers {
                    IdPost = id,
                    UserNameClient = s,
                    UserIdClient=p,
                    StateId = 4,
                    UserIdContractor=User.Identity.GetUserId(),
                    DateOffer=DateTime.Now
                };
               
                repository2.Create(g);
            }
        

            return RedirectToAction("Index", "Home");
        }

        public ActionResult test(string id)
        {
            int q=repository3.GetAll().Where(d => d.ContractorToId == id).Count();
            ViewBag.ee = q;
            return View();
        }

    }
}