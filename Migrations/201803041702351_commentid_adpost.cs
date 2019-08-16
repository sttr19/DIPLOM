namespace DP_60321_TROSHKO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class commentid_adpost : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdPosts", "CommentId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AdPosts", "CommentId");
        }
    }
}
