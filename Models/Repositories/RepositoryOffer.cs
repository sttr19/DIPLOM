using DP_60321_TROSHKO.Models.Entities;
using DP_60321_TROSHKO.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace DP_60321_TROSHKO.Models.Repositories
{
    public class RepositoryOffer : IRepository<Offers>
    {
        private ApplicationDbContext context2;
        public RepositoryOffer(ApplicationDbContext ctx)
        {
            context2 = ctx;
        }


        public void Create(Offers t)
        {
            context2.Offers.Add(t);
            context2.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Offers t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Offers> Find(Func<Offers, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Offers Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Offers> GetAll()
        {
            return context2.Offers.ToList();
        }

        public Task<Offers> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Offers t)
        {
            Offers ee = context2.Offers.Find(t.OfferId);
           // ee.StateId = t.StateId;        
            context2.SaveChanges();
        }
    }
}