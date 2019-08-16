using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DP_60321_TROSHKO.Models.Entities
{
    public class Comments
    {
        public int ID { get; set;}
        public DateTime Date { get; set;}
        public string ClientFromId { get; set;}
        public string ContractorToId { get; set;}
        public string Text { get; set;}
        public int Rating { get; set; }
        public int IdPost { get; set; }

        [ForeignKey("IdPost")]
        public virtual AdPosts AdPosts { get; set; }

        [ForeignKey("ContractorToId")]
        public virtual ApplicationUser User { get; set; }

    }
}