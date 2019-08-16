using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_60321_TROSHKO.Models.Entities
{
    public class AdCategories
    {
        public string Name { get; set; }
        [Key]
        public int AdCategoryId { get; set; }

        public virtual List<AdPosts> AdPosts { get; set; }
    }
}
