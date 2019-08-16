using DP_60321_TROSHKO.Models;
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
    public class ClientController : Controller
    {
        IRepository<Offers> repository2;
        IRepository<AdPosts> repository1;
        IRepository<Comments> repository3;
     

        public ClientController(IRepository<Offers> d, IRepository<AdPosts> k, IRepository<Comments> w)
        {
           
            repository2 = d;
            repository1 = k;
            repository3 = w;
        }

        // GET: Client
        public ViewResult Index()
        {
            return View();
        }

        public ActionResult OffersFrom()
        {
            return View(repository2.GetAll().ToList().Where(t => t.UserIdClient == User.Identity.GetUserId()));
        }

        //public ActionResult GetOrders()
        //{
        //    var a = repository1.GetAll().ToList().Where(t => t.UserId == User.Identity.GetUserId());
        //    var b = repository2.GetAll().ToList();
        //    var lop = new List<int>();
        //    ViewBag.con1 = lop;

        //    foreach (var d in b)
        //        {
        //            if (d.StateId == 1)
        //            { 
        //                lop.Add(d.IdPost);
        //            }
        //        }
        //    return View(a);
        // }

        public ActionResult GetOrders()
        {
            var a = repository1.GetAll().ToList().Where(t => t.UserId == User.Identity.GetUserId());
            var b = repository2.GetAll().ToList();
            var lop = new List<int>();
            ViewBag.con1 = lop;
            
            
            
            foreach (var d1 in a)
            {
                foreach (var d in b.Where(s=>s.StateId==1))
                {
                    if (d1.AdPostId == d.IdPost)
                    {
                        lop.Add(d1.AdPostId);
                    }
                }
              
            }
            return View(a);
        }

       

        //ДОБАВЛЕНИЕ ОТЗЫВА ПОДРЯДЧИКУ
        [HttpGet]
        public ActionResult AddComment()
        {
            return View(new Comments());
        }

        [HttpPost]
        public ActionResult AddComment(int id, Comments g)
        {
            if (ModelState.IsValid)
            {
                var rt = repository2.GetAll().First(y => y.IdPost == id);    
                g.ClientFromId = rt.UserIdClient;
                g.ContractorToId = rt.UserIdContractor;
                g.IdPost = rt.IdPost;
                g.Date = DateTime.Now;
                repository3.Create(g);
            }  
            return RedirectToAction("GetOrders", "Client");
        }


  



        // РЕЗУЛЬТАТ ОТ НАЖАТИЯ КНОПКИ "НАЗНАЧИТЬ ИСПОЛНИТЕЛЕМ"
        [HttpPost]
        public ActionResult AcceptOffer(int IdPost,AdPosts gg, Offers dd,int IdOffer)
        {
            gg = repository1.GetAll().FirstOrDefault(s => s.AdPostId == IdPost);
            gg.IsActual = false;
            repository1.Update(gg);   //снятие заказа с публикации
            dd = repository2.GetAll().FirstOrDefault(r => r.OfferId ==IdOffer );
            dd.StateId = 1;  
            repository2.Update(dd);   //назначение определенного Подрядчика в исполнители
            var j = repository2.GetAll().Where(h=>h.IdPost==IdPost);
            foreach (Offers f in j)
                {
                if (f.StateId!=1&&f.StateId!=2)
                    f.StateId = 3;
                repository2.Update(f);
            }
                                      //отображение у Подрядчиков, которые высылали свои предложения на этот заказ "Исполнитель определен"    

            return RedirectToAction("OffersFrom", "Client");
        }


        // РЕЗУЛЬТАТ ОТ НАЖАТИЯ КНОПКИ "ОТКАЗАТЬ"
        public ActionResult Refuse(int IdOffer, Offers ss)
        {
            ss = repository2.GetAll().FirstOrDefault(r => r.OfferId == IdOffer);
            ss.StateId = 2;
            repository2.Update(ss);
            return RedirectToAction("OffersFrom", "Client");
        }

        //РЕДАКТИРОВАНИЕ ОБЪЯВЛЕНИЯ ЗАКАЗЧИКОМ
        [HttpGet]
        public ActionResult EditPost(int id)
        {
            var ty = repository1.GetAll().First(f => f.AdPostId == id);
            return View(ty);
        }
        [HttpPost]
        public ActionResult EditPost(AdPosts r)
        {
            if (ModelState.IsValid)
            {
                repository1.Edit(r);
            }
            return RedirectToAction("GetOrders", "Client");
        }
    }
}