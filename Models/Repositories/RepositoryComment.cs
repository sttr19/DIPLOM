using DP_60321_TROSHKO.Models.Entities;
using DP_60321_TROSHKO.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace DP_60321_TROSHKO.Models.Repositories
{
    public class RepositoryComment : IRepository<Comments>
    {

        private ApplicationDbContext context3;
        public RepositoryComment(ApplicationDbContext ctx)
        {
            context3 = ctx;
        }

        public void Create(Comments t)
        {
            context3.Comments.Add(t);
            context3.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Comments t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comments> Find(Func<Comments, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Comments Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comments> GetAll()
        {
             return context3.Comments.ToList();
        }

        public Task<Comments> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Comments t)
        {
            throw new NotImplementedException();
        }
    }
}