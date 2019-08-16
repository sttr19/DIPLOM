using DP_60321_TROSHKO.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DP_60321_TROSHKO.Models
{
    public class PageInfo<T>:List<T>
    {

        public int TotalPages { get; private set; }
        public int CurrentPage { get; private set; }

        private PageInfo(List<T> items, int total, int current)
        {
            this.AddRange(items);
            TotalPages = total;
            CurrentPage = current;
        }

        public static PageInfo<T> CreatePage(IEnumerable<T> items, int current, int pageSize)
        {
            var totalCount = items.Count();
            var pagesCount = (int)Math.Ceiling(totalCount / (double)pageSize);
            var list = items
            .Skip(pageSize * (current - 1))
            .Take(pageSize)
            .ToList();
            return new PageInfo<T>(list, pagesCount, current);
        }
    }
  
}
