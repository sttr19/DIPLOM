using DP_60321_TROSHKO.Models.Entities;
using DP_60321_TROSHKO.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web;

namespace DP_60321_TROSHKO.Models.Repositories
{
    public class RepositoryPost:IRepository<AdPosts>
    {
        private ApplicationDbContext context1;
        public RepositoryPost(ApplicationDbContext ctx)
        {
            context1 = ctx;
        }

        public void Create(AdPosts t)
        {

            context1.Posts.Add(t);
            context1.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(AdPosts t)
        {
            AdPosts ff = context1.Posts.Find(t.AdPostId);
            ff.Text = t.Text;
            ff.Town = t.Town;
            ff.Title = t.Title;
            ff.Price = t.Price;
            context1.SaveChanges();
        }

        public IEnumerable<AdPosts> Find(Func<AdPosts, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public AdPosts Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AdPosts> GetAll()
        {
            return context1.Posts.Include(pp=>pp.Comments).ToList();
        }

      

        public Task<AdPosts> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        //public IEnumerable<AdPosts> GetPost()
        //{
        //    return context.AdPosts;
        //}

        public void Update(AdPosts t)
        {
            AdPosts ff = context1.Posts.Find(t.AdPostId);
            context1.SaveChanges();
        }
    }
}