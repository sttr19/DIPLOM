using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DP_60321_TROSHKO.Models.Entities
{
    public class StateOffers
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Offers> Offers { get; set; }
    }
}