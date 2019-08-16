using DP_60321_TROSHKO.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DP_60321_TROSHKO.Models
{
    public partial class ApplicationDbContext
    {
        public DbSet<AdCategories> AdCategories { get; set; }
        public DbSet<AdPosts> Posts { get; set; }
        public DbSet<AdRazds> AdRazds { get; set; }
        public DbSet<Offers> Offers { get; set; }
        public DbSet<Comments> Comments { get; set; }
    }
}