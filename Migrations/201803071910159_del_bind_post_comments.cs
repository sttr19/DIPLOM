namespace DP_60321_TROSHKO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class del_bind_post_comments : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AdPosts", "CommentId", "dbo.Comments");
            DropIndex("dbo.AdPosts", new[] { "CommentId" });
            DropColumn("dbo.AdPosts", "CommentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AdPosts", "CommentId", c => c.Int());
            CreateIndex("dbo.AdPosts", "CommentId");
            AddForeignKey("dbo.AdPosts", "CommentId", "dbo.Comments", "ID");
        }
    }
}
