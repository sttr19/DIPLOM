using DP_60321_TROSHKO.Models.Entities;
using DP_60321_TROSHKO.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace DP_60321_TROSHKO.Models.Repositories
{
    public class RepositoryCategory:IRepository<AdCategories>
    {
        public void Create(AdCategories t)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AdCategories> Find(Func<AdCategories, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public AdCategories Get(int id)
        {
            throw new NotImplementedException();
        }


        public Task<AdCategories> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        private ApplicationDbContext context;

        public RepositoryCategory(ApplicationDbContext ctx)
        {
            context = ctx;
        }


        //context = http.GetOwinContext<EFDbContext>();
        // context=HttpContext.GetOwinContext().Get<EFDbContext>();


        public IEnumerable<AdCategories> GetAll()
        {
            //throw new NotImplementedException();
            return context.AdCategories.ToList();

        }




        public IEnumerable<AdCategories> GetCategories()
        {
            return context.AdCategories;
        }

        public AdCategories GetCategoriesById(int id)
        {
            return context.AdCategories.FirstOrDefault(x => x.AdCategoryId == id);
        }

        public void Update(AdCategories t)
        {
            throw new NotImplementedException();
        }

        public void Edit(AdCategories t)
        {
            throw new NotImplementedException();
        }
    }
}