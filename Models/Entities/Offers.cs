using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DP_60321_TROSHKO.Models.Entities
{
    public class Offers
    {
        [Key]
        public int OfferId { get; set;}
       
        public int IdPost { get; set;}

        [ForeignKey("IdPost")]
        public virtual  AdPosts AdPosts { get; set;}

        public int? StateId { get; set;}

        [ForeignKey("StateId")]
        public virtual StateOffers StateOffers { get; set; }


        public  DateTime? DateOffer { get; set;}
        public string UserIdContractor { get; set;}
        public string UserIdClient { get; set;}
        public string UserNameClient { get; set;}

        [ForeignKey("UserIdContractor")]
        public virtual ApplicationUser User { get; set; }
    }
}